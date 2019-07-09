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

namespace KiwiBike4Rent.bikeManagement
{
    public partial class ManageBikesForm : Form
    {
        public ManageBikesForm()
        {
            InitializeComponent();
        }
   
        private void UpdateBikesForm_Load(object sender, EventArgs e)
        {

            //load data with related table(model1) and re-orgnize data structure
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var brand = kiwiBike4RentEntities.MODELs.Select(b => b.Brand).Distinct();
                foreach (string b in brand.ToList())
                {
                    boxBrand.Items.Add(b);
                }
                var category = kiwiBike4RentEntities.MODELs.Select(c => c.Category).Distinct();
                foreach (string c in category.ToList())
                {
                    boxCategory.Items.Add(c);
                }
                var model = kiwiBike4RentEntities.MODELs.Select(m => m.ModelID).Distinct();
                foreach (int m in model)
                {
                    boxModel.Items.Add(m);
                }
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1")
                            select new
                            {
                                allBikes.BikeID,
                                Model = allBikes.MODEL1.ModelID,
                                allBikes.MODEL1.Brand,
                                allBikes.MODEL1.Category,
                                allBikes.Status,
                                allBikes.RentalPrice,
                                allBikes.MODEL1.Dimension,
                                allBikes.MODEL1.Weight,
                                allBikes.MODEL1.Description,
                                allBikes.MODEL1.Deposit,
                                allBikes.MODEL1.Rate,
                                allBikes.Accessories,
                                allBikes.LifeTime,
                                allBikes.ManufacturedYear,
                                allBikes.rentedDate,
                                allBikes.dueBackDate
                            };
              
                dgvManageBikes.DataSource = bikes.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //load data with related table(model1) and re-orgnize data structure
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1")
                            select new
                            {
                                allBikes.BikeID,
                                Model = allBikes.MODEL1.ModelID,
                                allBikes.MODEL1.Brand,
                                allBikes.MODEL1.Category,
                                allBikes.Status,
                                allBikes.RentalPrice,
                                allBikes.MODEL1.Dimension,
                                allBikes.MODEL1.Weight,
                                allBikes.MODEL1.Description,
                                allBikes.MODEL1.Deposit,
                                allBikes.MODEL1.Rate,
                                allBikes.Accessories,
                                allBikes.LifeTime,
                                allBikes.ManufacturedYear,
                                allBikes.rentedDate,
                                allBikes.dueBackDate
                            };

                //according to inputs to filter result 
                if (!string.IsNullOrEmpty(boxCategory.Text))
                {
                    bikes = bikes.Where(b => b.Category == boxCategory.Text);
                }
                if (!string.IsNullOrEmpty(boxModel.Text))
                {
                    Int32.TryParse(boxModel.Text, out int i);
                    bikes = bikes.Where(b => b.Model == i);
                }
                if (!string.IsNullOrEmpty(boxBrand.Text))
                {
                    bikes = bikes.Where(b => b.Brand == boxBrand.Text);
                }
                if (!string.IsNullOrEmpty(boxStatus.Text))
                {
                    bikes = bikes.Where(b => b.Status == boxStatus.Text);
                }
                if (!string.IsNullOrEmpty(txtRentalPrice.Text))
                {
                    int i = 0;
                    Int32.TryParse(txtRentalPrice.Text, out i);
                    if (i == 0)
                    {
                        MessageBox.Show("Rental price must be a number");
                        txtRentalPrice.Focus();
                        return;
                    }
                    bikes = bikes.Where(b => b.RentalPrice < i);
                }
                //put data to dataGridview
                dgvManageBikes.DataSource = bikes.ToList();

            }
        }

        public void FreshBikes()
        {
            //load data with related table(model1) and re-orgnize data structure
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1")
                            select new
                            {
                                allBikes.BikeID,
                                Model = allBikes.MODEL1.ModelID,
                                allBikes.MODEL1.Brand,
                                allBikes.MODEL1.Category,
                                allBikes.Status,
                                allBikes.RentalPrice,
                                allBikes.MODEL1.Dimension,
                                allBikes.MODEL1.Weight,
                                allBikes.MODEL1.Description,
                                allBikes.MODEL1.Deposit,
                                allBikes.MODEL1.Rate,
                                allBikes.Accessories,
                                allBikes.LifeTime,
                                allBikes.ManufacturedYear,
                                allBikes.rentedDate,
                                allBikes.dueBackDate
                            };
                dgvManageBikes.DataSource = bikes.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBikeForm addBikeForm = new AddBikeForm();
            addBikeForm.ShowDialog();
            FreshBikes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvManageBikes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one row for updating per time!", "One Row Per Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int bikeID = 0;
            DataGridViewRow row = dgvManageBikes.SelectedRows[0];
            Int32.TryParse(row.Cells[0].Value.ToString(),out bikeID);
            UpdateBikeForm updateBikeForm = new UpdateBikeForm(bikeID);
            updateBikeForm.ShowDialog();
            FreshBikes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvManageBikes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select at least one row for deleteing action!!","Delete Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (DataGridViewRow row in dgvManageBikes.SelectedRows)
            {
                StringBuilder bikeTempInfo = new StringBuilder();
                foreach (DataGridViewCell c in row.Cells)
                {
                    bikeTempInfo.Append(c.Value).Append(", ");
                }
                DialogResult result =  MessageBox.Show("This Bike will be deleted!!!\n" + bikeTempInfo.ToString(), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    //delete
                    using (KiwiBike4RentEntities kiwi = new KiwiBike4RentEntities())
                    {
                        Int32.TryParse(row.Cells[0].Value.ToString(), out int bikeID);
                        BIKE bike = new BIKE { BikeID = bikeID };
                        kiwi.BIKEs.Attach(bike);
                        kiwi.BIKEs.Remove(bike);
                        kiwi.SaveChanges();
                    }

                    continue;
                }
                if (DialogResult.No == result)
                {
                    continue;
                }
                if (DialogResult.Cancel == result)
                {
                    break;
                }
            }
            FreshBikes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
