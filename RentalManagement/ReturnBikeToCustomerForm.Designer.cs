namespace KiwiBike4Rent.RentalManagement
{
    partial class ReturnBikeToCustomerForm
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
            this.dgvShowBikes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.boxBrand = new System.Windows.Forms.ComboBox();
            this.boxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCategory = new System.Windows.Forms.ComboBox();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDeposite = new System.Windows.Forms.TextBox();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBikes)).BeginInit();
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
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Customer: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvShowBikes
            // 
            this.dgvShowBikes.AllowUserToAddRows = false;
            this.dgvShowBikes.AllowUserToDeleteRows = false;
            this.dgvShowBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBikes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShowBikes.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dgvShowBikes.Location = new System.Drawing.Point(238, 49);
            this.dgvShowBikes.Name = "dgvShowBikes";
            this.dgvShowBikes.Size = new System.Drawing.Size(640, 245);
            this.dgvShowBikes.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Model:";
            // 
            // boxStatus
            // 
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Items.AddRange(new object[] {
            "available",
            "rented",
            "sold",
            "maintenance"});
            this.boxStatus.Location = new System.Drawing.Point(72, 128);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(121, 21);
            this.boxStatus.TabIndex = 37;
            // 
            // boxBrand
            // 
            this.boxBrand.FormattingEnabled = true;
            this.boxBrand.Location = new System.Drawing.Point(72, 101);
            this.boxBrand.Name = "boxBrand";
            this.boxBrand.Size = new System.Drawing.Size(121, 21);
            this.boxBrand.TabIndex = 36;
            // 
            // boxModel
            // 
            this.boxModel.FormattingEnabled = true;
            this.boxModel.Location = new System.Drawing.Point(72, 74);
            this.boxModel.Name = "boxModel";
            this.boxModel.Size = new System.Drawing.Size(121, 21);
            this.boxModel.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Category:";
            // 
            // boxCategory
            // 
            this.boxCategory.FormattingEnabled = true;
            this.boxCategory.Location = new System.Drawing.Point(72, 46);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(121, 21);
            this.boxCategory.TabIndex = 34;
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.Location = new System.Drawing.Point(17, 263);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(191, 31);
            this.btnReturnBike.TabIndex = 40;
            this.btnReturnBike.Text = "Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(17, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 33);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search Bikes";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDeposite
            // 
            this.txtDeposite.Location = new System.Drawing.Point(83, 198);
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.Size = new System.Drawing.Size(125, 20);
            this.txtDeposite.TabIndex = 50;
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(136, 159);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(61, 20);
            this.txtRentalPrice.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Deposite: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Rental Price Less Than:";
            // 
            // ReturnBikeToCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 362);
            this.Controls.Add(this.txtDeposite);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvShowBikes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxBrand);
            this.Controls.Add(this.boxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCategory);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnSearch);
            this.Name = "ReturnBikeToCustomerForm";
            this.Text = "ReturnBikeToCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvShowBikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.ComboBox boxBrand;
        private System.Windows.Forms.ComboBox boxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxCategory;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDeposite;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}