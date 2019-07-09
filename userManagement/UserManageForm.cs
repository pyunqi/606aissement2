using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.userManagement
{
    public partial class UserManageForm : Form
    {
        public UserManageForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageStaffForm manageStaffForm = new ManageStaffForm();
            manageStaffForm.ShowDialog();
        }
    }
}
