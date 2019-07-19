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
    public partial class CustomerReturnBikeForm : Form
    {
        int customerID;
        String bikeStatus;
        public CustomerReturnBikeForm(int cID)
        {
            InitializeComponent();
            this.customerID = cID;
            this.bikeStatus = Constants.status[0];
        }

        private void ReturnBikeToCustomerForm_Load(object sender, EventArgs e)
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                CUSTOMER customer = kiwiBike4RentEntities.CUSTOMERs.Where(c => c.CustomerID == customerID).SingleOrDefault();
                String status = Constants.rentalStatus[0];
                txtCustomerInfo.Text = "ID: " + customer.CustomerID + ", Name: " + customer.Name;
                var rentals = kiwiBike4RentEntities.RENTALs.Include("BIKE")
                    .Where(r => r.CustomerID == customerID && r.Status == status).Select(r =>
                    new
                    {
                        r.BIKE.MODEL1.Brand,
                        r.BIKE.MODEL1.Category,
                        r.Deposit,
                        r.BIKE.RentalPrice,
                        r.BIKE.Accessories,
                        r.BIKE.MODEL1.Rate,
                        r.StartDate,
                        r.EndDate
                    })
                    .ToList();
                dgvShowRentals.DataSource = rentals;
            }
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {

        }

        //auto input and cauculate checkout information
        private void dgvShowRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCellCollection cells = dgvShowRentals.Rows[e.RowIndex].Cells;

                txtDeposit.Text = cells[2].Value.ToString();
                int factDays = System.DateTime.Now.Subtract(Convert.ToDateTime(cells[6].Value.ToString())).Days;
                int planDays = (Convert.ToDateTime(cells[7].Value.ToString()) - Convert.ToDateTime(cells[6].Value.ToString())).Days;
                int overDueDays = factDays - planDays;
                txtRentalPrice.Text = cells[3].Value.ToString();
                txtHiredDays.Text = factDays.ToString();
                if (overDueDays < 0)
                {
                    overDueDays = 0;
                }
                txtOverDueDays.Text = overDueDays.ToString();
                int hiredPrice = factDays * Convert.ToInt16(cells[3].Value);
                txtHiredPrice.Text = hiredPrice.ToString();
                int fine = overDueDays * Convert.ToInt16(cells[5].Value);
                txtFine.Text = fine.ToString();
                txtTotal.Text = (hiredPrice + fine).ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
