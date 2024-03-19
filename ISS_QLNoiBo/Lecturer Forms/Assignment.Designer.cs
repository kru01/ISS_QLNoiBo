namespace ISS_QLNoiBo.Lecturer_Forms
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
            assignmentData = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            programBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            yearBox = new TextBox();
            semesterBox = new TextBox();
            label4 = new Label();
            courseIDBox = new TextBox();
            label3 = new Label();
            lecturerName = new TextBox();
            label2 = new Label();
            courseName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Location = new Point(12, 12);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(450, 680);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(assignmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(programBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(yearBox);
            panel2.Controls.Add(semesterBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(courseIDBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lecturerName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(courseName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(468, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 400);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(155, 74);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 12;
            label7.Text = "Program";
            // 
            // programBox
            // 
            programBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programBox.Location = new Point(155, 100);
            programBox.Name = "programBox";
            programBox.PlaceholderText = "Program";
            programBox.ReadOnly = true;
            programBox.Size = new Size(100, 27);
            programBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(270, 74);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 10;
            label6.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(336, 74);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 9;
            label5.Text = "Semester";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(270, 100);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Year";
            yearBox.ReadOnly = true;
            yearBox.Size = new Size(50, 27);
            yearBox.TabIndex = 8;
            // 
            // semesterBox
            // 
            semesterBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semesterBox.Location = new Point(336, 100);
            semesterBox.Name = "semesterBox";
            semesterBox.PlaceholderText = "Semester";
            semesterBox.ReadOnly = true;
            semesterBox.Size = new Size(50, 27);
            semesterBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(36, 74);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 6;
            label4.Text = "Course ID";
            // 
            // courseIDBox
            // 
            courseIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseIDBox.Location = new Point(36, 100);
            courseIDBox.Name = "courseIDBox";
            courseIDBox.PlaceholderText = "Course ID";
            courseIDBox.ReadOnly = true;
            courseIDBox.Size = new Size(100, 27);
            courseIDBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(36, 274);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 4;
            label3.Text = "Lecturer Name";
            // 
            // lecturerName
            // 
            lecturerName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerName.Location = new Point(36, 300);
            lecturerName.Name = "lecturerName";
            lecturerName.PlaceholderText = "Lecturer Name";
            lecturerName.ReadOnly = true;
            lecturerName.Size = new Size(350, 27);
            lecturerName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(36, 174);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 2;
            label2.Text = "Course Name";
            // 
            // courseName
            // 
            courseName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName.Location = new Point(36, 200);
            courseName.Name = "courseName";
            courseName.PlaceholderText = "Course Name";
            courseName.ReadOnly = true;
            courseName.Size = new Size(350, 27);
            courseName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(138, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 35);
            label1.TabIndex = 0;
            label1.Text = "Assignment";
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
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView assignmentData;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox courseName;
        private Label label2;
        private Label label3;
        private TextBox lecturerName;
        private Label label4;
        private TextBox courseIDBox;
        private TextBox yearBox;
        private TextBox semesterBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox programBox;
    }
}