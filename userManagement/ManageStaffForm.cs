using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.userManagement
{
    public partial class ManageStaffForm : Form
    {
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                StringBuilder query = new StringBuilder("Select * FROM STAFF");
                // according to conditions to generate sqlcommand
                if (radioStaffID.Checked)
                {
                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                        Boolean isNumber = Int32.TryParse(txtID.Text, out int id);
                        if (isNumber)
                        {
                            query.Append(" WHERE StaffID = @id");
                            SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                            sqlCommand.Parameters.AddWithValue("@id", id);
                            fillStaffView(ds, sqlCommand, dgvStaff);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Staff ID has to be a number!!", "Wrong Staff ID!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else if (radioNAR.Checked)
                {
                    if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(lboxRole.Text))
                    {
                        //check role;
                        if (!Constants.roles.Contains(lboxRole.Text.ToLower()))
                        {
                            MessageBox.Show("Wrong Role Type!", "Inputs Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lboxRole.Focus();
                            return;
                        }
                        query.Append(" WHERE Name = @name and Role = @role");
                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                        sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@role", lboxRole.Text);
                        fillStaffView(ds, sqlCommand, dgvStaff);
                        return;
                    }
                    else if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        query.Append(" WHERE Name = @name");
                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                        sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                        fillStaffView(ds, sqlCommand, dgvStaff);
                        return;
                    }
                    else if (!string.IsNullOrEmpty(lboxRole.Text))
                    {
                        //check role;
                        if (!Constants.roles.Contains(lboxRole.Text.ToLower()))
                        {
                            MessageBox.Show("Wrong Role Type!", "Inputs Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lboxRole.Focus();
                            return;
                        }
                        query.Append(" WHERE Role = @role");
                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                        sqlCommand.Parameters.AddWithValue("@role", lboxRole.Text);
                        fillStaffView(ds, sqlCommand, dgvStaff);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Need a Name or a Role or Both!!", "Inputs Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (radioAll.Checked)
                {
                    SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                    fillStaffView(ds, sqlCommand, dgvStaff);
                    return;
                }
                else
                {
                    MessageBox.Show("Please Check Searching Staff in All or BY ID or Name and Role!!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private static void fillStaffView(DataSet ds, SqlCommand sqlCommand, DataGridView dgvStaff)
        {
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(ds, "STAFF");
            }
            dgvStaff.DataSource = ds.Tables[0];
        }

        private void radioStaff_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtName.Enabled = false;
            lboxRole.Enabled = false;
        }

        private void radioNAR_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtName.Enabled = true;
            lboxRole.Enabled = true;
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            lboxRole.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one row for updating per time!", "One Row Per Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvStaff.SelectedRows[0];
            Int32.TryParse(row.Cells[0].Value.ToString(), out int staffID);
            UpdateUserForm updateUserForm = new UpdateUserForm(staffID);
            updateUserForm.ShowDialog();
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                StringBuilder query = new StringBuilder("Select * FROM STAFF");
                SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                fillStaffView(ds, sqlCommand, dgvStaff);
            }
        }

    }
}
