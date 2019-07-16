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
    public partial class RentBikeToCustomerForm : Form
    {
        int customerID;
        String bikeStatus;
        public RentBikeToCustomerForm(int cID)
        {
            InitializeComponent();
            this.customerID = cID;
            this.bikeStatus = Constants.status[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //load data with related table(model1) and re-orgnize data structure
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1").Where(b => b.Status == bikeStatus)
                            select new
                            {
                                allBikes.BikeID,
                                allBikes.MODEL1.Category,
                                allBikes.Accessories,
                                allBikes.MODEL1.Deposit,
                                allBikes.RentalPrice,
                                allBikes.MODEL1.Rate,
                                allBikes.MODEL1.Brand,
                                allBikes.MODEL1.Dimension,
                                allBikes.MODEL1.Weight,
                                allBikes.MODEL1.Description,
                                allBikes.ManufacturedYear,
                                Model = allBikes.MODEL1.ModelID
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
                    bikes = bikes.Where(b => b.RentalPrice <= i);
                }
                //put data to dataGridview
                dgvShowBikes.DataSource = bikes.ToList();

            }
        }

        private void RentBikeToCustomerForm_Load(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                CUSTOMER customer = kiwiBike4RentEntities.CUSTOMERs.Where(c => c.CustomerID == customerID).SingleOrDefault();
                txtCustomerInfo.Text = "ID: " + customer.CustomerID + ", Name: " + customer.Name;
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
                //only available bikes
                boxStatus.Text = bikeStatus;
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1").Where(b => b.Status == bikeStatus)
                            select new
                            {
                                allBikes.BikeID,
                                allBikes.MODEL1.Category,
                                allBikes.Accessories,
                                allBikes.MODEL1.Deposit,
                                allBikes.RentalPrice,
                                allBikes.MODEL1.Rate,
                                allBikes.MODEL1.Brand,
                                allBikes.MODEL1.Dimension,
                                allBikes.MODEL1.Weight,
                                allBikes.MODEL1.Description,
                                allBikes.ManufacturedYear,
                                Model = allBikes.MODEL1.ModelID
                            };
                dgvShowBikes.DataSource = bikes.ToList();
            }
        }

        private void dgvAddDeposit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
               String deposit = dgvShowBikes.Rows[e.RowIndex].Cells[3].Value.ToString();
               txtDeposit.Text = deposit;
            }
        }
    }
}
