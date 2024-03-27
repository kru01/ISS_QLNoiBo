namespace ISS_QLNoiBo.Employee_Forms
{
    partial class Emp_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_Main));
            panel1 = new Panel();
            EmpName = new Label();
            signOutButton = new Button();
            empID = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            courseButton = new Button();
            studentListButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(EmpName);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(empID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(courseButton);
            panel1.Controls.Add(studentListButton);
            panel1.Controls.Add(accountButton);
            panel1.Controls.Add(announceButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 1;
            // 
            // EmpName
            // 
            EmpName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpName.ForeColor = Color.White;
            EmpName.Location = new Point(0, 210);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(300, 28);
            EmpName.TabIndex = 10;
            EmpName.Text = "<Employee Name>";
            EmpName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SteelBlue;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 575);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empID.ForeColor = Color.White;
            empID.Location = new Point(109, 0);
            empID.Name = "empID";
            empID.Size = new Size(76, 23);
            empID.TabIndex = 7;
            empID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 6;
            label1.Text = "Employee ID:";
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
            courseButton.Location = new Point(0, 500);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(300, 40);
            courseButton.TabIndex = 4;
            courseButton.Text = "Courses/Unit";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // studentListButton
            // 
            studentListButton.BackColor = Color.SteelBlue;
            studentListButton.FlatAppearance.BorderSize = 0;
            studentListButton.FlatStyle = FlatStyle.Flat;
            studentListButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentListButton.ForeColor = Color.White;
            studentListButton.Location = new Point(25, 425);
            studentListButton.Name = "studentListButton";
            studentListButton.Size = new Size(250, 40);
            studentListButton.TabIndex = 2;
            studentListButton.Text = "Students List";
            studentListButton.UseVisualStyleBackColor = false;
            studentListButton.Click += studentListButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.SteelBlue;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(25, 350);
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
            announceButton.Location = new Point(25, 275);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(250, 40);
            announceButton.TabIndex = 0;
            announceButton.Text = "Announcement";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(904, 704);
            mainPanel.TabIndex = 8;
            // 
            // Emp_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Emp_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            Load += Emp_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label empID;
        private Label label1;
        private PictureBox pictureBox1;
        private Button courseButton;
        private Button studentListButton;
        private Button accountButton;
        private Button announceButton;
        private Panel mainPanel;
        private Button signOutButton;
        private Label EmpName;
    }
}