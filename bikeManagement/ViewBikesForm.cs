using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.bikeManagement
{
    public partial class ViewBikesForm : Form
    {
        public ViewBikesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load data with related table(model1) and re-orgnize data structure
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var bikes = from allBikes in kiwiBike4RentEntities.BIKEs.Include("MODEL1")
                            select new
                            {   allBikes.BikeID,
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
                if (!string.IsNullOrEmpty(categoryBox.Text))
                {
                    bikes = bikes.Where(b => b.Category == categoryBox.Text);
                }
                if (!string.IsNullOrEmpty(modelBox.Text))
                {
                    Int32.TryParse(modelBox.Text, out int i);
                    bikes = bikes.Where(b => b.Model == i );
                }
                if (!string.IsNullOrEmpty(brandBox.Text))
                {
                    bikes = bikes.Where(b => b.Brand == brandBox.Text);
                }
                if (!string.IsNullOrEmpty(statusBox.Text))
                {
                    bikes = bikes.Where(b => b.Status == statusBox.Text);
                }
                if (!string.IsNullOrEmpty(rentalBox.Text))
                {
                    int i = 0;
                    Int32.TryParse(rentalBox.Text, out i);
                    if(i == 0)
                    {
                        MessageBox.Show("Rental price must be a number");
                        rentalBox.Focus();
                        return;
                    }
                    bikes = bikes.Where(b => b.RentalPrice < i);
                }
                //put data to dataGridview
                dgvViewBikes.DataSource = bikes.ToList();

            }
        }

        private void ViewBikesForm_Load(object sender, EventArgs e)
        {
            //initial combobox data
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var brand = kiwiBike4RentEntities.MODELs.Select(b => b.Brand).Distinct();
                foreach(string b in brand.ToList()){
                    brandBox.Items.Add(b);
                }
                var category = kiwiBike4RentEntities.MODELs.Select(c => c.Category).Distinct();
                foreach (string c in category.ToList())
                {
                    categoryBox.Items.Add(c);
                }
                var model = kiwiBike4RentEntities.MODELs.Select(m => m.ModelID).Distinct();
                foreach (int m in model)
                {
                    modelBox.Items.Add(m);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
