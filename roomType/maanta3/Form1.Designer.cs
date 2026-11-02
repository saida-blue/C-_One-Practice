namespace maanta3
{
    partial class Form1
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpRoomType.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(11, 64);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(101, 20);
            this.lblGuestName.TabIndex = 31;
            this.lblGuestName.Text = "Guest name:";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Location = new System.Drawing.Point(6, 114);
            this.lblGuestAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(88, 20);
            this.lblGuestAge.TabIndex = 32;
            this.lblGuestAge.Text = "Guest age:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(0, 168);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(134, 20);
            this.lblNights.TabIndex = 33;
            this.lblNights.Text = "Number of nights:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(0, 221);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(139, 20);
            this.lblGuests.TabIndex = 34;
            this.lblGuests.Text = "Number of guests:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(154, 61);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(269, 26);
            this.txtGuestName.TabIndex = 35;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(154, 114);
            this.txtGuestAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(269, 26);
            this.txtGuestAge.TabIndex = 36;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(154, 221);
            this.txtGuests.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(269, 26);
            this.txtGuests.TabIndex = 38;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(71, 47);
            this.rdoStandard.Margin = new System.Windows.Forms.Padding(4);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(100, 24);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.Text = "Standard";
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(264, 47);
            this.rdoNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(84, 24);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.Text = "Normal";
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rdoStandard);
            this.grpRoomType.Controls.Add(this.rdoNormal);
            this.grpRoomType.Controls.Add(this.rdoHight);
            this.grpRoomType.Location = new System.Drawing.Point(4, 294);
            this.grpRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Padding = new System.Windows.Forms.Padding(4);
            this.grpRoomType.Size = new System.Drawing.Size(669, 107);
            this.grpRoomType.TabIndex = 30;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room type";
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Location = new System.Drawing.Point(450, 47);
            this.rdoHight.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(72, 24);
            this.rdoHight.TabIndex = 2;
            this.rdoHight.Text = "Hight";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkBreakfast);
            this.grpOptions.Location = new System.Drawing.Point(4, 431);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpOptions.Size = new System.Drawing.Size(540, 100);
            this.grpOptions.TabIndex = 29;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Additional options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(26, 43);
            this.chkBreakfast.Margin = new System.Windows.Forms.Padding(4);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(282, 24);
            this.chkBreakfast.TabIndex = 0;
            this.chkBreakfast.Text = "Breakfast ($10 per guest per night)";
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(154, 168);
            this.txtNights.Margin = new System.Windows.Forms.Padding(4);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(269, 26);
            this.txtNights.TabIndex = 37;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(26, 36);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 43);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnCalculate);
            this.grpActions.Controls.Add(this.btnClear);
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Location = new System.Drawing.Point(4, 548);
            this.grpActions.Margin = new System.Windows.Forms.Padding(4);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(4);
            this.grpActions.Size = new System.Drawing.Size(540, 100);
            this.grpActions.TabIndex = 28;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 36);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(373, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(681, 65);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(110, 20);
            this.lblResults.TabIndex = 26;
            this.lblResults.Text = "Booking result";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(681, 98);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(392, 524);
            this.lstResults.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 708);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblGuestAge);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lstResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lstResults;
    }
}

