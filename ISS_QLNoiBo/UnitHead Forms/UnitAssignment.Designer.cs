namespace ISS_QLNoiBo.UnitHead_Forms
{
    partial class UnitAssignment
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
            refreshButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            label8 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            programCbo = new ComboBox();
            yearBox = new TextBox();
            semesterBox = new TextBox();
            courseCbo = new ComboBox();
            lecturerCbo = new ComboBox();
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
            assignmentData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Dock = DockStyle.Bottom;
            assignmentData.Location = new Point(0, 304);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(904, 400);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(343, 258);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 26;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(237, 258);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 40);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(131, 258);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 40);
            updateButton.TabIndex = 24;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(25, 258);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(319, 9);
            label8.Name = "label8";
            label8.Size = new Size(266, 35);
            label8.TabIndex = 23;
            label8.Text = "Assignment Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(programCbo);
            panel2.Controls.Add(yearBox);
            panel2.Controls.Add(semesterBox);
            panel2.Controls.Add(courseCbo);
            panel2.Controls.Add(lecturerCbo);
            panel2.Location = new Point(25, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 225);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(468, 124);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 10;
            label4.Text = "Program";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(563, 34);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 9;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(468, 34);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 8;
            label2.Text = "Semester";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(189, 124);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 7;
            label1.Text = "Course Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(189, 34);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 6;
            label5.Text = "Lecturer Name";
            // 
            // programCbo
            // 
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Location = new Point(468, 150);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(195, 27);
            programCbo.TabIndex = 4;
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(563, 60);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Year";
            yearBox.Size = new Size(100, 27);
            yearBox.TabIndex = 3;
            yearBox.KeyPress += yearBox_KeyPress;
            // 
            // semesterBox
            // 
            semesterBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semesterBox.Location = new Point(468, 60);
            semesterBox.Name = "semesterBox";
            semesterBox.Size = new Size(50, 27);
            semesterBox.TabIndex = 2;
            semesterBox.KeyPress += semesterBox_KeyPress;
            // 
            // courseCbo
            // 
            courseCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCbo.FormattingEnabled = true;
            courseCbo.Location = new Point(189, 150);
            courseCbo.Name = "courseCbo";
            courseCbo.Size = new Size(250, 27);
            courseCbo.TabIndex = 1;
            // 
            // lecturerCbo
            // 
            lecturerCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerCbo.FormattingEnabled = true;
            lecturerCbo.Location = new Point(189, 60);
            lecturerCbo.Name = "lecturerCbo";
            lecturerCbo.Size = new Size(250, 27);
            lecturerCbo.TabIndex = 0;
            // 
            // UnitAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(assignmentData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UnitAssignment";
            Text = "UnitAssignment";
            Load += UnitAssignment_Load;
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView assignmentData;
        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Button updateButton;
        private Button insertButton;
        private Button deleteButton;
        private Button refreshButton;
        private ComboBox courseCbo;
        private ComboBox lecturerCbo;
        private TextBox semesterBox;
        private TextBox yearBox;
        private ComboBox programCbo;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}