using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.RentalManagement
{
    public partial class RentBikeDashboard : Form
    {
        public RentBikeDashboard()
        {
            InitializeComponent();
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            customerManagement.AddCustomerForm addCustomerForm = new customerManagement.AddCustomerForm();
            addCustomerForm.ShowDialog();
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                dgvCustomers.DataSource = getAllCustomers(kiwiBike4RentEntities); ;
            }
        }

        private void RentBikeDashboard_Load(object sender, EventArgs e)
        {
            //load all customers from database
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            int cID = 0;
            Int32.TryParse(txtCustomerID.Text, out cID);
            DateTime dob = Convert.ToDateTime(dtpCustomerDOB.Value.ToString("D"));

            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                List<CUSTOMER> customers = null;

                if (rbCustomerID.Checked)
                {
                    if (cID > 0)
                    {
                        customers = kiwiBike4RentEntities.CUSTOMERs.Include("RENTALs").Where(c => c.CustomerID == cID).ToList<CUSTOMER>();
                    }
                    else
                    {
                        MessageBox.Show("Customer ID has to bigger than 0", "Wrong Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (rbDOB.Checked)
                {
                    customers = kiwiBike4RentEntities.CUSTOMERs.Include("RENTALs").Where(c => c.DOB == dob).ToList<CUSTOMER>();
                }
                else if (rbAll.Checked)
                {
                    customers = getAllCustomers(kiwiBike4RentEntities);

                }

                dgvCustomers.DataSource = customers;
            }
        }

        private static List<CUSTOMER> getAllCustomers(KiwiBike4RentEntities kiwiBike4RentEntities)
        {
            return kiwiBike4RentEntities.CUSTOMERs.Include("RENTALs").ToList<CUSTOMER>();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            dtpCustomerDOB.Enabled = false;
        }

        private void rbCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            dtpCustomerDOB.Enabled = false;
        }

        private void rbDOB_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            dtpCustomerDOB.Enabled = true;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            customerManagement.UpdateCustomerForm updateCustomerForm = new customerManagement.UpdateCustomerForm(getSelectCustomerID());
            updateCustomerForm.ShowDialog();
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                dgvCustomers.DataSource = getAllCustomers(kiwiBike4RentEntities); ;
            }
        }

        private void btnRentBike_Click(object sender, EventArgs e)
        {
            int cID = getSelectCustomerID();
            if (cID <= 0)
            {
                return;
            }
            RentalManagement.RentBikeToCustomerForm rentBikeToCustomerForm = new RentBikeToCustomerForm(cID);
            this.Hide();
            rentBikeToCustomerForm.ShowDialog();
            this.Show();
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {
            int cID = getSelectCustomerID();

        }

        private int getSelectCustomerID()
        {
            int cID = 0;
            if (dgvCustomers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select ONE ROW per time for updating!", "Select ONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return cID;
            }
            else
            {
                Int32.TryParse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString(), out cID);
            }
            return cID;
        }

    }
}
