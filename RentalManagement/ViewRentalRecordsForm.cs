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
    public partial class ViewRentalRecordsForm : Form
    {
        public ViewRentalRecordsForm()
        {
            InitializeComponent();
        }

        private void btnSearchRentals_Click(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                int customerID = -1;
                Int32.TryParse(txtCustomerID.Text, out customerID);
                if (customerID <= 0)
                {
                    MessageBox.Show("Customer ID must be a number and greater than 0!");
                    return;
                }
                else
                {
                    //show  all rental records in  RENTAL 
                    String rented = Constants.status[1];
                    var rentals = from allRentals in kiwiBike4RentEntities.RENTALs.Include("BIKEs")
                                  .Include("CUSTOMERs").Include("STAFFs")
                                  .Where(r => r.CustomerID == customerID)
                                  select new
                                  {
                                      allRentals.RentalID,
                                      CustomerName = allRentals.CUSTOMER.Name,
                                      allRentals.BIKE.BikeID,
                                      allRentals.BIKE.MODEL1.Brand,
                                      allRentals.BIKE.MODEL1.Category,
                                      allRentals.BIKE.MODEL1.Dimension,
                                      allRentals.BIKE.MODEL1.Weight,
                                      allRentals.BIKE.MODEL1.ModelID,
                                      allRentals.BIKE.ManufacturedYear,
                                      allRentals.BIKE.LifeTime,
                                      allRentals.BIKE.Status,
                                      allRentals.Deposit,
                                      allRentals.StartDate,
                                      allRentals.EndDate,
                                      allRentals.ReturnDate,
                                      allRentals.Fine,
                                      allRentals.HirePrice,
                                  };
                    dgvRentals.DataSource = rentals.ToList();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShowOverDueBikes_Click(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                int customerID = -1;
                Int32.TryParse(txtCustomerID.Text, out customerID);
                if (customerID <= 0)
                {
                    MessageBox.Show("Customer ID must be a number and greater than 0!");
                    return;
                }
                else
                {
                    String rented = Constants.status[1];
                    var rentals = from allRentals in kiwiBike4RentEntities.RENTALs.Include("BIKEs")
                                  .Include("CUSTOMERs").Include("STAFFs")
                                  .Where(r => r.CustomerID == customerID)
                                  .Where(r => r.EndDate < System.DateTime.Now)
                                  select new
                                  {
                                      allRentals.RentalID,
                                      allRentals.StartDate,
                                      allRentals.EndDate,
                                      allRentals.ReturnDate,
                                      allRentals.Fine,
                                      CustomerName = allRentals.CUSTOMER.Name,
                                      allRentals.BIKE.BikeID,
                                      allRentals.BIKE.MODEL1.Brand,
                                      allRentals.BIKE.MODEL1.Category,
                                      allRentals.BIKE.MODEL1.Dimension,
                                      allRentals.BIKE.MODEL1.Weight,
                                      allRentals.BIKE.MODEL1.ModelID,
                                      allRentals.BIKE.ManufacturedYear,
                                      allRentals.BIKE.LifeTime,
                                      allRentals.BIKE.Status,
                                      allRentals.Deposit,
                                      allRentals.HirePrice,
                                  };
                    dgvRentals.DataSource = null;
                    dgvRentals.DataSource = rentals.ToList();
                }
            }
        }
    }
}
