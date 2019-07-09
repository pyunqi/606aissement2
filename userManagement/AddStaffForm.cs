using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.userManagement
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter Staff's Name!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter Staff's Username!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Please enter Staff's Tel!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtExtNumber.Text))
            {
                MessageBox.Show("Please enter Staff's ExtNumber!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExtNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Staff's Password!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter Staff's Address!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtOfficeAddress.Text))
            {
                MessageBox.Show("Please enter Staff's OfficeAddress!", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOfficeAddress.Focus();
                return;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                string query = "INSERT INTO STAFF VALUES" +
                    " (@Name,@UserName, @password, @address,@tel, @officeAddress,@extNumber" +
                    ",'staff', 'check-out')";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@UserName", txtUsername.Text);
                sqlCommand.Parameters.AddWithValue("@tel", txtTel.Text);
                sqlCommand.Parameters.AddWithValue("@extNumber", txtExtNumber.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@OfficeAddress", txtOfficeAddress.Text);
                //add change usertype&role capability if admin function avaliable
                try
                {
                    if (1 == sqlCommand.ExecuteNonQuery())
                    {
                        MessageBox.Show("Staff Added!", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show("Something Wrong!!!\n"+sqlE.Message,"SQL Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
