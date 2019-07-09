using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.bikeManagement
{
    public partial class AddBikeForm : Form
    {
        public AddBikeForm()
        {
            InitializeComponent();
        }

        private void AddBikeForm_Load(object sender, EventArgs e)
        {
            //custom data format
            dtpManufactured.Format = DateTimePickerFormat.Custom;
            dtpManufactured.CustomFormat = "yyyy";
            dtpManufactured.ShowUpDown = true;
            //load model data
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
               
                var models = from m in kiwiBike4RentEntities.MODELs
                            select m;
                foreach(MODEL m in models.ToList())
                {
                    listModels.Items.Add("Model ID: "+m.ModelID+" , Brand: "+m.Brand+ ", Category:" + m.Category + ", Weight: " + m.Weight + ", Description: " + m.Description + ", Dimension: " + m.Dimension + ", Deposit: " + m.Deposit + ", Rate: " + m.Rate );
                }
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            // data check
            string modelText = listModels.GetItemText(listModels.SelectedItem);
            if (string.IsNullOrEmpty(modelText))
            {
                MessageBox.Show("Bike model can not be empty!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                listModels.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lboxStatus.Text))
            {
                MessageBox.Show("Status can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lboxStatus.Focus();
                return;
            }
            if (!Constants.status.Contains(lboxStatus.Text))
            {
                MessageBox.Show("Please choose a status in existed list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lboxStatus.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(dtpManufactured.Text))
            {
                MessageBox.Show("Manufactory Time can not be empty!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpManufactured.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtLifeTime.Text))
            {
                MessageBox.Show("Life Time can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLifeTime.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRentalPrice.Text))
            {
                MessageBox.Show("Rental Price can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRentalPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lboxAccessories.Text))
            {
                MessageBox.Show("Accessory can not be empty!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                lboxAccessories.Focus();
                return;
            }
            if (!Constants.asscessories.Contains(lboxAccessories.Text))
            {
                MessageBox.Show("Please choose a asscessory in existed list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lboxAccessories.Focus();
                return;
            }
            //insert data
            BIKE bike = new BIKE();
            int modelID = 0;
            Int32.TryParse(modelText.Split(',')[0].Split(':')[1], out modelID);
            bike.Model = modelID;
            int lifeTime = 0;
            Int32.TryParse(txtLifeTime.Text, out lifeTime);
            if(lifeTime <= 0 )
            {
                MessageBox.Show("life time has to be a number and bigger than 0!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtLifeTime.Focus();
                return;
            }
            bike.LifeTime = lifeTime;
            int my = 0;
            Int32.TryParse(dtpManufactured.Text, out my);
            if (my <= 0 || my < 1960)
            {
                MessageBox.Show("Manufactured Year can not less than 1960", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpManufactured.Focus();
                return;
            }
            bike.ManufacturedYear = new DateTime(my,1,1);
            int rentalPrice = 0;
            Int32.TryParse(txtRentalPrice.Text, out rentalPrice);
            if (rentalPrice <= 0)
            {
                MessageBox.Show("Rental Price has to be a number and > 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRentalPrice.Focus();
                return;
            }
            bike.RentalPrice = rentalPrice;
            bike.Status = lboxStatus.Text;
            bike.Accessories = lboxAccessories.Text;
            using (KiwiBike4RentEntities kiwi = new KiwiBike4RentEntities())
            {
                kiwi.BIKEs.Add(bike);
                kiwi.SaveChanges();
            }
            MessageBox.Show("Bike Added!", "Bike", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            AddModelForm addModel = new AddModelForm();
            addModel.ShowDialog();
            FreshBikeModel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FreshBikeModel();
        }

        private void FreshBikeModel()
        {
            listModels.Items.Clear();
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {

                var models = from m in kiwiBike4RentEntities.MODELs
                             select m;
                foreach (MODEL m in models.ToList())
                {
                    listModels.Items.Add("Model ID: " + m.ModelID + " , Brand: " + m.Brand + ", Category:" + m.Category + ", Weight: " + m.Weight + ", Description: " + m.Description + ", Dimension: " + m.Dimension + ", Deposit: " + m.Deposit + ", Rate: " + m.Rate);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
