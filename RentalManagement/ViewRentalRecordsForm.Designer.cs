namespace KiwiBike4Rent.RentalManagement
{
    partial class ViewRentalRecordsForm
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
            this.btnSearchRentedBikes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnShowOverDueBikes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRentedBikes
            // 
            this.btnSearchRentedBikes.Location = new System.Drawing.Point(22, 136);
            this.btnSearchRentedBikes.Name = "btnSearchRentedBikes";
            this.btnSearchRentedBikes.Size = new System.Drawing.Size(138, 29);
            this.btnSearchRentedBikes.TabIndex = 17;
            this.btnSearchRentedBikes.Text = "SearchRentedBikes";
            this.btnSearchRentedBikes.UseVisualStyleBackColor = true;
            this.btnSearchRentedBikes.Click += new System.EventHandler(this.btnSearchRentals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(87, 85);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 9;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(203, 12);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.Size = new System.Drawing.Size(623, 317);
            this.dgvRentals.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(22, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 30);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnShowOverDueBikes
            // 
            this.BtnShowOverDueBikes.Location = new System.Drawing.Point(22, 182);
            this.BtnShowOverDueBikes.Name = "BtnShowOverDueBikes";
            this.BtnShowOverDueBikes.Size = new System.Drawing.Size(138, 29);
            this.BtnShowOverDueBikes.TabIndex = 17;
            this.BtnShowOverDueBikes.Text = "ShowOverDueBikes";
            this.BtnShowOverDueBikes.UseVisualStyleBackColor = true;
            this.BtnShowOverDueBikes.Click += new System.EventHandler(this.BtnShowOverDueBikes_Click);
            // 
            // ViewRentalRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 347);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnShowOverDueBikes);
            this.Controls.Add(this.btnSearchRentedBikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dgvRentals);
            this.Name = "ViewRentalRecordsForm";
            this.Text = "ViewRentalRecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRentedBikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnShowOverDueBikes;
    }
}