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
                var rentals = from allRentals in kiwiBike4RentEntities.RENTALs.Include("BIKEs").Include("CUSTOMERs").Include("STAFFs")
                              select new
                              {
                                  allRentals.RentalID,
                                  CustomerID = allRentals.CustomerID,
                                  CustomerName = allRentals.CUSTOMER.Name,
                                  BiKeRentByStaffID = allRentals.StaffID,
                                  StaffName = allRentals.STAFF.Name,
                                  allRentals.Status,
                                  allRentals.Deposit,
                                  allRentals.StartDate,
                                  allRentals.EndDate,
                                  allRentals.ReturnDate,
                                  allRentals.Fine,
                                  allRentals.HirePrice,
                                  allRentals.BIKE.BikeID,
                                  allRentals.BIKE.RentalPrice,
                                  BikeStatus = allRentals.BIKE.Status
                              };
                dgvRentals.DataSource = rentals.ToList();
            }
        }
    }
}
