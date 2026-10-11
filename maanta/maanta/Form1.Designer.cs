namespace maanta
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
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.grpActions.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(688, 56);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(110, 20);
            this.lblResults.TabIndex = 13;
            this.lblResults.Text = "Booking result";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 36);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(373, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnCalculate);
            this.grpActions.Controls.Add(this.btnClear);
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Location = new System.Drawing.Point(11, 539);
            this.grpActions.Margin = new System.Windows.Forms.Padding(4);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(4);
            this.grpActions.Size = new System.Drawing.Size(540, 100);
            this.grpActions.TabIndex = 15;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
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
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkBreakfast);
            this.grpOptions.Location = new System.Drawing.Point(11, 422);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpOptions.Size = new System.Drawing.Size(540, 100);
            this.grpOptions.TabIndex = 16;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Additional options";
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
            this.rdoStandard.CheckedChanged += new System.EventHandler(this.rdoStandard_CheckedChanged);
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
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(688, 89);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(392, 524);
            this.lstResults.TabIndex = 14;
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rdoStandard);
            this.grpRoomType.Controls.Add(this.rdoNormal);
            this.grpRoomType.Controls.Add(this.rdoHight);
            this.grpRoomType.Location = new System.Drawing.Point(11, 285);
            this.grpRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Padding = new System.Windows.Forms.Padding(4);
            this.grpRoomType.Size = new System.Drawing.Size(669, 107);
            this.grpRoomType.TabIndex = 17;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room type";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(18, 55);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(101, 20);
            this.lblGuestName.TabIndex = 18;
            this.lblGuestName.Text = "Guest name:";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Location = new System.Drawing.Point(13, 105);
            this.lblGuestAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(88, 20);
            this.lblGuestAge.TabIndex = 19;
            this.lblGuestAge.Text = "Guest age:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(7, 159);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(134, 20);
            this.lblNights.TabIndex = 20;
            this.lblNights.Text = "Number of nights:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(7, 212);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(139, 20);
            this.lblGuests.TabIndex = 21;
            this.lblGuests.Text = "Number of guests:";
            this.lblGuests.Click += new System.EventHandler(this.lblGuests_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(161, 52);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(269, 26);
            this.txtGuestName.TabIndex = 22;
            this.txtGuestName.Text = "saida";
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(161, 105);
            this.txtGuestAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(269, 26);
            this.txtGuestAge.TabIndex = 23;
            this.txtGuestAge.Text = "99";
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(161, 159);
            this.txtNights.Margin = new System.Windows.Forms.Padding(4);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(269, 26);
            this.txtNights.TabIndex = 24;
            this.txtNights.Text = "777";
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(161, 212);
            this.txtGuests.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(269, 26);
            this.txtGuests.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 694);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblGuestAge);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtGuests);
            this.Name = "Form1";
            this.Text = "25";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpActions.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuests;
    }
}

