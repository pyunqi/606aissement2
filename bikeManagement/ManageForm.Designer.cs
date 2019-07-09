namespace KiwiBike4Rent.bikeManagement
{
    partial class ManageBikesForm
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
            this.dgvManageBikes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.boxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxModel = new System.Windows.Forms.ComboBox();
            this.boxBrand = new System.Windows.Forms.ComboBox();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageBikes
            // 
            this.dgvManageBikes.AllowUserToAddRows = false;
            this.dgvManageBikes.AllowUserToDeleteRows = false;
            this.dgvManageBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageBikes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvManageBikes.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dgvManageBikes.Location = new System.Drawing.Point(234, 15);
            this.dgvManageBikes.Name = "dgvManageBikes";
            this.dgvManageBikes.Size = new System.Drawing.Size(817, 376);
            this.dgvManageBikes.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Bikes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // boxCategory
            // 
            this.boxCategory.FormattingEnabled = true;
            this.boxCategory.Location = new System.Drawing.Point(75, 12);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(121, 21);
            this.boxCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category:";
            // 
            // boxModel
            // 
            this.boxModel.FormattingEnabled = true;
            this.boxModel.Location = new System.Drawing.Point(75, 40);
            this.boxModel.Name = "boxModel";
            this.boxModel.Size = new System.Drawing.Size(121, 21);
            this.boxModel.TabIndex = 1;
            // 
            // boxBrand
            // 
            this.boxBrand.FormattingEnabled = true;
            this.boxBrand.Location = new System.Drawing.Point(75, 67);
            this.boxBrand.Name = "boxBrand";
            this.boxBrand.Size = new System.Drawing.Size(121, 21);
            this.boxBrand.TabIndex = 2;
            // 
            // boxStatus
            // 
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Items.AddRange(new object[] {
            "available",
            "rented",
            "sold",
            "maintenance"});
            this.boxStatus.Location = new System.Drawing.Point(75, 94);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(121, 21);
            this.boxStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rental Price:";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(100, 128);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRentalPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Bike";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Bike";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Bike";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageBikesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.dgvManageBikes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxBrand);
            this.Controls.Add(this.boxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Name = "ManageBikesForm";
            this.Text = "Manage Bikes";
            this.Load += new System.EventHandler(this.UpdateBikesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvManageBikes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox boxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxModel;
        private System.Windows.Forms.ComboBox boxBrand;
        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}