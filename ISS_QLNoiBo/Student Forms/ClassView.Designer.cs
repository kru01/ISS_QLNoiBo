namespace ISS_QLNoiBo.Student_Forms
{
    partial class ClassView
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
            classViewData = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            progID = new TextBox();
            label10 = new Label();
            yearBox = new TextBox();
            label9 = new Label();
            semBox = new TextBox();
            label8 = new Label();
            stuID = new TextBox();
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
            courseID = new TextBox();
            lectID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)classViewData).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // classViewData
            // 
            classViewData.AllowUserToAddRows = false;
            classViewData.AllowUserToDeleteRows = false;
            classViewData.AllowUserToResizeColumns = false;
            classViewData.AllowUserToResizeRows = false;
            classViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            classViewData.BorderStyle = BorderStyle.None;
            classViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classViewData.Dock = DockStyle.Bottom;
            classViewData.Location = new Point(0, 304);
            classViewData.Name = "classViewData";
            classViewData.RowHeadersVisible = false;
            classViewData.RowHeadersWidth = 51;
            classViewData.Size = new Size(904, 400);
            classViewData.TabIndex = 0;
            classViewData.CellClick += classViewData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
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
            panel2.Controls.Add(label11);
            panel2.Controls.Add(progID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(yearBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(semBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(stuID);
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
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(lectID);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 250);
            panel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(378, 144);
            label11.Name = "label11";
            label11.Size = new Size(101, 23);
            label11.TabIndex = 30;
            label11.Text = "Program ID";
            // 
            // progID
            // 
            progID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progID.Location = new Point(378, 170);
            progID.Name = "progID";
            progID.PlaceholderText = "Program ID";
            progID.ReadOnly = true;
            progID.Size = new Size(100, 27);
            progID.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(252, 144);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 28;
            label10.Text = "Year";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(252, 170);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Year";
            yearBox.ReadOnly = true;
            yearBox.Size = new Size(100, 27);
            yearBox.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(124, 144);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 26;
            label9.Text = "Semester";
            // 
            // semBox
            // 
            semBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semBox.Location = new Point(124, 170);
            semBox.Name = "semBox";
            semBox.PlaceholderText = "Semester";
            semBox.ReadOnly = true;
            semBox.Size = new Size(100, 27);
            semBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(124, 64);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 24;
            label8.Text = "Student ID";
            // 
            // stuID
            // 
            stuID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stuID.Location = new Point(124, 90);
            stuID.Name = "stuID";
            stuID.PlaceholderText = "Student ID";
            stuID.ReadOnly = true;
            stuID.Size = new Size(100, 27);
            stuID.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(654, 144);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 22;
            label7.Text = "Average";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(550, 144);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 21;
            label6.Text = "Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(653, 64);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 20;
            label5.Text = "Process";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(548, 64);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 19;
            label4.Text = "Exercise";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(653, 90);
            pScore.Name = "pScore";
            pScore.PlaceholderText = "Process";
            pScore.ReadOnly = true;
            pScore.Size = new Size(75, 27);
            pScore.TabIndex = 18;
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(550, 170);
            fScore.Name = "fScore";
            fScore.PlaceholderText = "Final";
            fScore.ReadOnly = true;
            fScore.Size = new Size(75, 27);
            fScore.TabIndex = 17;
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(654, 170);
            aScore.Name = "aScore";
            aScore.PlaceholderText = "Average";
            aScore.ReadOnly = true;
            aScore.Size = new Size(75, 27);
            aScore.TabIndex = 16;
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(550, 90);
            eScore.Name = "eScore";
            eScore.PlaceholderText = "Exercise";
            eScore.ReadOnly = true;
            eScore.Size = new Size(75, 27);
            eScore.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(252, 64);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 10;
            label3.Text = "Lecturer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(378, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 9;
            label2.Text = "Course ID";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(378, 90);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 8;
            // 
            // lectID
            // 
            lectID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lectID.Location = new Point(252, 90);
            lectID.Name = "lectID";
            lectID.PlaceholderText = "Lecturer ID";
            lectID.ReadOnly = true;
            lectID.Size = new Size(100, 27);
            lectID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(354, -1);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 3;
            label1.Text = "Class View";
            // 
            // ClassView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(classViewData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassView";
            Text = "ClassView";
            Load += ClassView_Load;
            ((System.ComponentModel.ISupportInitialize)classViewData).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView classViewData;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox courseID;
        private TextBox lectID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox pScore;
        private TextBox fScore;
        private TextBox aScore;
        private TextBox eScore;
        private TextBox stuID;
        private Label label8;
        private Label label9;
        private TextBox semBox;
        private Label label11;
        private TextBox progID;
        private Label label10;
        private TextBox yearBox;
    }
}