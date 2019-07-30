using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

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

        private void btnAllOverdueBikes_Click(object sender, EventArgs e)
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

                DateTime today = System.DateTime.Now;
                var results = rentals.Where(r => today > r.EndDate || r.ReturnDate > r.EndDate);
                dgvBikeRentals.DataSource = results.ToList();
            }
        }


        private void btnTop_Click(object sender, EventArgs e)
        {
            getTop(1);

        }


        private void btnLeast_Click(object sender, EventArgs e)
        {
            getTop(0);
        }
        //OrderByDescending when Descend = 1
        private void getTop(int Descend)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                var rentalsGroupBy = kiwiBike4RentEntities.RENTALs.Include("BIKEs")
                        .Include("CUSTOMERs").Include("STAFFs").GroupBy(r => r.BikeID)
                    .Select(g => new { BikeID = g.Key, count = g.Count() });
                if (Descend == 1) {

                    rentalsGroupBy =  rentalsGroupBy.OrderByDescending(g => g.count);
                }
                else
                {
                    rentalsGroupBy = rentalsGroupBy.OrderBy(g => g.count);
                }
                int[] bikes = new int[5];
                int[] counts = new int[5];
                int i = 0;
                foreach (var gr in rentalsGroupBy.Take(5).ToList())
                {
                    bikes[i] = gr.BikeID;
                    counts[i] = gr.count;
                    i++;
                }

                var top5Bikes = kiwiBike4RentEntities.BIKEs.Where(b => bikes.Contains(b.BikeID))
                    .Select(
                    b => new
                    {
                        b.BikeID,
                        b.MODEL1.Brand,
                        b.MODEL1.Category,
                        b.MODEL1.Deposit,
                        b.MODEL1.Description,
                        b.MODEL1.Dimension,
                        b.MODEL1.Rate,
                        b.MODEL1.Weight,
                        b.ManufacturedYear,
                        b.LifeTime,
                        b.RentalPrice,
                        b.Status
                    }
                    );


                var emptyList = new List<Tuple<int, int, string, string, double, string, string, int>>()
                    .Select(t => new
                    {
                        BikeID = t.Item1,
                        Count = t.Item2,
                        Brand = t.Item3,
                        Category = t.Item4,
                        Weight = t.Item5,
                        Description = t.Item6,
                        Dimension = t.Item7,
                        Rate = t.Rest
                    }).ToList();

                int n = 0;
                foreach (var o in top5Bikes)
                {
                    var bike = new
                    {
                        BikeID = o.BikeID,
                        Count = counts[n],
                        Brand = o.Brand,
                        Category = o.Category,
                        Weight = o.Weight,
                        Description = o.Description,
                        Dimension = o.Dimension,
                        Rate = o.Rate
                    };
                    emptyList.Add(bike);
                    n++;
                }
                dgvBikeRentals.DataSource = emptyList;

            }
        }


    }
}
