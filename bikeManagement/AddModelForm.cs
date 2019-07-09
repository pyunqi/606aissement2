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
    public partial class AddModelForm : Form
    {
        public AddModelForm()
        {
            InitializeComponent();
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // data check
  
            if (string.IsNullOrEmpty(textBrand.Text))
            {
                MessageBox.Show("Brand can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBrand.Focus();
                return;
            }
            if (string.IsNullOrEmpty(categoryBox.Text))
            {
                MessageBox.Show("Category can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryBox.Focus();
                return;
            }
            if (!Constants.categories.Contains(categoryBox.Text))
            {
                MessageBox.Show("Please choose a category in existed list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textWeight.Text))
            {
                MessageBox.Show("Weight can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textWeight.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textDimension.Text))
            {
                MessageBox.Show("Dimension can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDimension.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textDeposit.Text))
            {
                MessageBox.Show("Deposit can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDeposit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textRate.Text))
            {
                MessageBox.Show("Rate can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textRate.Focus();
                return;
            }
            //insert data
            MODEL model = new MODEL();
            model.Brand = textBrand.Text;
            model.Category = categoryBox.Text;
            model.Description = descriptionBox.Text;
            model.Dimension = textDimension.Text;
            float weight = 0;
            float.TryParse(textWeight.Text, out weight);
            if(weight <= 0)
            {
                MessageBox.Show("Weight time has to be a number and > 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textWeight.Focus();
                return;
            }
            model.Weight = weight;

            int deposit = 0;
            Int32.TryParse(textDeposit.Text, out deposit);
            if (deposit <= 0)
            {
                MessageBox.Show("Deposit has to be a number and > 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDeposit.Focus();
                return;
            }
            model.Deposit = deposit;

            int rate = 0;
            Int32.TryParse(textRate.Text, out rate);
            if (rate < 10 || rate >50)
            {
                MessageBox.Show("Rate has to be a number in range between 10 to 50 !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textRate.Focus();
                return;
            }
            model.Rate = rate;

            using (KiwiBike4RentEntities kiwi = new KiwiBike4RentEntities())
            {
                kiwi.MODELs.Add(model);
                kiwi.SaveChanges();
            }
            MessageBox.Show("Bike Model Added!", "Model", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
