using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //var for role which include 'admin', 'management', 'check-out'
        String userType = "";

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textPassword.Focus();
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                privligeSwitchGroup.Focus();
        }

        private void radioStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void radioManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void radioAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                MessageBox.Show("Username can not be empty", "Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Password can not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Focus();
                return;
            }
            if (!radioManager.Checked && !radioStaff.Checked)
            {
                MessageBox.Show("Please Choose A Role!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (KiwiBike4RentEntities kb4rEntites = new KiwiBike4RentEntities())
                {
                    var result = kb4rEntites.Login_Procedure(textUsername.Text, textPassword.Text, userType).SingleOrDefault();
                    if(1 == result)
                    {
                        this.Hide();
                        MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var role = from staff in kb4rEntites.STAFFs
                                      where staff.UserName == textUsername.Text
                                      select staff;
                  
                        LoginInfo.currentUser = role.FirstOrDefault<STAFF>(); //current user is saved in global scope
                        Dashboard dashboard = new Dashboard(); 
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! Please check username or pasword!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("ArgumentNullException", ae.Source);
                MessageBox.Show("Paramters can not be null!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioStaff_CheckedChanged(object sender, EventArgs e)
        {
            userType = "staff";
        }

        private void radioManager_CheckedChanged(object sender, EventArgs e)
        {
            userType = "manager";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
