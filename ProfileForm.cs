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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Name,UserName,Password,Address,Tel,OfficeAddress,ExtNumber,UserType,Role
            txtName.Text = LoginInfo.currentUser.Name;
            txtUsername.Text = LoginInfo.currentUser.UserName;
            txtTel.Text = LoginInfo.currentUser.Tel;
            txtExtNumber.Text = LoginInfo.currentUser.ExtNumber;
            txtUserType.Text = LoginInfo.currentUser.UserType;
            txtRole.Text = LoginInfo.currentUser.Role;
            txtPassword.Text = LoginInfo.currentUser.Password;
            txtAddress.Text = LoginInfo.currentUser.Address;
            txtOfficeAddress.Text = LoginInfo.currentUser.OfficeAddress;

            // user can not change permission in profile.
            txtUserType.Enabled = false;
            txtRole.Enabled = false;

            //focus
            txtName.Focus();
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var staff = from s in kiwiBike4RentEntities.STAFFs
                              where s.StaffID == LoginInfo.currentUser.StaffID
                              select s;
                staff.SingleOrDefault().Name = txtName.Text;
                staff.SingleOrDefault().UserName = txtUsername.Text;
                staff.SingleOrDefault().Tel = txtTel.Text;
                staff.SingleOrDefault().ExtNumber = txtExtNumber.Text;
                staff.SingleOrDefault().Password = txtPassword.Text;
                staff.SingleOrDefault().Address = txtAddress.Text;
                staff.SingleOrDefault().OfficeAddress = txtOfficeAddress.Text;
                kiwiBike4RentEntities.SaveChanges();
                LoginInfo.currentUser = (STAFF)staff.SingleOrDefault();//sync
            }
            MessageBox.Show("Profile Updated!", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
