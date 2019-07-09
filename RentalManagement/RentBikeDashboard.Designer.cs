namespace KiwiBike4Rent.RentalManagement
{
    partial class RentBikeDashboard
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCustomerDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRentBike = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCustomerID
            // 
            this.rbCustomerID.AutoSize = true;
            this.rbCustomerID.Location = new System.Drawing.Point(6, 19);
            this.rbCustomerID.Name = "rbCustomerID";
            this.rbCustomerID.Size = new System.Drawing.Size(91, 17);
            this.rbCustomerID.TabIndex = 0;
            this.rbCustomerID.TabStop = true;
            this.rbCustomerID.Text = "byCustomerID";
            this.rbCustomerID.UseVisualStyleBackColor = true;
            // 
            // rbDOB
            // 
            this.rbDOB.AutoSize = true;
            this.rbDOB.Location = new System.Drawing.Point(103, 19);
            this.rbDOB.Name = "rbDOB";
            this.rbDOB.Size = new System.Drawing.Size(59, 17);
            this.rbDOB.TabIndex = 0;
            this.rbDOB.TabStop = true;
            this.rbDOB.Text = "byDOB";
            this.rbDOB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCustomerID);
            this.groupBox1.Controls.Add(this.rbDOB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(279, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(500, 332);
            this.dgvCustomers.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
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
            this.dtpCustomerDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpCustomerDOB.Location = new System.Drawing.Point(73, 99);
            this.dtpCustomerDOB.Name = "dtpCustomerDOB";
            this.dtpCustomerDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpCustomerDOB.TabIndex = 5;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(18, 154);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 189);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRentBike
            // 
            this.btnRentBike.Location = new System.Drawing.Point(18, 258);
            this.btnRentBike.Name = "btnRentBike";
            this.btnRentBike.Size = new System.Drawing.Size(138, 29);
            this.btnRentBike.TabIndex = 6;
            this.btnRentBike.Text = "Rent Bike to Customer";
            this.btnRentBike.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(18, 223);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(138, 29);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.Location = new System.Drawing.Point(18, 293);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(138, 29);
            this.btnReturnBike.TabIndex = 6;
            this.btnReturnBike.Text = "Customer Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = true;
            // 
            // RentBikeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 357);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnRentBike);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.dtpCustomerDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentBikeDashboard";
            this.Text = "RentBikeDashboard";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCustomerDOB;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRentBike;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnReturnBike;
    }
}