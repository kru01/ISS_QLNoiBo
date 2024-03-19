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
            panel2 = new Panel();
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
            label1 = new Label();
            classData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(classData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 250);
            panel2.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(326, 190);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(200, 40);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(579, 114);
            label7.Name = "label7";
            label7.Size = new Size(81, 23);
            label7.TabIndex = 14;
            label7.Text = "Avarage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(452, 114);
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
            label5.Location = new Point(326, 114);
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
            label4.Location = new Point(198, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 11;
            label4.Text = "Exercise";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(326, 140);
            pScore.Name = "pScore";
            pScore.PlaceholderText = "Process";
            pScore.Size = new Size(75, 27);
            pScore.TabIndex = 10;
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(452, 140);
            fScore.Name = "fScore";
            fScore.PlaceholderText = "Final";
            fScore.Size = new Size(75, 27);
            fScore.TabIndex = 9;
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(579, 140);
            aScore.Name = "aScore";
            aScore.PlaceholderText = "Avarage";
            aScore.Size = new Size(75, 27);
            aScore.TabIndex = 8;
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(200, 140);
            eScore.Name = "eScore";
            eScore.PlaceholderText = "Exercise";
            eScore.Size = new Size(75, 27);
            eScore.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(354, 44);
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
            label2.Location = new Point(200, 43);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Student ID";
            // 
            // studentID
            // 
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(200, 70);
            studentID.Name = "studentID";
            studentID.PlaceholderText = "Student ID";
            studentID.ReadOnly = true;
            studentID.Size = new Size(100, 27);
            studentID.TabIndex = 4;
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(354, 70);
            studentName.Name = "studentName";
            studentName.PlaceholderText = "Student Name";
            studentName.ReadOnly = true;
            studentName.Size = new Size(300, 27);
            studentName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(305, -1);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 2;
            label1.Text = "Class Management";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classData).EndInit();
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
    }
}