namespace KiwiBike4Rent.userManagement
{
    partial class ManageStaffForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lboxRole = new System.Windows.Forms.ComboBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.privligeSwitchGroup = new System.Windows.Forms.GroupBox();
            this.radioNAR = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioStaffID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.privligeSwitchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(53, 99);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(53, 125);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // lboxRole
            // 
            this.lboxRole.Enabled = false;
            this.lboxRole.FormattingEnabled = true;
            this.lboxRole.Items.AddRange(new object[] {
            "admin",
            "management",
            "check-out"});
            this.lboxRole.Location = new System.Drawing.Point(53, 151);
            this.lboxRole.Name = "lboxRole";
            this.lboxRole.Size = new System.Drawing.Size(100, 21);
            this.lboxRole.TabIndex = 13;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(209, 12);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(912, 377);
            this.dgvStaff.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 34);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 34);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // privligeSwitchGroup
            // 
            this.privligeSwitchGroup.Controls.Add(this.radioNAR);
            this.privligeSwitchGroup.Controls.Add(this.radioAll);
            this.privligeSwitchGroup.Controls.Add(this.radioStaffID);
            this.privligeSwitchGroup.Location = new System.Drawing.Point(15, 30);
            this.privligeSwitchGroup.Name = "privligeSwitchGroup";
            this.privligeSwitchGroup.Size = new System.Drawing.Size(160, 63);
            this.privligeSwitchGroup.TabIndex = 16;
            this.privligeSwitchGroup.TabStop = false;
            this.privligeSwitchGroup.Text = "Searching BY:";
            // 
            // radioNAR
            // 
            this.radioNAR.AutoSize = true;
            this.radioNAR.Location = new System.Drawing.Point(13, 40);
            this.radioNAR.Name = "radioNAR";
            this.radioNAR.Size = new System.Drawing.Size(100, 17);
            this.radioNAR.TabIndex = 1;
            this.radioNAR.TabStop = true;
            this.radioNAR.Text = "Name And Role";
            this.radioNAR.UseVisualStyleBackColor = true;
            this.radioNAR.CheckedChanged += new System.EventHandler(this.radioNAR_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(13, 19);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(66, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Staffs";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // radioStaffID
            // 
            this.radioStaffID.AutoSize = true;
            this.radioStaffID.Location = new System.Drawing.Point(85, 19);
            this.radioStaffID.Name = "radioStaffID";
            this.radioStaffID.Size = new System.Drawing.Size(51, 17);
            this.radioStaffID.TabIndex = 0;
            this.radioStaffID.TabStop = true;
            this.radioStaffID.Text = "By ID";
            this.radioStaffID.UseVisualStyleBackColor = true;
            this.radioStaffID.CheckedChanged += new System.EventHandler(this.radioStaff_CheckedChanged);
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 445);
            this.Controls.Add(this.privligeSwitchGroup);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.lboxRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Name = "ManageStaffForm";
            this.Text = "ManageStaffForm";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.privligeSwitchGroup.ResumeLayout(false);
            this.privligeSwitchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox lboxRole;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox privligeSwitchGroup;
        private System.Windows.Forms.RadioButton radioNAR;
        private System.Windows.Forms.RadioButton radioStaffID;
        private System.Windows.Forms.RadioButton radioAll;
    }
}