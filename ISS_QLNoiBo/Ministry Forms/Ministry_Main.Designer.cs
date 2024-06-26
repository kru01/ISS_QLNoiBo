﻿namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class Ministry_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ministry_Main));
            mainPanel = new Panel();
            panel1 = new Panel();
            cRegistrationButton = new Button();
            assignmentButton = new Button();
            courseMButton = new Button();
            ministryName = new Label();
            signOutButton = new Button();
            ministryID = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            unitMButton = new Button();
            studentMButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            CrsPlannerButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(904, 704);
            mainPanel.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(CrsPlannerButton);
            panel1.Controls.Add(cRegistrationButton);
            panel1.Controls.Add(assignmentButton);
            panel1.Controls.Add(courseMButton);
            panel1.Controls.Add(ministryName);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(ministryID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(unitMButton);
            panel1.Controls.Add(studentMButton);
            panel1.Controls.Add(accountButton);
            panel1.Controls.Add(announceButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 13;
            // 
            // cRegistrationButton
            // 
            cRegistrationButton.BackColor = Color.SteelBlue;
            cRegistrationButton.FlatAppearance.BorderSize = 0;
            cRegistrationButton.FlatStyle = FlatStyle.Flat;
            cRegistrationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cRegistrationButton.ForeColor = Color.White;
            cRegistrationButton.Location = new Point(0, 600);
            cRegistrationButton.Name = "cRegistrationButton";
            cRegistrationButton.Size = new Size(300, 40);
            cRegistrationButton.TabIndex = 5;
            cRegistrationButton.Text = "Course Registration";
            cRegistrationButton.UseVisualStyleBackColor = false;
            cRegistrationButton.Click += cRegistrationButton_Click;
            // 
            // assignmentButton
            // 
            assignmentButton.BackColor = Color.SteelBlue;
            assignmentButton.FlatAppearance.BorderSize = 0;
            assignmentButton.FlatStyle = FlatStyle.Flat;
            assignmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignmentButton.ForeColor = Color.White;
            assignmentButton.Location = new Point(0, 550);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Size = new Size(300, 40);
            assignmentButton.TabIndex = 13;
            assignmentButton.Text = "Assignment";
            assignmentButton.UseVisualStyleBackColor = false;
            assignmentButton.Click += assignmentButton_Click;
            // 
            // courseMButton
            // 
            courseMButton.BackColor = Color.SteelBlue;
            courseMButton.FlatAppearance.BorderSize = 0;
            courseMButton.FlatStyle = FlatStyle.Flat;
            courseMButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseMButton.ForeColor = Color.White;
            courseMButton.Location = new Point(0, 450);
            courseMButton.Name = "courseMButton";
            courseMButton.Size = new Size(300, 40);
            courseMButton.TabIndex = 12;
            courseMButton.Text = "Course Manager";
            courseMButton.UseVisualStyleBackColor = false;
            courseMButton.Click += courseMButton_Click;
            // 
            // ministryName
            // 
            ministryName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ministryName.ForeColor = Color.White;
            ministryName.Location = new Point(0, 210);
            ministryName.Name = "ministryName";
            ministryName.Size = new Size(300, 28);
            ministryName.TabIndex = 10;
            ministryName.Text = "<Ministry Name>";
            ministryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SteelBlue;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 650);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // ministryID
            // 
            ministryID.AutoSize = true;
            ministryID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ministryID.ForeColor = Color.White;
            ministryID.Location = new Point(94, 0);
            ministryID.Name = "ministryID";
            ministryID.Size = new Size(76, 23);
            ministryID.TabIndex = 7;
            ministryID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 6;
            label1.Text = "Ministry ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // unitMButton
            // 
            unitMButton.BackColor = Color.SteelBlue;
            unitMButton.FlatAppearance.BorderSize = 0;
            unitMButton.FlatStyle = FlatStyle.Flat;
            unitMButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitMButton.ForeColor = Color.White;
            unitMButton.Location = new Point(0, 400);
            unitMButton.Name = "unitMButton";
            unitMButton.Size = new Size(300, 40);
            unitMButton.TabIndex = 4;
            unitMButton.Text = "Unit Manager";
            unitMButton.UseVisualStyleBackColor = false;
            unitMButton.Click += unitMButton_Click;
            // 
            // studentMButton
            // 
            studentMButton.BackColor = Color.SteelBlue;
            studentMButton.FlatAppearance.BorderSize = 0;
            studentMButton.FlatStyle = FlatStyle.Flat;
            studentMButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentMButton.ForeColor = Color.White;
            studentMButton.Location = new Point(0, 350);
            studentMButton.Name = "studentMButton";
            studentMButton.Size = new Size(300, 40);
            studentMButton.TabIndex = 2;
            studentMButton.Text = "Student Manager";
            studentMButton.UseVisualStyleBackColor = false;
            studentMButton.Click += studentMButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.SteelBlue;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(25, 300);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(250, 40);
            accountButton.TabIndex = 1;
            accountButton.Text = "Account";
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += accountButton_Click;
            // 
            // announceButton
            // 
            announceButton.BackColor = Color.SteelBlue;
            announceButton.FlatAppearance.BorderSize = 0;
            announceButton.FlatStyle = FlatStyle.Flat;
            announceButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announceButton.ForeColor = Color.White;
            announceButton.Location = new Point(25, 250);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(250, 40);
            announceButton.TabIndex = 0;
            announceButton.Text = "Announcement";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // CrsPlannerButton
            // 
            CrsPlannerButton.BackColor = Color.SteelBlue;
            CrsPlannerButton.FlatAppearance.BorderSize = 0;
            CrsPlannerButton.FlatStyle = FlatStyle.Flat;
            CrsPlannerButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsPlannerButton.ForeColor = Color.White;
            CrsPlannerButton.Location = new Point(0, 500);
            CrsPlannerButton.Name = "CrsPlannerButton";
            CrsPlannerButton.Size = new Size(300, 40);
            CrsPlannerButton.TabIndex = 14;
            CrsPlannerButton.Text = "Course Planner";
            CrsPlannerButton.UseVisualStyleBackColor = false;
            CrsPlannerButton.Click += CrsPlannerButton_Click;
            // 
            // Ministry_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ministry_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ministry Dashboard";
            Load += Ministry_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel1;
        private Button courseMButton;
        private Label ministryName;
        private Button signOutButton;
        private Label ministryID;
        private Label label1;
        private PictureBox pictureBox1;
        private Button unitMButton;
        private Button studentMButton;
        private Button accountButton;
        private Button announceButton;
        private Button assignmentButton;
        private Button cRegistrationButton;
        private Button CrsPlannerButton;
    }
}