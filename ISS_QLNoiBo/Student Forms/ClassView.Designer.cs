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
            courseName = new TextBox();
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
            panel2.Controls.Add(courseName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 250);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(579, 123);
            label7.Name = "label7";
            label7.Size = new Size(81, 23);
            label7.TabIndex = 22;
            label7.Text = "Avarage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(452, 123);
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
            label5.Location = new Point(326, 123);
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
            label4.Location = new Point(198, 123);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 19;
            label4.Text = "Exercise";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(326, 149);
            pScore.Name = "pScore";
            pScore.PlaceholderText = "Process";
            pScore.ReadOnly = true;
            pScore.Size = new Size(75, 27);
            pScore.TabIndex = 18;
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(452, 149);
            fScore.Name = "fScore";
            fScore.PlaceholderText = "Final";
            fScore.ReadOnly = true;
            fScore.Size = new Size(75, 27);
            fScore.TabIndex = 17;
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(579, 149);
            aScore.Name = "aScore";
            aScore.PlaceholderText = "Avarage";
            aScore.ReadOnly = true;
            aScore.Size = new Size(75, 27);
            aScore.TabIndex = 16;
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(200, 149);
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
            label3.Location = new Point(354, 54);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 10;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(200, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 9;
            label2.Text = "Course ID";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(200, 80);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 8;
            // 
            // courseName
            // 
            courseName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName.Location = new Point(354, 80);
            courseName.Name = "courseName";
            courseName.PlaceholderText = "Course Name";
            courseName.ReadOnly = true;
            courseName.Size = new Size(300, 27);
            courseName.TabIndex = 7;
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
        private TextBox courseName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox pScore;
        private TextBox fScore;
        private TextBox aScore;
        private TextBox eScore;
    }
}