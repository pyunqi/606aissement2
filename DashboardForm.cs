using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiwiBike4Rent.bikeManagement;
using KiwiBike4Rent.userManagement;

namespace KiwiBike4Rent
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UserManageForm userManagementForm = new UserManageForm();
            userManagementForm.ShowDialog();
        }


        private void btnRentBkie_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            else
            {
                //do nothing
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void btnViewBkies_Click(object sender, EventArgs e)
        {
            ViewBikesForm viewBikesForm = new ViewBikesForm();
            viewBikesForm.ShowDialog();
        }

        private void btnUpdateBikes_Click(object sender, EventArgs e)
        {
            ManageBikesForm manageBikesForm = new ManageBikesForm();
            manageBikesForm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //according to role value in 'admin', 'management', 'check-out' to control permision
            String role = LoginInfo.currentUser.Role;
            if ("check-out".Equals(role))
            {
                btnUserManage.Enabled = false;
                btnManageBikes.Enabled = false;
            }
            else if ("management".Equals(role))
            {
                //btnCheckOut.Enabled = false;
            }
            else if ("admin".Equals(role))
            {

            }
            else
            {
                btnUserManage.Enabled = false;
                //btnRentBkie.Enabled = false;
               // btnCheckOut.Enabled = false;
            }

        }
    }
}
