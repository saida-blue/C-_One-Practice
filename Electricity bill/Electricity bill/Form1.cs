using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_bill
{
    public partial class lbltaxamount : Form
    {
        public lbltaxamount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblcustomername_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbltax_Click(object sender, EventArgs e)
        {

        }

        private void bttncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get customer name
                string customerName = txtcustomer.Text;

                // Get previous reading, current reading and unit price
                double previousReading = double.Parse(txtprevious.Text);
                double currentReading = double.Parse(txtcurrent.Text);
                double unitPrice = double.Parse(txtunitprice.Text);

                // Calculate electricity usage
                double usage = currentReading - previousReading;

                // Calculate electricity cost
                double electricityCost = usage * unitPrice;

                // Calculate 7% tax
                double tax = electricityCost * 0.07;

                // Fixed charge
                double fixedCharge = 5.00;

                // Calculate total bill
                double totalBill = electricityCost + tax + fixedCharge;

                // Display results
                txtunits.Text = usage.ToString();
                txttax.Text = "$" + tax.ToString("0.00");
                txttotalbill.Text = "$" + totalBill.ToString("0.00");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(
                    "Please enter valid numbers.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}