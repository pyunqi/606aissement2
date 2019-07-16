namespace KiwiBike4Rent.RentalManagement
{
    partial class RentBikeToCustomerForm
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
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.dgvShowBikes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.boxBrand = new System.Windows.Forms.ComboBox();
            this.boxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCategory = new System.Windows.Forms.ComboBox();
            this.btnRentBike = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(131, 164);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(61, 20);
            this.txtRentalPrice.TabIndex = 20;
            // 
            // dgvShowBikes
            // 
            this.dgvShowBikes.AllowUserToAddRows = false;
            this.dgvShowBikes.AllowUserToDeleteRows = false;
            this.dgvShowBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBikes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShowBikes.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dgvShowBikes.Location = new System.Drawing.Point(218, 51);
            this.dgvShowBikes.Name = "dgvShowBikes";
            this.dgvShowBikes.Size = new System.Drawing.Size(637, 245);
            this.dgvShowBikes.TabIndex = 25;
            this.dgvShowBikes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddDeposit_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rental Price Less Than:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Model:";
            // 
            // boxStatus
            // 
            this.boxStatus.Enabled = false;
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Location = new System.Drawing.Point(67, 130);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(121, 21);
            this.boxStatus.TabIndex = 19;
            // 
            // boxBrand
            // 
            this.boxBrand.FormattingEnabled = true;
            this.boxBrand.Location = new System.Drawing.Point(67, 103);
            this.boxBrand.Name = "boxBrand";
            this.boxBrand.Size = new System.Drawing.Size(121, 21);
            this.boxBrand.TabIndex = 18;
            // 
            // boxModel
            // 
            this.boxModel.FormattingEnabled = true;
            this.boxModel.Location = new System.Drawing.Point(67, 76);
            this.boxModel.Name = "boxModel";
            this.boxModel.Size = new System.Drawing.Size(121, 21);
            this.boxModel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Category:";
            // 
            // boxCategory
            // 
            this.boxCategory.FormattingEnabled = true;
            this.boxCategory.Location = new System.Drawing.Point(67, 48);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(121, 21);
            this.boxCategory.TabIndex = 16;
            // 
            // btnRentBike
            // 
            this.btnRentBike.Location = new System.Drawing.Point(12, 271);
            this.btnRentBike.Name = "btnRentBike";
            this.btnRentBike.Size = new System.Drawing.Size(180, 28);
            this.btnRentBike.TabIndex = 22;
            this.btnRentBike.Text = "Rent Bike";
            this.btnRentBike.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 237);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search Bikes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customer: ";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Enabled = false;
            this.txtCustomerInfo.Location = new System.Drawing.Point(67, 12);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(251, 20);
            this.txtCustomerInfo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Deposit: ";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(67, 211);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(125, 20);
            this.txtDeposit.TabIndex = 20;
            // 
            // RentBikeToCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 360);
            this.Controls.Add(this.txtCustomerInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvShowBikes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxBrand);
            this.Controls.Add(this.boxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCategory);
            this.Controls.Add(this.btnRentBike);
            this.Controls.Add(this.btnSearch);
            this.Name = "RentBikeToCustomerForm";
            this.Text = "RentBikeToCustomerForm";
            this.Load += new System.EventHandler(this.RentBikeToCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.DataGridView dgvShowBikes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.ComboBox boxBrand;
        private System.Windows.Forms.ComboBox boxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxCategory;
        private System.Windows.Forms.Button btnRentBike;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeposit;
    }
}