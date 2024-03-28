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
            progCbo = new ComboBox();
            yearUpDown = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            semUpDown = new NumericUpDown();
            courseID = new TextBox();
            refreshButton = new Button();
            updateButton = new Button();
            label7 = new Label();
            label6 = new Label();
            unitNameBox = new TextBox();
            label5 = new Label();
            unitIDBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lecturerID = new TextBox();
            assignmentData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
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
            panel2.Controls.Add(progCbo);
            panel2.Controls.Add(yearUpDown);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(semUpDown);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(unitNameBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(unitIDBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lecturerID);
            panel2.Location = new Point(438, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 400);
            panel2.TabIndex = 1;
            // 
            // progCbo
            // 
            progCbo.Enabled = false;
            progCbo.FormattingEnabled = true;
            progCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            progCbo.Location = new Point(309, 169);
            progCbo.Name = "progCbo";
            progCbo.Size = new Size(100, 28);
            progCbo.TabIndex = 46;
            progCbo.Text = "CQ";
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(174, 170);
            yearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            yearUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearUpDown.Name = "yearUpDown";
            yearUpDown.ReadOnly = true;
            yearUpDown.Size = new Size(100, 27);
            yearUpDown.TabIndex = 45;
            yearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(260, 227);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 44;
            label3.Text = "Unit Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(37, 227);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 43;
            label4.Text = "Unit ID";
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(38, 170);
            semUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            semUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semUpDown.Name = "semUpDown";
            semUpDown.ReadOnly = true;
            semUpDown.Size = new Size(100, 27);
            semUpDown.TabIndex = 42;
            semUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(260, 70);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(150, 27);
            courseID.TabIndex = 41;
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
            refreshButton.Click += refreshButton_Click;
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
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(309, 144);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 37;
            label7.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(174, 144);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 36;
            label6.Text = "Year";
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(260, 253);
            unitNameBox.Name = "unitNameBox";
            unitNameBox.PlaceholderText = "Unit Name";
            unitNameBox.ReadOnly = true;
            unitNameBox.Size = new Size(150, 27);
            unitNameBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(37, 144);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 33;
            label5.Text = "Semester";
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(38, 253);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.PlaceholderText = "Unit ID";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(150, 27);
            unitIDBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(260, 44);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 31;
            label2.Text = "Course ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 27;
            label1.Text = "Lecturer ID";
            // 
            // lecturerID
            // 
            lecturerID.CharacterCasing = CharacterCasing.Upper;
            lecturerID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerID.Location = new Point(37, 70);
            lecturerID.Name = "lecturerID";
            lecturerID.PlaceholderText = "Lecturer ID";
            lecturerID.Size = new Size(151, 27);
            lecturerID.TabIndex = 25;
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
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView assignmentData;
        private Panel panel2;
        private Label label8;
        private TextBox lecturerID;
        private Label label1;
        private Label label2;
        private TextBox unitIDBox;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox unitNameBox;
        private TextBox programBox;
        private Button refreshButton;
        private Button updateButton;
        private TextBox courseID;
        private NumericUpDown semUpDown;
        private Label label4;
        private Label label3;
        private NumericUpDown yearUpDown;
        private ComboBox progCbo;
    }
}