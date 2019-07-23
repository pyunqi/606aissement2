namespace KiwiBike4Rent.RentalManagement
{
    partial class BikeRentalDashboard
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
            this.rbCustomerID = new System.Windows.Forms.RadioButton();
            this.rbDOB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCustomerDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRentBike = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCustomerID
            // 
            this.rbCustomerID.AutoSize = true;
            this.rbCustomerID.Location = new System.Drawing.Point(71, 19);
            this.rbCustomerID.Name = "rbCustomerID";
            this.rbCustomerID.Size = new System.Drawing.Size(91, 17);
            this.rbCustomerID.TabIndex = 0;
            this.rbCustomerID.Text = "byCustomerID";
            this.rbCustomerID.UseVisualStyleBackColor = true;
            this.rbCustomerID.CheckedChanged += new System.EventHandler(this.rbCustomerID_CheckedChanged);
            // 
            // rbDOB
            // 
            this.rbDOB.AutoSize = true;
            this.rbDOB.Location = new System.Drawing.Point(168, 19);
            this.rbDOB.Name = "rbDOB";
            this.rbDOB.Size = new System.Drawing.Size(59, 17);
            this.rbDOB.TabIndex = 0;
            this.rbDOB.Text = "byDOB";
            this.rbDOB.UseVisualStyleBackColor = true;
            this.rbDOB.CheckedChanged += new System.EventHandler(this.rbDOB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCustomerID);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbDOB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Searching Option";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(279, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(652, 333);
            this.dgvCustomers.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(74, 70);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of Birth";
            // 
            // dtpCustomerDOB
            // 
            this.dtpCustomerDOB.Enabled = false;
            this.dtpCustomerDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpCustomerDOB.Location = new System.Drawing.Point(73, 99);
            this.dtpCustomerDOB.Name = "dtpCustomerDOB";
            this.dtpCustomerDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpCustomerDOB.TabIndex = 5;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(18, 130);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 165);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRentBike
            // 
            this.btnRentBike.Location = new System.Drawing.Point(18, 234);
            this.btnRentBike.Name = "btnRentBike";
            this.btnRentBike.Size = new System.Drawing.Size(138, 29);
            this.btnRentBike.TabIndex = 6;
            this.btnRentBike.Text = "Rent Bike to Customer";
            this.btnRentBike.UseVisualStyleBackColor = true;
            this.btnRentBike.Click += new System.EventHandler(this.btnRentBike_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(18, 199);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.Location = new System.Drawing.Point(18, 269);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(138, 29);
            this.btnReturnBike.TabIndex = 6;
            this.btnReturnBike.Text = "Customer Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = true;
            this.btnReturnBike.Click += new System.EventHandler(this.btnReturnBike_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 30);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BikeRentalDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 357);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnRentBike);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.dtpCustomerDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.groupBox1);
            this.Name = "BikeRentalDashboard";
            this.Text = "BikeRentalDashboard";
            this.Load += new System.EventHandler(this.RentBikeDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCustomerID;
        private System.Windows.Forms.RadioButton rbDOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCustomerDOB;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRentBike;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnClose;
    }
}