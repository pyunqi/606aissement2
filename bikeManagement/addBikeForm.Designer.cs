namespace KiwiBike4Rent.bikeManagement
{
    partial class AddBikeForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listModels = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.lboxStatus = new System.Windows.Forms.ComboBox();
            this.rentalPrice = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.LifeTime = new System.Windows.Forms.Label();
            this.txtLifeTime = new System.Windows.Forms.TextBox();
            this.dtpManufactured = new System.Windows.Forms.DateTimePicker();
            this.mYear = new System.Windows.Forms.Label();
            this.accessories = new System.Windows.Forms.Label();
            this.lboxAccessories = new System.Windows.Forms.ComboBox();
            this.btnABM = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Models:";
            // 
            // listModels
            // 
            this.listModels.FormattingEnabled = true;
            this.listModels.Location = new System.Drawing.Point(83, 12);
            this.listModels.Name = "listModels";
            this.listModels.Size = new System.Drawing.Size(669, 121);
            this.listModels.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(80, 219);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 4;
            this.status.Text = "Status:";
            // 
            // lboxStatus
            // 
            this.lboxStatus.FormattingEnabled = true;
            this.lboxStatus.Items.AddRange(new object[] {
            "available",
            "rented",
            "maintenance",
            "sold"});
            this.lboxStatus.Location = new System.Drawing.Point(134, 219);
            this.lboxStatus.Name = "lboxStatus";
            this.lboxStatus.Size = new System.Drawing.Size(100, 21);
            this.lboxStatus.TabIndex = 2;
            // 
            // rentalPrice
            // 
            this.rentalPrice.AutoSize = true;
            this.rentalPrice.Location = new System.Drawing.Point(52, 246);
            this.rentalPrice.Name = "rentalPrice";
            this.rentalPrice.Size = new System.Drawing.Size(68, 13);
            this.rentalPrice.TabIndex = 6;
            this.rentalPrice.Text = "Rental Price:";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(134, 246);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRentalPrice.TabIndex = 3;
            // 
            // LifeTime
            // 
            this.LifeTime.AutoSize = true;
            this.LifeTime.Location = new System.Drawing.Point(352, 200);
            this.LifeTime.Name = "LifeTime";
            this.LifeTime.Size = new System.Drawing.Size(53, 13);
            this.LifeTime.TabIndex = 8;
            this.LifeTime.Text = "Life Time:";
            // 
            // txtLifeTime
            // 
            this.txtLifeTime.Location = new System.Drawing.Point(419, 197);
            this.txtLifeTime.Name = "txtLifeTime";
            this.txtLifeTime.Size = new System.Drawing.Size(100, 20);
            this.txtLifeTime.TabIndex = 4;
            // 
            // dtpManufactured
            // 
            this.dtpManufactured.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManufactured.Location = new System.Drawing.Point(134, 193);
            this.dtpManufactured.Name = "dtpManufactured";
            this.dtpManufactured.Size = new System.Drawing.Size(100, 20);
            this.dtpManufactured.TabIndex = 1;
            // 
            // mYear
            // 
            this.mYear.AutoSize = true;
            this.mYear.Location = new System.Drawing.Point(19, 196);
            this.mYear.Name = "mYear";
            this.mYear.Size = new System.Drawing.Size(101, 13);
            this.mYear.TabIndex = 10;
            this.mYear.Text = "Manufactured Year:";
            // 
            // accessories
            // 
            this.accessories.AutoSize = true;
            this.accessories.Location = new System.Drawing.Point(338, 224);
            this.accessories.Name = "accessories";
            this.accessories.Size = new System.Drawing.Size(67, 13);
            this.accessories.TabIndex = 11;
            this.accessories.Text = "Accessories:";
            // 
            // lboxAccessories
            // 
            this.lboxAccessories.FormattingEnabled = true;
            this.lboxAccessories.Items.AddRange(new object[] {
            "trailers",
            "car racks",
            "baby seats"});
            this.lboxAccessories.Location = new System.Drawing.Point(419, 223);
            this.lboxAccessories.Name = "lboxAccessories";
            this.lboxAccessories.Size = new System.Drawing.Size(100, 21);
            this.lboxAccessories.TabIndex = 5;
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(83, 139);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(121, 22);
            this.btnABM.TabIndex = 7;
            this.btnABM.Text = "Add New Model";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(634, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 317);
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
            this.Controls.Add(this.btnSave);
            this.Name = "AddBikeForm";
            this.Text = "AddBikeForm";
            this.Load += new System.EventHandler(this.AddBikeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listModels;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox lboxStatus;
        private System.Windows.Forms.Label rentalPrice;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label LifeTime;
        private System.Windows.Forms.TextBox txtLifeTime;
        private System.Windows.Forms.DateTimePicker dtpManufactured;
        private System.Windows.Forms.Label mYear;
        private System.Windows.Forms.Label accessories;
        private System.Windows.Forms.ComboBox lboxAccessories;
        private System.Windows.Forms.Button btnABM;
        private System.Windows.Forms.Button btnClose;
    }
}