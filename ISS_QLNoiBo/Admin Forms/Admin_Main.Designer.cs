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
            pictureBox1 = new PictureBox();
            signOutButton = new Button();
            button2 = new Button();
            button1 = new Button();
            adminID = new Label();
            label1 = new Label();
            sysPreButton = new Button();
            roleButton = new Button();
            usersManageButton = new Button();
            privilegesButton = new Button();
            userButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(adminID);
            panel1.Controls.Add(label1);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(100, 100);
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
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 550);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 10;
            button2.Text = "Test 2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 500);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 9;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = false;
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
            sysPreButton.Location = new Point(25, 450);
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
            roleButton.Location = new Point(25, 400);
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
            usersManageButton.Location = new Point(25, 350);
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
            userButton.Text = "Inspect Privilege";
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
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label1;
        private Label adminID;
        private Button signOutButton;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}