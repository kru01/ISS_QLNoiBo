﻿namespace ISS_QLNoiBo.UnitHead_Forms
{
    partial class UnitHead_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitHead_Main));
            mainPanel = new Panel();
            panel1 = new Panel();
            assignmentButton = new Button();
            unitHeadName = new Label();
            signOutButton = new Button();
            unitHeadID = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            courseButton = new Button();
            studentButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
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
            mainPanel.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(assignmentButton);
            panel1.Controls.Add(unitHeadName);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(unitHeadID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(courseButton);
            panel1.Controls.Add(studentButton);
            panel1.Controls.Add(accountButton);
            panel1.Controls.Add(announceButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 15;
            // 
            // assignmentButton
            // 
            assignmentButton.BackColor = Color.SteelBlue;
            assignmentButton.FlatAppearance.BorderSize = 0;
            assignmentButton.FlatStyle = FlatStyle.Flat;
            assignmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignmentButton.ForeColor = Color.White;
            assignmentButton.Location = new Point(0, 450);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Size = new Size(300, 40);
            assignmentButton.TabIndex = 12;
            assignmentButton.Text = "Assignment";
            assignmentButton.UseVisualStyleBackColor = false;
            assignmentButton.Click += assignmentButton_Click;
            // 
            // unitHeadName
            // 
            unitHeadName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unitHeadName.ForeColor = Color.White;
            unitHeadName.Location = new Point(0, 210);
            unitHeadName.Name = "unitHeadName";
            unitHeadName.Size = new Size(300, 28);
            unitHeadName.TabIndex = 10;
            unitHeadName.Text = "<Unit Head Name>";
            unitHeadName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SteelBlue;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 500);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // unitHeadID
            // 
            unitHeadID.AutoSize = true;
            unitHeadID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitHeadID.ForeColor = Color.White;
            unitHeadID.Location = new Point(113, 0);
            unitHeadID.Name = "unitHeadID";
            unitHeadID.Size = new Size(76, 23);
            unitHeadID.TabIndex = 7;
            unitHeadID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 6;
            label1.Text = "Unit Head ID:";
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
            // courseButton
            // 
            courseButton.BackColor = Color.SteelBlue;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseButton.ForeColor = Color.White;
            courseButton.Location = new Point(0, 400);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(300, 40);
            courseButton.TabIndex = 4;
            courseButton.Text = "Course/Unit";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // studentButton
            // 
            studentButton.BackColor = Color.SteelBlue;
            studentButton.FlatAppearance.BorderSize = 0;
            studentButton.FlatStyle = FlatStyle.Flat;
            studentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentButton.ForeColor = Color.White;
            studentButton.Location = new Point(0, 350);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(300, 40);
            studentButton.TabIndex = 2;
            studentButton.Text = "Students List";
            studentButton.UseVisualStyleBackColor = false;
            studentButton.Click += studentButton_Click;
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
            // UnitHead_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UnitHead_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit Head Dashboard";
            Load += UnitHead_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel1;
        private Button assignmentButton;
        private Label unitHeadName;
        private Button signOutButton;
        private Label unitHeadID;
        private Label label1;
        private PictureBox pictureBox1;
        private Button courseButton;
        private Button studentButton;
        private Button accountButton;
        private Button announceButton;
    }
}