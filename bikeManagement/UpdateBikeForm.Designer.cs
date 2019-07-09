namespace KiwiBike4Rent.bikeManagement
{
    partial class UpdateBikeForm
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
            this.btnABM = new System.Windows.Forms.Button();
            this.accessories = new System.Windows.Forms.Label();
            this.mYear = new System.Windows.Forms.Label();
            this.dtpManufactured = new System.Windows.Forms.DateTimePicker();
            this.LifeTime = new System.Windows.Forms.Label();
            this.txtLifeTime = new System.Windows.Forms.TextBox();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.rentalPrice = new System.Windows.Forms.Label();
            this.lboxAccessories = new System.Windows.Forms.ComboBox();
            this.lboxStatus = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.listModels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(85, 139);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(121, 22);
            this.btnABM.TabIndex = 24;
            this.btnABM.Text = "Add New Model";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // accessories
            // 
            this.accessories.AutoSize = true;
            this.accessories.Location = new System.Drawing.Point(340, 224);
            this.accessories.Name = "accessories";
            this.accessories.Size = new System.Drawing.Size(67, 13);
            this.accessories.TabIndex = 27;
            this.accessories.Text = "Accessories:";
            // 
            // mYear
            // 
            this.mYear.AutoSize = true;
            this.mYear.Location = new System.Drawing.Point(21, 196);
            this.mYear.Name = "mYear";
            this.mYear.Size = new System.Drawing.Size(101, 13);
            this.mYear.TabIndex = 26;
            this.mYear.Text = "Manufactured Year:";
            // 
            // dtpManufactured
            // 
            this.dtpManufactured.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManufactured.Location = new System.Drawing.Point(136, 193);
            this.dtpManufactured.Name = "dtpManufactured";
            this.dtpManufactured.Size = new System.Drawing.Size(100, 20);
            this.dtpManufactured.TabIndex = 13;
            // 
            // LifeTime
            // 
            this.LifeTime.AutoSize = true;
            this.LifeTime.Location = new System.Drawing.Point(354, 200);
            this.LifeTime.Name = "LifeTime";
            this.LifeTime.Size = new System.Drawing.Size(53, 13);
            this.LifeTime.TabIndex = 25;
            this.LifeTime.Text = "Life Time:";
            // 
            // txtLifeTime
            // 
            this.txtLifeTime.Location = new System.Drawing.Point(421, 197);
            this.txtLifeTime.Name = "txtLifeTime";
            this.txtLifeTime.Size = new System.Drawing.Size(100, 20);
            this.txtLifeTime.TabIndex = 17;
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(136, 246);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRentalPrice.TabIndex = 16;
            // 
            // rentalPrice
            // 
            this.rentalPrice.AutoSize = true;
            this.rentalPrice.Location = new System.Drawing.Point(54, 246);
            this.rentalPrice.Name = "rentalPrice";
            this.rentalPrice.Size = new System.Drawing.Size(68, 13);
            this.rentalPrice.TabIndex = 20;
            this.rentalPrice.Text = "Rental Price:";
            // 
            // lboxAccessories
            // 
            this.lboxAccessories.FormattingEnabled = true;
            this.lboxAccessories.Items.AddRange(new object[] {
            "trailers",
            "car racks",
            "baby seats"});
            this.lboxAccessories.Location = new System.Drawing.Point(421, 223);
            this.lboxAccessories.Name = "lboxAccessories";
            this.lboxAccessories.Size = new System.Drawing.Size(100, 21);
            this.lboxAccessories.TabIndex = 19;
            // 
            // lboxStatus
            // 
            this.lboxStatus.FormattingEnabled = true;
            this.lboxStatus.Items.AddRange(new object[] {
            "available",
            "rented",
            "maintenance",
            "sold"});
            this.lboxStatus.Location = new System.Drawing.Point(136, 219);
            this.lboxStatus.Name = "lboxStatus";
            this.lboxStatus.Size = new System.Drawing.Size(100, 21);
            this.lboxStatus.TabIndex = 14;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(82, 219);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 18;
            this.status.Text = "Status:";
            // 
            // listModels
            // 
            this.listModels.FormattingEnabled = true;
            this.listModels.Location = new System.Drawing.Point(85, 12);
            this.listModels.Name = "listModels";
            this.listModels.Size = new System.Drawing.Size(669, 121);
            this.listModels.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Models:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 35);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update and Close";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.accessories);
            this.Controls.Add(this.mYear);
            this.Controls.Add(this.dtpManufactured);
            this.Controls.Add(this.LifeTime);
            this.Controls.Add(this.txtLifeTime);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.rentalPrice);
            this.Controls.Add(this.lboxAccessories);
            this.Controls.Add(this.lboxStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.listModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateBikeForm";
            this.Text = "UpdateBikeForm";
            this.Load += new System.EventHandler(this.UpdateBikeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnABM;
        private System.Windows.Forms.Label accessories;
        private System.Windows.Forms.Label mYear;
        private System.Windows.Forms.DateTimePicker dtpManufactured;
        private System.Windows.Forms.Label LifeTime;
        private System.Windows.Forms.TextBox txtLifeTime;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label rentalPrice;
        private System.Windows.Forms.ComboBox lboxAccessories;
        private System.Windows.Forms.ComboBox lboxStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ListBox listModels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}