using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diiscount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


        
            int Packets;
            decimal price;
            
            if (!int.TryParse(txtnumber.Text, out Packets) || Packets <= 0 ||
                !decimal.TryParse(txtprice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter valid values.");
                return;
            }

            decimal discountRate = 0m;
            if (Packets >= 100)
                discountRate = 0.50m;
            else if (Packets >= 50)
                discountRate = 0.40m;
            else if (Packets >= 20)
                discountRate = 0.30m;
            else if (Packets >= 10)
                discountRate = 0.20m;

            decimal subTotal = Packets * price;
            decimal discountAmount = subTotal * discountRate;
            decimal totalAmount = subTotal - discountAmount;

            lstResults.Items.Clear();
            lstResults.Items.Add("packets " + Packets);
            lstResults.Items.Add("Price " + price.ToString("C2"));
            lstResults.Items.Add("Sub totl: " + subTotal.ToString("C2"));
            lstResults.Items.Add("Disc rate: " + (discountRate * 100).ToString("0") + "%");
            lstResults.Items.Add("Disc amount: " + discountAmount.ToString("C2"));
            lstResults.Items.Add("Total: " + totalAmount.ToString("C2"));
        }


       

       
        private void btnClear_Click_1(object sender, EventArgs e)
        {

            lstResults.Items.Clear();
            txtnumber.Clear();
            txtprice.Clear();
            lstResults.Items.Clear();
            txtnumber.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

