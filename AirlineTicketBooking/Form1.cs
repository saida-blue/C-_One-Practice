using System;
using System.Windows.Forms;

namespace AirlineTicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age, tickets;
            double baggageWeight;

            // Read and check the numeric values.
            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtTickets.Text, out tickets) ||
                !double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter valid values.");
                return;
            }

            if (txtPassengerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (age < 1 || age > 100 || tickets < 1 || tickets > 5 ||
                baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Please check age, tickets, and baggage weight.");
                return;
            }

            if (!rdoFirstClass.Checked && !rdoNormalClass.Checked && !rdoBusinessClass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            if (rdoFirstClass.Checked && age < 12)
            {
                MessageBox.Show("First Class is not available for children under 12.");
                return;
            }

            double ticketPrice = 300;

            if (rdoFirstClass.Checked)
                ticketPrice = 500;
            else if (rdoNormalClass.Checked)
                ticketPrice = 300;
            else if (rdoBusinessClass.Checked)
                ticketPrice = 800;

            double total = ticketPrice * tickets;

            if (tickets >= 5)
                total -= total * 0.10;
            else if (tickets >= 3)
                total -= total * 0.05;

            if (age < 12)
                total -= total * 0.20;
            else if (age >= 60)
                total -= total * 0.10;

            if (chkTravelInsurance.Checked)
                total += 25 * tickets;

            string travelClass = rdoFirstClass.Checked ? "First Class" :
                                 rdoNormalClass.Checked ? "Normal Class" : "Business Class";

            string bookingApproved = "true";

            // Show each booking detail on a new line.
            txtBookingDetails.Text =
                "AIRLINE BOOKING DETAILS" + Environment.NewLine +
                "Passenger Name: " + txtPassengerName.Text + Environment.NewLine +
                "Passenger Age: " + age + Environment.NewLine +
                "Number of Tickets: " + tickets + Environment.NewLine +
                "Baggage Weight: " + baggageWeight + " kg" + Environment.NewLine +
                "Travel Class: " + travelClass + Environment.NewLine +
                "Travel Insurance: " + (chkTravelInsurance.Checked ? "Yes" : "No") + Environment.NewLine +
                "Total Price: $" + total.ToString("0.00") + Environment.NewLine +
                "Booking Approved: " + bookingApproved;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggageWeight.Clear();
            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;
            chkTravelInsurance.Checked = false;
            txtBookingDetails.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
