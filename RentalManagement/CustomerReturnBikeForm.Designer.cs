namespace KiwiBike4Rent.RentalManagement
{
    partial class CustomerReturnBikeForm
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
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvShowRentals = new System.Windows.Forms.DataGridView();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtHiredDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxStatus = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHiredPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOverDueDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Enabled = false;
            this.txtCustomerInfo.Location = new System.Drawing.Point(72, 10);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(251, 20);
            this.txtCustomerInfo.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Customer: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvShowRentals
            // 
            this.dgvShowRentals.AllowUserToAddRows = false;
            this.dgvShowRentals.AllowUserToDeleteRows = false;
            this.dgvShowRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRentals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShowRentals.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dgvShowRentals.Location = new System.Drawing.Point(226, 49);
            this.dgvShowRentals.Name = "dgvShowRentals";
            this.dgvShowRentals.Size = new System.Drawing.Size(724, 245);
            this.dgvShowRentals.TabIndex = 41;
            this.dgvShowRentals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowRentals_CellDoubleClick);
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.Location = new System.Drawing.Point(15, 263);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(191, 31);
            this.btnReturnBike.TabIndex = 40;
            this.btnReturnBike.Text = "Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = true;
            this.btnReturnBike.Click += new System.EventHandler(this.btnReturnBike_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Enabled = false;
            this.txtDeposit.Location = new System.Drawing.Point(72, 46);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(125, 20);
            this.txtDeposit.TabIndex = 50;
            // 
            // txtHiredDays
            // 
            this.txtHiredDays.Enabled = false;
            this.txtHiredDays.Location = new System.Drawing.Point(93, 78);
            this.txtHiredDays.Name = "txtHiredDays";
            this.txtHiredDays.Size = new System.Drawing.Size(98, 20);
            this.txtHiredDays.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Deposit: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Hired Days:";
            // 
            // lboxStatus
            // 
            this.lboxStatus.FormattingEnabled = true;
            this.lboxStatus.Items.AddRange(new object[] {
            "available",
            "maintenance",
            "sold"});
            this.lboxStatus.Location = new System.Drawing.Point(91, 236);
            this.lboxStatus.Name = "lboxStatus";
            this.lboxStatus.Size = new System.Drawing.Size(100, 21);
            this.lboxStatus.TabIndex = 54;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(4, 236);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(87, 13);
            this.status.TabIndex = 55;
            this.status.Text = "Returned Status:";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Enabled = false;
            this.txtRentalPrice.Location = new System.Drawing.Point(93, 104);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(98, 20);
            this.txtRentalPrice.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Rental Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Hire Priced:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHiredPrice
            // 
            this.txtHiredPrice.Enabled = false;
            this.txtHiredPrice.Location = new System.Drawing.Point(93, 127);
            this.txtHiredPrice.Name = "txtHiredPrice";
            this.txtHiredPrice.Size = new System.Drawing.Size(98, 20);
            this.txtHiredPrice.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Over Due Days:";
            // 
            // txtOverDueDays
            // 
            this.txtOverDueDays.Enabled = false;
            this.txtOverDueDays.Location = new System.Drawing.Point(93, 153);
            this.txtOverDueDays.Name = "txtOverDueDays";
            this.txtOverDueDays.Size = new System.Drawing.Size(98, 20);
            this.txtOverDueDays.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Total Price:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(93, 210);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fine:";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFine
            // 
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(93, 179);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(98, 20);
            this.txtFine.TabIndex = 56;
            // 
            // CustomerReturnBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 358);
            this.Controls.Add(this.txtOverDueDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHiredPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtHiredDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvShowRentals);
            this.Controls.Add(this.btnReturnBike);
            this.Name = "CustomerReturnBikeForm";
            this.Text = "ReturnBikeToCustomerForm";
            this.Load += new System.EventHandler(this.ReturnBikeToCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvShowRentals;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtHiredDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lboxStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHiredPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOverDueDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFine;
    }
}