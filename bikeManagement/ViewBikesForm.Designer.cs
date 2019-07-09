namespace KiwiBike4Rent.bikeManagement
{
    partial class ViewBikesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvViewBikes = new System.Windows.Forms.DataGridView();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentalBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(75, 12);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category:";
            // 
            // dgvViewBikes
            // 
            this.dgvViewBikes.AllowUserToAddRows = false;
            this.dgvViewBikes.AllowUserToDeleteRows = false;
            this.dgvViewBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBikes.Location = new System.Drawing.Point(241, 12);
            this.dgvViewBikes.Name = "dgvViewBikes";
            this.dgvViewBikes.ReadOnly = true;
            this.dgvViewBikes.Size = new System.Drawing.Size(971, 346);
            this.dgvViewBikes.TabIndex = 6;
            // 
            // modelBox
            // 
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(75, 40);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(121, 21);
            this.modelBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // brandBox
            // 
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Location = new System.Drawing.Point(75, 67);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(121, 21);
            this.brandBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand:";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "available",
            "rented",
            "sold",
            "maintenance"});
            this.statusBox.Location = new System.Drawing.Point(75, 94);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rental Price Less Than:";
            // 
            // rentalBox
            // 
            this.rentalBox.Location = new System.Drawing.Point(126, 125);
            this.rentalBox.Name = "rentalBox";
            this.rentalBox.Size = new System.Drawing.Size(96, 20);
            this.rentalBox.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewBikesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 366);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rentalBox);
            this.Controls.Add(this.dgvViewBikes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.button1);
            this.Name = "ViewBikesForm";
            this.Text = "View Bikes";
            this.Load += new System.EventHandler(this.ViewBikesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViewBikes;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rentalBox;
        private System.Windows.Forms.Button btnClose;
    }
}