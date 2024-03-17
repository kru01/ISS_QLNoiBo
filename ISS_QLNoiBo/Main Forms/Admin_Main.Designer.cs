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
            sysPreButton = new Button();
            roleButton = new Button();
            usersManageButton = new Button();
            privilegesButton = new Button();
            userButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(sysPreButton);
            panel1.Controls.Add(roleButton);
            panel1.Controls.Add(usersManageButton);
            panel1.Controls.Add(privilegesButton);
            panel1.Controls.Add(userButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 0;
            // 
            // sysPreButton
            // 
            sysPreButton.BackColor = Color.SteelBlue;
            sysPreButton.FlatAppearance.BorderSize = 0;
            sysPreButton.FlatStyle = FlatStyle.Flat;
            sysPreButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sysPreButton.ForeColor = Color.White;
            sysPreButton.Location = new Point(25, 550);
            sysPreButton.Name = "sysPreButton";
            sysPreButton.Size = new Size(250, 40);
            sysPreButton.TabIndex = 4;
            sysPreButton.Text = "System Privileges";
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
            roleButton.Location = new Point(25, 475);
            roleButton.Name = "roleButton";
            roleButton.Size = new Size(250, 40);
            roleButton.TabIndex = 3;
            roleButton.Text = "Role Management";
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
            usersManageButton.Text = "User Management";
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
            privilegesButton.Location = new Point(25, 325);
            privilegesButton.Name = "privilegesButton";
            privilegesButton.Size = new Size(250, 40);
            privilegesButton.TabIndex = 1;
            privilegesButton.Text = "Privileges";
            privilegesButton.UseVisualStyleBackColor = false;
            privilegesButton.Click += privilegesButton_Click;
            // 
            // userButton
            // 
            userButton.BackColor = Color.SteelBlue;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userButton.ForeColor = Color.White;
            userButton.Location = new Point(25, 250);
            userButton.Name = "userButton";
            userButton.Size = new Size(250, 40);
            userButton.TabIndex = 0;
            userButton.Text = "User Tab";
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Main";
            Text = "Admin Dashboard";
            Load += Admin_Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mainPanel;
        private Button userButton;
        private Button privilegesButton;
        private Button usersManageButton;
        private Button roleButton;
        private Button sysPreButton;
    }
}