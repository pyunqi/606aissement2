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
    public partial class ManageRentalRecords : Form
    {
        public ManageRentalRecords()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllRentedBikes_Click(object sender, EventArgs e)
        {

            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                //show  all rental records in  RENTAL 
                var rentals = from allRentals in kiwiBike4RentEntities.RENTALs.Include("BIKEs")
                                 .Include("CUSTOMERs").Include("STAFFs")
                              select new
                              {
                                  allRentals.RentalID,
                                  CustomerName = allRentals.CUSTOMER.Name,
                                  allRentals.BIKE.BikeID,
                                  allRentals.StartDate,
                                  allRentals.EndDate,
                                  allRentals.ReturnDate,
                                  allRentals.BIKE.MODEL1.Brand,
                                  allRentals.BIKE.MODEL1.Category,
                                  allRentals.BIKE.MODEL1.Dimension,
                                  allRentals.BIKE.MODEL1.Weight,
                                  allRentals.BIKE.MODEL1.ModelID,
                                  allRentals.BIKE.ManufacturedYear,
                                  allRentals.BIKE.LifeTime,
                                  allRentals.BIKE.Status,
                                  allRentals.Deposit,
                                  allRentals.Fine,
                                  allRentals.HirePrice,
                              };

                var results = rentals.OrderBy(r => r.StartDate);

                if (rbEnd.Checked)
                {
                    results = rentals.OrderBy(r => r.EndDate);
                }
                else if (rbReturn.Checked)
                {
                    results = rentals.OrderBy(r => r.ReturnDate);
                }
                dgvBikeRentals.DataSource = results.ToList();
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var rentalsGroupBy = kiwiBike4RentEntities.RENTALs.Include("BIKEs")
                        .Include("CUSTOMERs").Include("STAFFs").GroupBy(r => r.BikeID)
                    .Select(g => new { BikeID = g.Key, count = g.Count() });
            }

        }
    }
}
