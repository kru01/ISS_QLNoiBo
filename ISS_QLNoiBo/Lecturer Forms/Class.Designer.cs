namespace ISS_QLNoiBo.Lecturer_Forms
{
    partial class Class
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
            classData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            refreshButton = new Button();
            updateButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pScore = new TextBox();
            fScore = new TextBox();
            aScore = new TextBox();
            eScore = new TextBox();
            label3 = new Label();
            label2 = new Label();
            studentID = new TextBox();
            studentName = new TextBox();
            courseID = new TextBox();
            label8 = new Label();
            semester = new TextBox();
            label9 = new Label();
            label10 = new Label();
            year = new TextBox();
            label11 = new Label();
            programID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(classData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // classData
            // 
            classData.AllowUserToAddRows = false;
            classData.AllowUserToDeleteRows = false;
            classData.AllowUserToResizeColumns = false;
            classData.AllowUserToResizeRows = false;
            classData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            classData.BorderStyle = BorderStyle.None;
            classData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classData.Dock = DockStyle.Bottom;
            classData.Location = new Point(0, 304);
            classData.Name = "classData";
            classData.ReadOnly = true;
            classData.RowHeadersVisible = false;
            classData.RowHeadersWidth = 51;
            classData.Size = new Size(904, 400);
            classData.TabIndex = 0;
            classData.CellClick += classData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 2;
            label1.Text = "Class Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(programID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(year);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(semester);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pScore);
            panel2.Controls.Add(fScore);
            panel2.Controls.Add(aScore);
            panel2.Controls.Add(eScore);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(studentID);
            panel2.Controls.Add(studentName);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 250);
            panel2.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(454, 190);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(200, 40);
            refreshButton.TabIndex = 16;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(200, 190);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(200, 40);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(669, 114);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 14;
            label7.Text = "Average";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(542, 114);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 13;
            label6.Text = "Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(416, 114);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 12;
            label5.Text = "Process";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(288, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 11;
            label4.Text = "Exercise";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(416, 140);
            pScore.Name = "pScore";
            pScore.PlaceholderText = "Process";
            pScore.Size = new Size(75, 27);
            pScore.TabIndex = 10;
            pScore.KeyPress += pScore_KeyPress;
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(542, 140);
            fScore.Name = "fScore";
            fScore.PlaceholderText = "Final";
            fScore.Size = new Size(75, 27);
            fScore.TabIndex = 9;
            fScore.KeyPress += fScore_KeyPress;
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(669, 140);
            aScore.Name = "aScore";
            aScore.PlaceholderText = "Average";
            aScore.Size = new Size(75, 27);
            aScore.TabIndex = 8;
            aScore.KeyPress += aScore_KeyPress;
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(290, 140);
            eScore.Name = "eScore";
            eScore.PlaceholderText = "Exercise";
            eScore.Size = new Size(75, 27);
            eScore.TabIndex = 7;
            eScore.KeyPress += eScore_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(30, 114);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 6;
            label3.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Student ID";
            // 
            // studentID
            // 
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(30, 71);
            studentID.Name = "studentID";
            studentID.PlaceholderText = "Student ID";
            studentID.ReadOnly = true;
            studentID.Size = new Size(100, 27);
            studentID.TabIndex = 4;
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(30, 140);
            studentName.Name = "studentName";
            studentName.PlaceholderText = "Student Name";
            studentName.ReadOnly = true;
            studentName.Size = new Size(230, 27);
            studentName.TabIndex = 3;
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(290, 71);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(290, 44);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 18;
            label8.Text = "Course ID";
            // 
            // semester
            // 
            semester.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semester.Location = new Point(416, 71);
            semester.Name = "semester";
            semester.PlaceholderText = "Semester";
            semester.ReadOnly = true;
            semester.Size = new Size(100, 27);
            semester.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(416, 44);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 20;
            label9.Text = "Semester";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(542, 44);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 22;
            label10.Text = "Year";
            // 
            // year
            // 
            year.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            year.Location = new Point(542, 71);
            year.Name = "year";
            year.PlaceholderText = "Year";
            year.ReadOnly = true;
            year.Size = new Size(100, 27);
            year.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(669, 44);
            label11.Name = "label11";
            label11.Size = new Size(101, 23);
            label11.TabIndex = 24;
            label11.Text = "Program ID";
            // 
            // programID
            // 
            programID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programID.Location = new Point(669, 71);
            programID.Name = "programID";
            programID.PlaceholderText = "Program ID";
            programID.ReadOnly = true;
            programID.Size = new Size(100, 27);
            programID.TabIndex = 23;
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Class";
            Text = "Class";
            Load += Class_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView classData;
        private Panel panel2;
        private Label label1;
        private TextBox studentID;
        private TextBox studentName;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox pScore;
        private TextBox fScore;
        private TextBox aScore;
        private TextBox eScore;
        private Button updateButton;
        private Button refreshButton;
        private TextBox courseID;
        private Label label8;
        private Label label11;
        private TextBox programID;
        private Label label10;
        private TextBox year;
        private Label label9;
        private TextBox semester;
    }
}