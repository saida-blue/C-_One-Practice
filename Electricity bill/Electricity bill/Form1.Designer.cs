namespace Electricity_bill
{
    partial class lbltaxamount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.lblpriceperunit = new System.Windows.Forms.Label();
            this.lblcurrentreading = new System.Windows.Forms.Label();
            this.lblpreviousreading = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblunits = new System.Windows.Forms.Label();
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.txtunits = new System.Windows.Forms.TextBox();
            this.txttotalbill = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.bttncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(690, 9);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(289, 26);
            this.txtcustomer.TabIndex = 0;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(690, 181);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(289, 26);
            this.txtunitprice.TabIndex = 1;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(690, 120);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(289, 26);
            this.txtcurrent.TabIndex = 2;
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(690, 70);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(289, 26);
            this.txtprevious.TabIndex = 3;
            // 
            // lblcustomername
            // 
            this.lblcustomername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(224, 12);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(255, 34);
            this.lblcustomername.TabIndex = 4;
            this.lblcustomername.Text = "Enter customer name: ";
            this.lblcustomername.Click += new System.EventHandler(this.lblcustomername_Click);
            // 
            // lblpriceperunit
            // 
            this.lblpriceperunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpriceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceperunit.Location = new System.Drawing.Point(224, 165);
            this.lblpriceperunit.Name = "lblpriceperunit";
            this.lblpriceperunit.Size = new System.Drawing.Size(255, 42);
            this.lblpriceperunit.TabIndex = 5;
            this.lblpriceperunit.Text = "Enter price per unit: ";
            // 
            // lblcurrentreading
            // 
            this.lblcurrentreading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcurrentreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentreading.Location = new System.Drawing.Point(224, 115);
            this.lblcurrentreading.Name = "lblcurrentreading";
            this.lblcurrentreading.Size = new System.Drawing.Size(255, 31);
            this.lblcurrentreading.TabIndex = 6;
            this.lblcurrentreading.Text = "Enter current reading: ";
            // 
            // lblpreviousreading
            // 
            this.lblpreviousreading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpreviousreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreviousreading.Location = new System.Drawing.Point(224, 60);
            this.lblpreviousreading.Name = "lblpreviousreading";
            this.lblpreviousreading.Size = new System.Drawing.Size(255, 36);
            this.lblpreviousreading.TabIndex = 7;
            this.lblpreviousreading.Text = "Enter previous name: ";
            this.lblpreviousreading.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbltax
            // 
            this.lbltax.Location = new System.Drawing.Point(220, 369);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(235, 38);
            this.lbltax.TabIndex = 8;
            this.lbltax.Text = "Tax amount(7%)";
            this.lbltax.Click += new System.EventHandler(this.lbltax_Click);
            // 
            // lblunits
            // 
            this.lblunits.Location = new System.Drawing.Point(220, 316);
            this.lblunits.Name = "lblunits";
            this.lblunits.Size = new System.Drawing.Size(235, 39);
            this.lblunits.TabIndex = 9;
            this.lblunits.Text = "Ellectricity usage (units): ";
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.Location = new System.Drawing.Point(220, 419);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(268, 35);
            this.lbltotalbill.TabIndex = 10;
            this.lbltotalbill.Text = "total bill(including $5 fixed charge)";
            // 
            // txtunits
            // 
            this.txtunits.Location = new System.Drawing.Point(726, 313);
            this.txtunits.Name = "txtunits";
            this.txtunits.Size = new System.Drawing.Size(100, 26);
            this.txtunits.TabIndex = 11;
            // 
            // txttotalbill
            // 
            this.txttotalbill.Location = new System.Drawing.Point(726, 416);
            this.txttotalbill.Name = "txttotalbill";
            this.txttotalbill.Size = new System.Drawing.Size(100, 26);
            this.txttotalbill.TabIndex = 12;
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(726, 366);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(100, 26);
            this.txttax.TabIndex = 13;
            // 
            // bttncalculate
            // 
            this.bttncalculate.Location = new System.Drawing.Point(477, 241);
            this.bttncalculate.Name = "bttncalculate";
            this.bttncalculate.Size = new System.Drawing.Size(210, 53);
            this.bttncalculate.TabIndex = 14;
            this.bttncalculate.Text = "calculate button";
            this.bttncalculate.UseVisualStyleBackColor = true;
            this.bttncalculate.Click += new System.EventHandler(this.bttncalculate_Click);
            // 
            // lbltaxamount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 519);
            this.Controls.Add(this.bttncalculate);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.txttotalbill);
            this.Controls.Add(this.txtunits);
            this.Controls.Add(this.lbltotalbill);
            this.Controls.Add(this.lblunits);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblpreviousreading);
            this.Controls.Add(this.lblcurrentreading);
            this.Controls.Add(this.lblpriceperunit);
            this.Controls.Add(this.lblcustomername);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcustomer);
            this.Name = "lbltaxamount";
            this.Text = "Enter customer name: ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.Label lblpriceperunit;
        private System.Windows.Forms.Label lblcurrentreading;
        private System.Windows.Forms.Label lblpreviousreading;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblunits;
        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.TextBox txtunits;
        private System.Windows.Forms.TextBox txttotalbill;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Button bttncalculate;
    }
}

