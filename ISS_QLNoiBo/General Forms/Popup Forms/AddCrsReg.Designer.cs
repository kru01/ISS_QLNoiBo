namespace ISS_QLNoiBo.General_Forms.Popup_Forms
{
    partial class AddCrsReg
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
            OpenCrsData = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            LectIDCbo = new ComboBox();
            label11 = new Label();
            ProgIDBox = new TextBox();
            label10 = new Label();
            YearBox = new TextBox();
            label9 = new Label();
            SemBox = new TextBox();
            label4 = new Label();
            CrsNameBox = new TextBox();
            CrsIDLabel = new Label();
            CrsIDBox = new TextBox();
            CancelButton = new Button();
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            StuIDBox = new TextBox();
            StuNameBox = new TextBox();
            label1 = new Label();
            StudentData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(OpenCrsData);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(StudentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // OpenCrsData
            // 
            OpenCrsData.AllowUserToAddRows = false;
            OpenCrsData.AllowUserToDeleteRows = false;
            OpenCrsData.AllowUserToResizeColumns = false;
            OpenCrsData.AllowUserToResizeRows = false;
            OpenCrsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            OpenCrsData.BorderStyle = BorderStyle.None;
            OpenCrsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OpenCrsData.Location = new Point(458, 253);
            OpenCrsData.Name = "OpenCrsData";
            OpenCrsData.ReadOnly = true;
            OpenCrsData.RowHeadersVisible = false;
            OpenCrsData.RowHeadersWidth = 51;
            OpenCrsData.Size = new Size(445, 450);
            OpenCrsData.TabIndex = 2;
            OpenCrsData.CellClick += OpenCrsData_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(LectIDCbo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(ProgIDBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(YearBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(SemBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(CrsNameBox);
            panel2.Controls.Add(CrsIDLabel);
            panel2.Controls.Add(CrsIDBox);
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(StuIDBox);
            panel2.Controls.Add(StuNameBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 204);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(576, 97);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 38;
            label5.Text = "Lecturer Name";
            // 
            // LectIDCbo
            // 
            LectIDCbo.FormattingEnabled = true;
            LectIDCbo.Location = new Point(576, 123);
            LectIDCbo.Name = "LectIDCbo";
            LectIDCbo.Size = new Size(225, 28);
            LectIDCbo.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(701, 38);
            label11.Name = "label11";
            label11.Size = new Size(101, 23);
            label11.TabIndex = 36;
            label11.Text = "Program ID";
            // 
            // ProgIDBox
            // 
            ProgIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgIDBox.Location = new Point(701, 64);
            ProgIDBox.Name = "ProgIDBox";
            ProgIDBox.PlaceholderText = "Program ID";
            ProgIDBox.ReadOnly = true;
            ProgIDBox.Size = new Size(100, 27);
            ProgIDBox.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(576, 38);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 34;
            label10.Text = "Year";
            // 
            // YearBox
            // 
            YearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YearBox.Location = new Point(576, 64);
            YearBox.Name = "YearBox";
            YearBox.PlaceholderText = "Year";
            YearBox.ReadOnly = true;
            YearBox.Size = new Size(100, 27);
            YearBox.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(451, 38);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 32;
            label9.Text = "Semester";
            // 
            // SemBox
            // 
            SemBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SemBox.Location = new Point(451, 64);
            SemBox.Name = "SemBox";
            SemBox.PlaceholderText = "Semester";
            SemBox.ReadOnly = true;
            SemBox.Size = new Size(100, 27);
            SemBox.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(178, 97);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 20;
            label4.Text = "Course Name";
            // 
            // CrsNameBox
            // 
            CrsNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsNameBox.Location = new Point(178, 123);
            CrsNameBox.Name = "CrsNameBox";
            CrsNameBox.PlaceholderText = "Course Name";
            CrsNameBox.ReadOnly = true;
            CrsNameBox.Size = new Size(373, 27);
            CrsNameBox.TabIndex = 19;
            // 
            // CrsIDLabel
            // 
            CrsIDLabel.AutoSize = true;
            CrsIDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsIDLabel.ForeColor = Color.SteelBlue;
            CrsIDLabel.Location = new Point(72, 97);
            CrsIDLabel.Name = "CrsIDLabel";
            CrsIDLabel.Size = new Size(87, 23);
            CrsIDLabel.TabIndex = 18;
            CrsIDLabel.Text = "Course ID";
            // 
            // CrsIDBox
            // 
            CrsIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsIDBox.Location = new Point(72, 123);
            CrsIDBox.Name = "CrsIDBox";
            CrsIDBox.PlaceholderText = "Course ID";
            CrsIDBox.ReadOnly = true;
            CrsIDBox.Size = new Size(100, 27);
            CrsIDBox.TabIndex = 17;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.SteelBlue;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(432, 164);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(120, 35);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SteelBlue;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(299, 164);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 35);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(178, 38);
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
            label2.Location = new Point(72, 37);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Student ID";
            // 
            // StuIDBox
            // 
            StuIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StuIDBox.Location = new Point(72, 64);
            StuIDBox.Name = "StuIDBox";
            StuIDBox.PlaceholderText = "Student ID";
            StuIDBox.Size = new Size(100, 27);
            StuIDBox.TabIndex = 4;
            // 
            // StuNameBox
            // 
            StuNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StuNameBox.Location = new Point(178, 64);
            StuNameBox.Name = "StuNameBox";
            StuNameBox.PlaceholderText = "Student Name";
            StuNameBox.ReadOnly = true;
            StuNameBox.Size = new Size(230, 27);
            StuNameBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(305, -1);
            label1.Name = "label1";
            label1.Size = new Size(246, 35);
            label1.TabIndex = 2;
            label1.Text = "Course Registration";
            // 
            // StudentData
            // 
            StudentData.AllowUserToAddRows = false;
            StudentData.AllowUserToDeleteRows = false;
            StudentData.AllowUserToResizeColumns = false;
            StudentData.AllowUserToResizeRows = false;
            StudentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            StudentData.BorderStyle = BorderStyle.None;
            StudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentData.Location = new Point(0, 253);
            StudentData.Name = "StudentData";
            StudentData.ReadOnly = true;
            StudentData.RowHeadersVisible = false;
            StudentData.RowHeadersWidth = 51;
            StudentData.Size = new Size(445, 450);
            StudentData.TabIndex = 0;
            StudentData.CellClick += StudentData_CellClick;
            // 
            // AddCrsReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddCrsReg";
            Text = "Add New Course Registration";
            Load += CourseReg_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private TextBox StuNameBox;
        private Label label1;
        private DataGridView StudentData;
        private DataGridView OpenCrsData;
        private new Button CancelButton;
        private Label CrsIDLabel;
        private Label label4;
        private TextBox CrsNameBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        internal TextBox StuIDBox;
        internal TextBox CrsIDBox;
        internal TextBox ProgIDBox;
        internal TextBox YearBox;
        internal TextBox SemBox;
        internal ComboBox LectIDCbo;
    }
}