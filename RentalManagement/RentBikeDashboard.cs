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
            //how to receive last added customer id?
        }

        private void RentBikeDashboard_Load(object sender, EventArgs e)
        {
            //load all customers from database
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpCustomerDOB.Value.ToString());
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                if (rbCustomerID.Checked)
                {

                }
                else if (rbDOB.Checked)
                {

                }
                else if(rbAll.Checked)
                {
                    var customers = kiwiBike4RentEntities.CUSTOMERs.ToList<CUSTOMER>();
                    dgvCustomers.DataSource = customers;
                }
            }
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
    }
}
