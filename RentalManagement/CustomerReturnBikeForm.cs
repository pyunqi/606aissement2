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
            loadRentals();
        }

        private void loadRentals()
        {
            using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
            {
                CUSTOMER customer = kiwiBike4RentEntities.CUSTOMERs.Where(c => c.CustomerID == customerID).SingleOrDefault();
                String status = Constants.rentalStatus[0];
                txtCustomerInfo.Text = "ID: " + customer.CustomerID + ", Name: " + customer.Name;
                var rentals = kiwiBike4RentEntities.RENTALs.Include("BIKE").Include("CUSTOMER")
                    .Where(r => r.CustomerID == customerID && r.Status == status).Select(r =>
                    new
                    {
                        r.CUSTOMER.Name,
                        r.BIKE.MODEL1.Brand,
                        r.BIKE.MODEL1.Category,
                        r.Deposit,
                        r.BIKE.RentalPrice,
                        r.BIKE.Accessories,
                        r.BIKE.MODEL1.Rate,
                        r.StartDate,
                        r.EndDate,
                        r.RentalID,
                        r.BikeID
                    })
                    .ToList();
                dgvShowRentals.DataSource = rentals;
            }
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {
            if (!Constants.status.Contains(lboxStatus.Text))
            {
                MessageBox.Show("Bike Returned status must be given in available,sold, maintenance!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            int fine = -1;
            Int32.TryParse(txtFine.Text, out fine);
            if (fine<0)
            {
                MessageBox.Show("Fine must be a number and greater than or equal 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int hiredPrice = -1;
            Int32.TryParse(txtHiredPrice.Text, out hiredPrice);
            if (hiredPrice < 0)
            {
                MessageBox.Show("HiredPrice must be a number and greater than or equal 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvShowRentals.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one bike for return!", "One Row Per Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewCellCollection cells = dgvShowRentals.SelectedRows[0].Cells;
            //cauculate return deposit or need to pay how much
            int totalPrice = -1;
            Int32.TryParse(txtTotal.Text, out totalPrice);
            if(totalPrice < 0)
            {
                MessageBox.Show("Total price must be a number and greater than or equal 0!","Wrong Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int deposit = Convert.ToInt32(cells[3].Value);
            StringBuilder message = new StringBuilder();
            message.Append("The slected Bike will return by customer:").Append(cells[0].Value).Append("\n need to retrun deposit :").Append(deposit - totalPrice);
            DialogResult result = MessageBox.Show(message.ToString(),"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == result)
            {
                int rentalID = Convert.ToInt32(cells[9].Value.ToString());
                using (KiwiBike4RentEntities kiwiBike4RentEntities = new KiwiBike4RentEntities())
                {
                    RENTAL rental = kiwiBike4RentEntities.RENTALs.Include("BIKE").Where(r => r.RentalID == rentalID).SingleOrDefault();
                    rental.Status = Constants.rentalStatus[1];
                    rental.BIKE.Status = lboxStatus.Text;
                    rental.ReturnDate = System.DateTime.Now;
                    rental.HirePrice = hiredPrice;
                    rental.Fine = fine;
                    kiwiBike4RentEntities.SaveChanges();
                }
                DialogResult continueRturnResult = MessageBox.Show("Is there other bike need to return by current customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.No == continueRturnResult)
                {
                    this.Close();
                }
                else
                {
                    txtHiredPrice.Clear();
                    txtHiredDays.Clear();
                    txtDeposit.Clear();
                    txtFine.Clear();
                    txtOverDueDays.Clear();
                    txtRentalPrice.Clear();
                    txtTotal.Clear();
                    loadRentals();
                }
            }else if (DialogResult.No == result)
            {
                return;
            }


        }

        //auto input and cauculate checkout information
        private void dgvShowRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCellCollection cells = dgvShowRentals.Rows[e.RowIndex].Cells;
                txtDeposit.Text = cells[3].Value.ToString();
                int factDays = System.DateTime.Now.Subtract(Convert.ToDateTime(cells[7].Value.ToString())).Days;
                int planDays = (Convert.ToDateTime(cells[8].Value.ToString()) - Convert.ToDateTime(cells[7].Value.ToString())).Days;
                int overDueDays = factDays - planDays;
                txtRentalPrice.Text = cells[4].Value.ToString();
                txtHiredDays.Text = factDays.ToString();
                if (overDueDays < 0)
                {
                    overDueDays = 0;
                }
                txtOverDueDays.Text = overDueDays.ToString();
                int hiredPrice = factDays * Convert.ToInt16(cells[4].Value);
                txtHiredPrice.Text = hiredPrice.ToString();
                int fine = overDueDays * Convert.ToInt16(cells[6].Value);
                txtFine.Text = fine.ToString();
                txtTotal.Text = (hiredPrice + fine).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
