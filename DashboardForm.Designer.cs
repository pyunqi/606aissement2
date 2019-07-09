namespace KiwiBike4Rent
{
    partial class Dashboard
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
            this.btnUserManage = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageBikes = new System.Windows.Forms.Button();
            this.btnViewBkies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserManage
            // 
            this.btnUserManage.Location = new System.Drawing.Point(32, 23);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(172, 35);
            this.btnUserManage.TabIndex = 0;
            this.btnUserManage.Text = "User Management";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(374, 23);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(101, 35);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(374, 146);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageBikes
            // 
            this.btnManageBikes.Location = new System.Drawing.Point(32, 105);
            this.btnManageBikes.Name = "btnManageBikes";
            this.btnManageBikes.Size = new System.Drawing.Size(172, 37);
            this.btnManageBikes.TabIndex = 2;
            this.btnManageBikes.Text = "Manage Bikes";
            this.btnManageBikes.UseVisualStyleBackColor = true;
            this.btnManageBikes.Click += new System.EventHandler(this.btnUpdateBikes_Click);
            // 
            // btnViewBkies
            // 
            this.btnViewBkies.Location = new System.Drawing.Point(32, 64);
            this.btnViewBkies.Name = "btnViewBkies";
            this.btnViewBkies.Size = new System.Drawing.Size(172, 35);
            this.btnViewBkies.TabIndex = 1;
            this.btnViewBkies.Text = "View Bikes";
            this.btnViewBkies.UseVisualStyleBackColor = true;
            this.btnViewBkies.Click += new System.EventHandler(this.btnViewBkies_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 210);
            this.Controls.Add(this.btnManageBikes);
            this.Controls.Add(this.btnViewBkies);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnUserManage);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageBikes;
        private System.Windows.Forms.Button btnViewBkies;
    }
}