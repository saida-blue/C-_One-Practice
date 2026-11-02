using System;
using System.Windows.Forms;

namespace maanta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age;
            int nights;
            int guests;

            if (!int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests) ||
                age < 18 || age > 90 ||
                nights < 1 || nights > 30 ||
                guests < 1 || guests > 6)
            {
                MessageBox.Show("Please enter valid values.");
                return;
            }

            if (txtGuestName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the guest name.");
                return;
            }

            string roomType;
            decimal rate;
            int capacity;

            if (rdoStandard.Checked)
            {
                roomType = "Standard";
                rate = 50m;
                capacity = 32;
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
                rate = 80m;
                capacity = 4;
            }
            else if (rdoHight.Checked)
            {
                roomType = "Hight";
                rate = 130m;
                capacity = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            lstResults.Items.Clear();

            if (guests > capacity)
            {
                lstResults.Items.Add("Booking: REJECTED");
                lstResults.Items.Add("Room type: " + roomType);
                lstResults.Items.Add("Maximum guests: " + capacity);

                MessageBox.Show(
                    "Booking rejected. This room cannot accommodate that many guests.");
                return;
            }

            decimal basicRoomCost = rate * nights * guests;

            decimal stayDiscountRate;

            if (nights >= 10)
            {
                stayDiscountRate = 0.12m;
            }
            else if (nights >= 5)
            {
                stayDiscountRate = 0.05m;
            }
            else
            {
                stayDiscountRate = 0m;
            }

            decimal stayDiscount = basicRoomCost * stayDiscountRate;

            decimal seniorDiscount = 0m;

            if (age >= 60)
            {
                seniorDiscount = basicRoomCost * 0.05m;
            }

            decimal breakfastCost = 0m;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10m * nights * guests;
            }

            decimal serviceSurcharge = 0m;

            if (guests > 4)
            {
                serviceSurcharge = basicRoomCost * 0.05m;
            }

            decimal finalCost = basicRoomCost
                                - stayDiscount
                                - seniorDiscount
                                + breakfastCost
                                + serviceSurcharge;

            lstResults.Items.Add("Booking: APPROVED");
            lstResults.Items.Add("Guest name: " + txtGuestName.Text.Trim());
            lstResults.Items.Add("Guest age: " + age);
            lstResults.Items.Add("Number of guests: " + guests);
            lstResults.Items.Add("Number of nights: " + nights);
            lstResults.Items.Add("Room type: " + roomType);
            lstResults.Items.Add("Rate per night: $" + rate.ToString("N2"));
            lstResults.Items.Add("Basic room cost: $" + basicRoomCost.ToString("N2"));
            lstResults.Items.Add("Stay discount: $" + stayDiscount.ToString("N2"));
            lstResults.Items.Add("Senior discount: $" + seniorDiscount.ToString("N2"));
            lstResults.Items.Add("Breakfast cost: $" + breakfastCost.ToString("N2"));
            lstResults.Items.Add("Service surcharge: $" + serviceSurcharge.ToString("N2"));
            lstResults.Items.Add("Final cost: $" + finalCost.ToString("N2"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;
            chkBreakfast.Checked = false;

            lstResults.Items.Clear();
            txtGuestName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGuests_Click(object sender, EventArgs e)
        {
        }
    }
}