namespace KiwiBike4Rent.RentalManagement
{
    partial class ManageRentalRecords
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllOverdueBikes = new System.Windows.Forms.Button();
            this.btnAllRentedBikes = new System.Windows.Forms.Button();
            this.dgvBikeRentals = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLeast = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 30);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllOverdueBikes
            // 
            this.btnAllOverdueBikes.Location = new System.Drawing.Point(12, 115);
            this.btnAllOverdueBikes.Name = "btnAllOverdueBikes";
            this.btnAllOverdueBikes.Size = new System.Drawing.Size(172, 36);
            this.btnAllOverdueBikes.TabIndex = 52;
            this.btnAllOverdueBikes.Text = "View all overdue rented bikes";
            this.btnAllOverdueBikes.UseVisualStyleBackColor = true;
            this.btnAllOverdueBikes.Click += new System.EventHandler(this.btnAllOverdueBikes_Click);
            // 
            // btnAllRentedBikes
            // 
            this.btnAllRentedBikes.Location = new System.Drawing.Point(12, 75);
            this.btnAllRentedBikes.Name = "btnAllRentedBikes";
            this.btnAllRentedBikes.Size = new System.Drawing.Size(172, 34);
            this.btnAllRentedBikes.TabIndex = 53;
            this.btnAllRentedBikes.Text = "View all rented bikes";
            this.btnAllRentedBikes.UseVisualStyleBackColor = true;
            this.btnAllRentedBikes.Click += new System.EventHandler(this.btnAllRentedBikes_Click);
            // 
            // dgvBikeRentals
            // 
            this.dgvBikeRentals.AllowUserToAddRows = false;
            this.dgvBikeRentals.AllowUserToDeleteRows = false;
            this.dgvBikeRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBikeRentals.Location = new System.Drawing.Point(209, 12);
            this.dgvBikeRentals.Name = "dgvBikeRentals";
            this.dgvBikeRentals.ReadOnly = true;
            this.dgvBikeRentals.Size = new System.Drawing.Size(703, 322);
            this.dgvBikeRentals.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEnd);
            this.groupBox1.Controls.Add(this.rbStart);
            this.groupBox1.Controls.Add(this.rbReturn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 46);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Time By:";
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(59, 19);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(44, 17);
            this.rbEnd.TabIndex = 0;
            this.rbEnd.Text = "End";
            this.rbEnd.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Checked = true;
            this.rbStart.Location = new System.Drawing.Point(6, 19);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(47, 17);
            this.rbStart.TabIndex = 0;
            this.rbStart.TabStop = true;
            this.rbStart.Text = "Start";
            this.rbStart.UseVisualStyleBackColor = true;
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Location = new System.Drawing.Point(121, 19);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(57, 17);
            this.rbReturn.TabIndex = 0;
            this.rbReturn.Text = "Return";
            this.rbReturn.UseVisualStyleBackColor = true;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(12, 194);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(172, 34);
            this.btnTop.TabIndex = 56;
            this.btnTop.Text = "View Top 5 Rented Bikes";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLeast
            // 
            this.btnLeast.Location = new System.Drawing.Point(12, 234);
            this.btnLeast.Name = "btnLeast";
            this.btnLeast.Size = new System.Drawing.Size(172, 34);
            this.btnLeast.TabIndex = 56;
            this.btnLeast.Text = "View Least 5 Rented Bikes";
            this.btnLeast.UseVisualStyleBackColor = true;
            this.btnLeast.Click += new System.EventHandler(this.btnLeast_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 300);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(172, 34);
            this.btnGenerateReport.TabIndex = 56;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 459);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnLeast);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAllOverdueBikes);
            this.Controls.Add(this.btnAllRentedBikes);
            this.Controls.Add(this.dgvBikeRentals);
            this.Name = "ManageRentalRecords";
            this.Text = "ManageRentalRecords";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeRentals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllOverdueBikes;
        private System.Windows.Forms.Button btnAllRentedBikes;
        private System.Windows.Forms.DataGridView dgvBikeRentals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLeast;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}