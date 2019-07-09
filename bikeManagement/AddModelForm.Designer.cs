namespace KiwiBike4Rent.bikeManagement
{
    partial class AddModelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textDimension = new System.Windows.Forms.TextBox();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.textRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dimension:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deposit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rate Amount:";
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(83, 45);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(100, 20);
            this.textBrand.TabIndex = 1;
            // 
            // textDimension
            // 
            this.textDimension.Location = new System.Drawing.Point(83, 131);
            this.textDimension.Name = "textDimension";
            this.textDimension.Size = new System.Drawing.Size(100, 20);
            this.textDimension.TabIndex = 1;
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(83, 158);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(100, 20);
            this.textDeposit.TabIndex = 1;
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(83, 184);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(100, 20);
            this.textRate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(346, 45);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(341, 138);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "N/A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weight:";
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(83, 105);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 1;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "electric",
            "mountain",
            "city",
            "kids"});
            this.categoryBox.Location = new System.Drawing.Point(83, 78);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 4;
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textDeposit);
            this.Controls.Add(this.textDimension);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AddModelForm";
            this.Text = "AddModelForm";
            this.Load += new System.EventHandler(this.AddModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.TextBox textDimension;
        private System.Windows.Forms.TextBox textDeposit;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}