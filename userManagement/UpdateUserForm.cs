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
    public partial class UpdateUserForm : Form
    {
        private int staffID;
        public UpdateUserForm()
        {
            InitializeComponent();
        }
        public UpdateUserForm(int staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                string query = "UPDATE STAFF SET" +
                    " Name = @Name,UserName = @UserName, Tel = @tel, ExtNumber = @extNumber" +
                    ",Password = @password, Address = @address," +
                    "OfficeAddress = @officeAddress,UserType = @userType, Role =@role WHERE StaffID = @staffID";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@staffID", staffID);
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@UserName", txtUserName.Text);
                sqlCommand.Parameters.AddWithValue("@tel", txtTel.Text);
                sqlCommand.Parameters.AddWithValue("@extNumber", txtExtNumber.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@OfficeAddress", txtOfficeAddress.Text);
                sqlCommand.Parameters.AddWithValue("@userType", lboxUserType.Text);
                sqlCommand.Parameters.AddWithValue("@role", lboxRole.Text);
                //add validator for role and userType if admin function added
                try
                {
                    if (1 == sqlCommand.ExecuteNonQuery())
                    {
                        MessageBox.Show("Staff Updated!", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show("Something Wrong!!!\n" + sqlE.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                string query = "SELECT * FROM STAFF WHERE StaffID = @staffID";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@staffID", staffID);
                SqlDataReader sqlData = sqlCommand.ExecuteReader();

                if (sqlData.Read())
                {
                    txtAddress.Text = (string)sqlData["Address"];
                    txtExtNumber.Text = (string)sqlData["ExtNumber"];
                    txtName.Text = (string)sqlData["Name"];
                    txtOfficeAddress.Text = (string)sqlData["OfficeAddress"];
                    txtPassword.Text = (string)sqlData["Password"];
                    lboxRole.SelectedIndex = lboxRole.FindString((string)sqlData["Role"]);
                    txtTel.Text = (string)sqlData["Tel"];
                    txtUserName.Text = (string)sqlData["UserName"];
                    lboxUserType.SelectedIndex = lboxUserType.FindString((string)sqlData["UserType"]);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
