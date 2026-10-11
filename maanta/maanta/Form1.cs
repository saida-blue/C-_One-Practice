using System;
using System.Windows.Forms;

namespace maanta
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
            lstResults.Items.Clear();

            string guestName = txtGuestName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Guest name is required. or you must entered: (blank)");
                txtGuestName.Focus();
                return;
            }

            int age;
            if (!int.TryParse(txtGuestAge.Text, out age))
            {
                MessageBox.Show(
                    "Guest age must be a whole number. or you  must entered: " +
                    txtGuestAge.Text);
                txtGuestAge.Focus();
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show(
                    "Guest age must be between 18 and 90. or You must entered: " +
                    age);
                txtGuestAge.Focus();
                return;
            }

            int nights;
            if (!int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show(
                    "Number of nights must be a whole number. or you must entered: " +
                    txtNights.Text);
                txtNights.Focus();
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show(
                    "Number of nights must be between 1 and 30. or you must entered: " +
                    nights);
                txtNights.Focus();
                return;
            }

            int guests;
            if (!int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show(
                    "Number of guests must be a whole number. or you must entered : " +
                    txtGuests.Text);
                txtGuests.Focus();
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show(
                    "Number of guests must be between 1 and 6. You entered: " +
                    guests);
                txtGuests.Focus();
                return;
            }

            if (!rdoStandard.Checked &&
                !rdoNormal.Checked &&
                !rdoHight.Checked)
            {
                MessageBox.Show(
                    "Please select a room type. No room type was selected.");
                return;
            }

            string roomType;
            decimal rate;
            int capacity;

            // A switch statement selects the room rate and capacity.
            if (rdoStandard.Checked)
            {
                roomType = "Standard";
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
            }
            else
            {
                roomType = "High";
            }

            switch (roomType)
            {
                case "Standard":
                    rate = 50m;
                    capacity = 2;
                    break;

                case "Normal":
                    rate = 80m;
                    capacity = 4;
                    break;

                case "High":
                    rate = 130m;
                    capacity = 6;
                    break;

                default:
                    MessageBox.Show("The selected room type is not valid.");
                    return;
            }

            lstResults.Items.Add("Booking: " +
                (guests <= capacity ? "APPROVED" : "REJECTED"));
            lstResults.Items.Add("Guest: " + guestName);
            lstResults.Items.Add("Age entered: " + age);
            lstResults.Items.Add("Room selected: " + roomType);
            lstResults.Items.Add("Guests entered: " + guests);
            lstResults.Items.Add("Nights entered: " + nights);
            lstResults.Items.Add("Room capacity: " + capacity);

            if (guests > capacity)
            {
                lstResults.Items.Add(
                    "Reason: This room cannot accommodate " +
                    guests + " guests.");

                MessageBox.Show(
                    "Booking rejected. You entered " + guests +
                    " guests, but a " + roomType + " room can accommodate " +
                    "a maximum of " + capacity + ".");
                return;
            }

            decimal roomCost = rate * nights;
            decimal breakfastCost = chkBreakfast.Checked
                ? 10m * guests * nights
                : 0m;

            decimal subtotal = roomCost + breakfastCost;

            decimal surcharge = 0m;
            if (guests > 4)
            {
                surcharge = subtotal * 0.05m;
            }

            decimal totalBeforeDiscounts = subtotal + surcharge;

            decimal nightDiscountRate = 0m;
            if (nights >= 10)
            {
                nightDiscountRate = 0.12m;
            }
            else if (nights >= 5)
            {
                nightDiscountRate = 0.05m;
            }

            decimal nightDiscount =
                totalBeforeDiscounts * nightDiscountRate;

            decimal totalAfterNightDiscount =
                totalBeforeDiscounts - nightDiscount;

            decimal seniorDiscount = 0m;
            if (age >= 60)
            {
                seniorDiscount = totalAfterNightDiscount * 0.05m;
            }

            decimal total = totalAfterNightDiscount - seniorDiscount;

            lstResults.Items.Add("Room cost: $" + roomCost.ToString("0.00"));
            lstResults.Items.Add(
                "Breakfast selected: " +
                (chkBreakfast.Checked ? "Yes" : "No"));
            lstResults.Items.Add(
                "Breakfast cost: $" + breakfastCost.ToString("0.00"));
            lstResults.Items.Add(
                "Group surcharge: $" + surcharge.ToString("0.00"));
            lstResults.Items.Add(
                "Night discount: $" + nightDiscount.ToString("0.00"));
            lstResults.Items.Add(
                "Senior discount: $" + seniorDiscount.ToString("0.00"));
            lstResults.Items.Add("TOTAL: $" + total.ToString("0.00"));
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

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
        }

        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}