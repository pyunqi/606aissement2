using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.RentalManagement.customerManagement
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CUSTOMER customer = new CUSTOMER();
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name can not be empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                customer.Name = txtName.Text;
            }
            if (String.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Tel can not be empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                customer.Tel = txtTel.Text;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address can not be empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                customer.Address = txtAddress.Text;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email can not be empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                customer.email = txtEmail.Text;
            }
            if (String.IsNullOrEmpty(dtpAddCustomer.Text))
            {
                MessageBox.Show("txtName can not be empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime dob = Convert.ToDateTime(dtpAddCustomer.Value.ToString("D"));
                customer.DOB = dob;
            }
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                kiwiBike4RentEntities.CUSTOMERs.Add(customer);
                kiwiBike4RentEntities.SaveChanges();
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
