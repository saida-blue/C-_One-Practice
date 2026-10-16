namespace AirlineTicketBooking
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblBaggageWeight;
        private System.Windows.Forms.Label lblTravelClass;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.GroupBox grpTravelClass;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.TextBox txtBookingDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblBaggageWeight = new System.Windows.Forms.Label();
            this.lblTravelClass = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.grpTravelClass = new System.Windows.Forms.GroupBox();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.txtBookingDetails = new System.Windows.Forms.TextBox();
            this.grpTravelClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Airline Ticket Booking";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(26, 66);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(87, 13);
            this.lblPassengerName.TabIndex = 1;
            this.lblPassengerName.Text = "Passenger Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(26, 108);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(26, 150);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(90, 13);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "Number of Tickets";
            // 
            // lblBaggageWeight
            // 
            this.lblBaggageWeight.AutoSize = true;
            this.lblBaggageWeight.Location = new System.Drawing.Point(26, 192);
            this.lblBaggageWeight.Name = "lblBaggageWeight";
            this.lblBaggageWeight.Size = new System.Drawing.Size(88, 13);
            this.lblBaggageWeight.TabIndex = 4;
            this.lblBaggageWeight.Text = "Baggage Weight (kg)";
            // 
            // lblTravelClass
            // 
            this.lblTravelClass.AutoSize = true;
            this.lblTravelClass.Location = new System.Drawing.Point(26, 235);
            this.lblTravelClass.Name = "lblTravelClass";
            this.lblTravelClass.Size = new System.Drawing.Size(64, 13);
            this.lblTravelClass.TabIndex = 5;
            this.lblTravelClass.Text = "Travel Class";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(150, 63);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(220, 20);
            this.txtPassengerName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 105);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(220, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(150, 147);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(220, 20);
            this.txtTickets.TabIndex = 8;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(150, 189);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(220, 20);
            this.txtBaggageWeight.TabIndex = 9;
            // 
            // grpTravelClass
            // 
            this.grpTravelClass.Controls.Add(this.rdoFirstClass);
            this.grpTravelClass.Controls.Add(this.rdoNormalClass);
            this.grpTravelClass.Controls.Add(this.rdoBusinessClass);
            this.grpTravelClass.Location = new System.Drawing.Point(150, 220);
            this.grpTravelClass.Name = "grpTravelClass";
            this.grpTravelClass.Size = new System.Drawing.Size(220, 85);
            this.grpTravelClass.TabIndex = 10;
            this.grpTravelClass.TabStop = false;
            this.grpTravelClass.Text = "Select Class";
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Location = new System.Drawing.Point(10, 17);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(73, 17);
            this.rdoFirstClass.TabIndex = 0;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "First Class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Location = new System.Drawing.Point(10, 38);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(85, 17);
            this.rdoNormalClass.TabIndex = 1;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Location = new System.Drawing.Point(10, 59);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(91, 17);
            this.rdoBusinessClass.TabIndex = 2;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(150, 316);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(101, 17);
            this.chkTravelInsurance.TabIndex = 11;
            this.chkTravelInsurance.Text = "Add Travel Insurance";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 355);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 30);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Location = new System.Drawing.Point(408, 63);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(82, 13);
            this.lblBookingDetails.TabIndex = 15;
            this.lblBookingDetails.Text = "Booking Details";
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.Location = new System.Drawing.Point(411, 84);
            this.txtBookingDetails.Multiline = true;
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.ReadOnly = true;
            this.txtBookingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookingDetails.Size = new System.Drawing.Size(290, 301);
            this.txtBookingDetails.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 420);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.lblBookingDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkTravelInsurance);
            this.Controls.Add(this.grpTravelClass);
            this.Controls.Add(this.lblTravelClass);
            this.Controls.Add(this.txtBaggageWeight);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lblBaggageWeight);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Ticket Booking";
            this.grpTravelClass.ResumeLayout(false);
            this.grpTravelClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
