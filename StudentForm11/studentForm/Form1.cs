using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentForm
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating varibles and assigning

            string name, department, semester;
            name = txtname.Text;
            department = txtdepartment.Text;
            semester = txtsemester.Text;
            int studentid = int.Parse(txtstudentid.Text)
                //concatenating

            lbloutput.Text = name + ", " + department + ", " + semester + ", " + studentid;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text 

            txtname.Text = "";
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Text = string.Empty;
            lbloutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        { 
            //Closing form
            Close();
        }
    }
}
