namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class Assignment
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
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            assignmentData = new DataGridView();
            courseName = new TextBox();
            courseID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lecturerID = new TextBox();
            lecturerName = new TextBox();
            semesterBox = new TextBox();
            label5 = new Label();
            programBox = new TextBox();
            yearBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            updateButton = new Button();
            refreshButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(assignmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(590, 131);
            label8.Name = "label8";
            label8.Size = new Size(146, 35);
            label8.TabIndex = 23;
            label8.Text = "Assignment";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(yearBox);
            panel2.Controls.Add(programBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(semesterBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lecturerID);
            panel2.Controls.Add(lecturerName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(courseName);
            panel2.Location = new Point(438, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 400);
            panel2.TabIndex = 1;
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Location = new Point(12, 12);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(420, 680);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // courseName
            // 
            courseName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName.Location = new Point(159, 70);
            courseName.Name = "courseName";
            courseName.PlaceholderText = "Course Name";
            courseName.Size = new Size(250, 27);
            courseName.TabIndex = 24;
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(37, 70);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "ID";
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(159, 44);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 26;
            label4.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(26, 23);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(37, 129);
            label2.Name = "label2";
            label2.Size = new Size(26, 23);
            label2.TabIndex = 31;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(160, 129);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 30;
            label3.Text = "Lecturer Name";
            // 
            // lecturerID
            // 
            lecturerID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerID.Location = new Point(38, 155);
            lecturerID.Name = "lecturerID";
            lecturerID.PlaceholderText = "ID";
            lecturerID.Size = new Size(100, 27);
            lecturerID.TabIndex = 29;
            // 
            // lecturerName
            // 
            lecturerName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerName.Location = new Point(160, 155);
            lecturerName.Name = "lecturerName";
            lecturerName.PlaceholderText = "Lecturer Name";
            lecturerName.Size = new Size(250, 27);
            lecturerName.TabIndex = 28;
            // 
            // semesterBox
            // 
            semesterBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semesterBox.Location = new Point(37, 240);
            semesterBox.Name = "semesterBox";
            semesterBox.PlaceholderText = "Semester";
            semesterBox.ReadOnly = true;
            semesterBox.Size = new Size(100, 27);
            semesterBox.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(37, 214);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 33;
            label5.Text = "Semester";
            // 
            // programBox
            // 
            programBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programBox.Location = new Point(309, 240);
            programBox.Name = "programBox";
            programBox.PlaceholderText = "Program";
            programBox.ReadOnly = true;
            programBox.Size = new Size(100, 27);
            programBox.TabIndex = 34;
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(174, 240);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Year";
            yearBox.ReadOnly = true;
            yearBox.Size = new Size(100, 27);
            yearBox.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(174, 214);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 36;
            label6.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(309, 214);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 37;
            label7.Text = "Program";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(38, 310);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(150, 40);
            updateButton.TabIndex = 39;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(260, 310);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 40);
            refreshButton.TabIndex = 40;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // Assignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Assignment";
            Text = "Assignment";
            Load += Assignment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView assignmentData;
        private Panel panel2;
        private Label label8;
        private TextBox courseID;
        private TextBox courseName;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox lecturerID;
        private TextBox lecturerName;
        private TextBox semesterBox;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox yearBox;
        private TextBox programBox;
        private Button refreshButton;
        private Button updateButton;
    }
}