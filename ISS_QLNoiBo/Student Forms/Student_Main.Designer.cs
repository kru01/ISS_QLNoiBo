namespace ISS_QLNoiBo.Student_Forms
{
    partial class Student_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Main));
            mainPanel = new Panel();
            panel1 = new Panel();
            program = new Label();
            label2 = new Label();
            classButton = new Button();
            studentName = new Label();
            signOutButton = new Button();
            studentID = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cRegistrationButton = new Button();
            courseButton = new Button();
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
            mainPanel.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(program);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(classButton);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(studentID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cRegistrationButton);
            panel1.Controls.Add(courseButton);
            panel1.Controls.Add(accountButton);
            panel1.Controls.Add(announceButton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 704);
            panel1.TabIndex = 11;
            // 
            // program
            // 
            program.AutoSize = true;
            program.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            program.ForeColor = Color.White;
            program.Location = new Point(78, 24);
            program.Name = "program";
            program.Size = new Size(76, 23);
            program.TabIndex = 14;
            program.Text = "AB1234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 24);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 13;
            label2.Text = "Program:";
            // 
            // classButton
            // 
            classButton.BackColor = Color.SteelBlue;
            classButton.FlatAppearance.BorderSize = 0;
            classButton.FlatStyle = FlatStyle.Flat;
            classButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classButton.ForeColor = Color.White;
            classButton.Location = new Point(25, 475);
            classButton.Name = "classButton";
            classButton.Size = new Size(250, 40);
            classButton.TabIndex = 12;
            classButton.Text = "Class";
            classButton.UseVisualStyleBackColor = false;
            classButton.Click += classButton_Click;
            // 
            // studentName
            // 
            studentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.White;
            studentName.Location = new Point(0, 210);
            studentName.Name = "studentName";
            studentName.Size = new Size(300, 28);
            studentName.TabIndex = 10;
            studentName.Text = "<Student Name>";
            studentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SteelBlue;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 525);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.ForeColor = Color.White;
            studentID.Location = new Point(94, 0);
            studentID.Name = "studentID";
            studentID.Size = new Size(76, 23);
            studentID.TabIndex = 7;
            studentID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 6;
            label1.Text = "Student ID:";
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
            // cRegistrationButton
            // 
            cRegistrationButton.BackColor = Color.SteelBlue;
            cRegistrationButton.FlatAppearance.BorderSize = 0;
            cRegistrationButton.FlatStyle = FlatStyle.Flat;
            cRegistrationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cRegistrationButton.ForeColor = Color.White;
            cRegistrationButton.Location = new Point(0, 425);
            cRegistrationButton.Name = "cRegistrationButton";
            cRegistrationButton.Size = new Size(300, 40);
            cRegistrationButton.TabIndex = 4;
            cRegistrationButton.Text = "Course Registration";
            cRegistrationButton.UseVisualStyleBackColor = false;
            cRegistrationButton.Click += cRegistrationButton_Click;
            // 
            // courseButton
            // 
            courseButton.BackColor = Color.SteelBlue;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseButton.ForeColor = Color.White;
            courseButton.Location = new Point(25, 375);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(250, 40);
            courseButton.TabIndex = 2;
            courseButton.Text = "Course";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.SteelBlue;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountButton.ForeColor = Color.White;
            accountButton.Location = new Point(25, 325);
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
            // 
            // Student_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard";
            Load += Student_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel1;
        private Button classButton;
        private Label studentName;
        private Button signOutButton;
        private Label studentID;
        private Label label1;
        private PictureBox pictureBox1;
        private Button cRegistrationButton;
        private Button courseButton;
        private Button accountButton;
        private Button announceButton;
        private Label program;
        private Label label2;
    }
}