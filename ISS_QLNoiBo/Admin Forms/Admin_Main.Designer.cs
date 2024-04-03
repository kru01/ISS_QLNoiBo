namespace ISS_QLNoiBo
{
    partial class Admin_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main));
            panel1 = new Panel();
            AnnounButton = new Button();
            pictureBox1 = new PictureBox();
            signOutButton = new Button();
            InsAuditButton = new Button();
            viewButton = new Button();
            adminID = new Label();
            label1 = new Label();
            sysPreButton = new Button();
            roleButton = new Button();
            usersManageButton = new Button();
            privilegesButton = new Button();
            InsPrivButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(AnnounButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(InsAuditButton);
            panel1.Controls.Add(viewButton);
            panel1.Controls.Add(adminID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sysPreButton);
            panel1.Controls.Add(roleButton);
            panel1.Controls.Add(usersManageButton);
            panel1.Controls.Add(privilegesButton);
            panel1.Controls.Add(InsPrivButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 0;
            // 
            // AnnounButton
            // 
            AnnounButton.BackColor = Color.SteelBlue;
            AnnounButton.FlatAppearance.BorderSize = 0;
            AnnounButton.FlatStyle = FlatStyle.Flat;
            AnnounButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnnounButton.ForeColor = Color.White;
            AnnounButton.Location = new Point(25, 200);
            AnnounButton.Name = "AnnounButton";
            AnnounButton.Size = new Size(250, 40);
            AnnounButton.TabIndex = 12;
            AnnounButton.Text = "Announcement";
            AnnounButton.UseVisualStyleBackColor = false;
            AnnounButton.Click += AnnounButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(100, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SteelBlue;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 600);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 11;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // InsAuditButton
            // 
            InsAuditButton.BackColor = Color.SteelBlue;
            InsAuditButton.FlatAppearance.BorderSize = 0;
            InsAuditButton.FlatStyle = FlatStyle.Flat;
            InsAuditButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsAuditButton.ForeColor = Color.White;
            InsAuditButton.Location = new Point(25, 550);
            InsAuditButton.Name = "InsAuditButton";
            InsAuditButton.Size = new Size(250, 40);
            InsAuditButton.TabIndex = 10;
            InsAuditButton.Text = "Inspect Audit";
            InsAuditButton.UseVisualStyleBackColor = false;
            InsAuditButton.Click += InsAuditButton_Click;
            // 
            // viewButton
            // 
            viewButton.BackColor = Color.SteelBlue;
            viewButton.FlatAppearance.BorderSize = 0;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewButton.ForeColor = Color.White;
            viewButton.Location = new Point(25, 500);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(250, 40);
            viewButton.TabIndex = 9;
            viewButton.Text = "Manage View";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click;
            // 
            // adminID
            // 
            adminID.AutoSize = true;
            adminID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminID.ForeColor = Color.White;
            adminID.Location = new Point(82, 0);
            adminID.Name = "adminID";
            adminID.Size = new Size(76, 23);
            adminID.TabIndex = 8;
            adminID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 7;
            label1.Text = "Admin ID:";
            // 
            // sysPreButton
            // 
            sysPreButton.BackColor = Color.SteelBlue;
            sysPreButton.FlatAppearance.BorderSize = 0;
            sysPreButton.FlatStyle = FlatStyle.Flat;
            sysPreButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sysPreButton.ForeColor = Color.White;
            sysPreButton.Location = new Point(25, 350);
            sysPreButton.Name = "sysPreButton";
            sysPreButton.Size = new Size(250, 40);
            sysPreButton.TabIndex = 4;
            sysPreButton.Text = "Grant System Priv";
            sysPreButton.UseVisualStyleBackColor = false;
            sysPreButton.Click += sysPreButton_Click;
            // 
            // roleButton
            // 
            roleButton.BackColor = Color.SteelBlue;
            roleButton.FlatAppearance.BorderSize = 0;
            roleButton.FlatStyle = FlatStyle.Flat;
            roleButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleButton.ForeColor = Color.White;
            roleButton.Location = new Point(25, 450);
            roleButton.Name = "roleButton";
            roleButton.Size = new Size(250, 40);
            roleButton.TabIndex = 3;
            roleButton.Text = "Manage Role";
            roleButton.UseVisualStyleBackColor = false;
            roleButton.Click += roleButton_Click;
            // 
            // usersManageButton
            // 
            usersManageButton.BackColor = Color.SteelBlue;
            usersManageButton.FlatAppearance.BorderSize = 0;
            usersManageButton.FlatStyle = FlatStyle.Flat;
            usersManageButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersManageButton.ForeColor = Color.White;
            usersManageButton.Location = new Point(25, 400);
            usersManageButton.Name = "usersManageButton";
            usersManageButton.Size = new Size(250, 40);
            usersManageButton.TabIndex = 2;
            usersManageButton.Text = "Manage User";
            usersManageButton.UseVisualStyleBackColor = false;
            usersManageButton.Click += usersManageButton_Click;
            // 
            // privilegesButton
            // 
            privilegesButton.BackColor = Color.SteelBlue;
            privilegesButton.FlatAppearance.BorderSize = 0;
            privilegesButton.FlatStyle = FlatStyle.Flat;
            privilegesButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            privilegesButton.ForeColor = Color.White;
            privilegesButton.Location = new Point(25, 300);
            privilegesButton.Name = "privilegesButton";
            privilegesButton.Size = new Size(250, 40);
            privilegesButton.TabIndex = 1;
            privilegesButton.Text = "Grant Role/Table";
            privilegesButton.UseVisualStyleBackColor = false;
            privilegesButton.Click += privilegesButton_Click;
            // 
            // InsPrivButton
            // 
            InsPrivButton.BackColor = Color.SteelBlue;
            InsPrivButton.FlatAppearance.BorderSize = 0;
            InsPrivButton.FlatStyle = FlatStyle.Flat;
            InsPrivButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsPrivButton.ForeColor = Color.White;
            InsPrivButton.Location = new Point(25, 250);
            InsPrivButton.Name = "InsPrivButton";
            InsPrivButton.Size = new Size(250, 40);
            InsPrivButton.TabIndex = 0;
            InsPrivButton.Text = "Inspect Privilege";
            InsPrivButton.UseVisualStyleBackColor = false;
            InsPrivButton.Click += InsPrivButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(904, 704);
            mainPanel.TabIndex = 1;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Main";
            Text = "Admin Dashboard";
            Load += Admin_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mainPanel;
        private Button InsPrivButton;
        private Button privilegesButton;
        private Button usersManageButton;
        private Button roleButton;
        private Button sysPreButton;
        private Label label1;
        private Label adminID;
        private Button signOutButton;
        private Button InsAuditButton;
        private Button viewButton;
        private PictureBox pictureBox1;
        private Button AnnounButton;
    }
}