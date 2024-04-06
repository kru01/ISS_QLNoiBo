namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class CoursePlanner
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
            panel3 = new Panel();
            YearUpDown = new NumericUpDown();
            SemUpDown = new NumericUpDown();
            ProgNameCbo = new ComboBox();
            label2 = new Label();
            ProgIDCbo = new ComboBox();
            label1 = new Label();
            CrsNameCbo = new ComboBox();
            CrsIDCbo = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            RefreshButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            label4 = new Label();
            label5 = new Label();
            OpenCrsData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(OpenCrsData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(373, 12);
            label8.Name = "label8";
            label8.Size = new Size(156, 35);
            label8.TabIndex = 22;
            label8.Text = "Course Plan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(YearUpDown);
            panel3.Controls.Add(SemUpDown);
            panel3.Controls.Add(ProgNameCbo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ProgIDCbo);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(CrsNameCbo);
            panel3.Controls.Add(CrsIDCbo);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(RefreshButton);
            panel3.Controls.Add(UpdateButton);
            panel3.Controls.Add(AddButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(3, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(897, 217);
            panel3.TabIndex = 21;
            // 
            // YearUpDown
            // 
            YearUpDown.Location = new Point(342, 50);
            YearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            YearUpDown.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            YearUpDown.Name = "YearUpDown";
            YearUpDown.Size = new Size(100, 27);
            YearUpDown.TabIndex = 30;
            YearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // SemUpDown
            // 
            SemUpDown.Location = new Point(217, 51);
            SemUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            SemUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SemUpDown.Name = "SemUpDown";
            SemUpDown.Size = new Size(100, 27);
            SemUpDown.TabIndex = 29;
            SemUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProgNameCbo
            // 
            ProgNameCbo.Enabled = false;
            ProgNameCbo.FormattingEnabled = true;
            ProgNameCbo.Location = new Point(467, 111);
            ProgNameCbo.Name = "ProgNameCbo";
            ProgNameCbo.Size = new Size(350, 28);
            ProgNameCbo.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(467, 85);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 27;
            label2.Text = "Program Name";
            // 
            // ProgIDCbo
            // 
            ProgIDCbo.FormattingEnabled = true;
            ProgIDCbo.Location = new Point(467, 51);
            ProgIDCbo.Name = "ProgIDCbo";
            ProgIDCbo.Size = new Size(100, 28);
            ProgIDCbo.TabIndex = 26;
            ProgIDCbo.TextChanged += ProgIDCbo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(467, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 25;
            label1.Text = "Program ID";
            // 
            // CrsNameCbo
            // 
            CrsNameCbo.Enabled = false;
            CrsNameCbo.FormattingEnabled = true;
            CrsNameCbo.Location = new Point(92, 111);
            CrsNameCbo.Name = "CrsNameCbo";
            CrsNameCbo.Size = new Size(350, 28);
            CrsNameCbo.TabIndex = 24;
            // 
            // CrsIDCbo
            // 
            CrsIDCbo.FormattingEnabled = true;
            CrsIDCbo.Location = new Point(92, 50);
            CrsIDCbo.Name = "CrsIDCbo";
            CrsIDCbo.Size = new Size(100, 28);
            CrsIDCbo.TabIndex = 23;
            CrsIDCbo.TextChanged += CrsIDCbo_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(342, 25);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 22;
            label10.Text = "Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(217, 25);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 21;
            label9.Text = "Semester";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(529, 156);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(100, 40);
            RefreshButton.TabIndex = 18;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.SteelBlue;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(404, 156);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 40);
            UpdateButton.TabIndex = 17;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SteelBlue;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(279, 156);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 40);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(92, 85);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 6;
            label4.Text = "Course Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(92, 25);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 5;
            label5.Text = "Course ID";
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
            OpenCrsData.Dock = DockStyle.Bottom;
            OpenCrsData.Location = new Point(0, 254);
            OpenCrsData.Name = "OpenCrsData";
            OpenCrsData.ReadOnly = true;
            OpenCrsData.RowHeadersVisible = false;
            OpenCrsData.RowHeadersWidth = 51;
            OpenCrsData.Size = new Size(904, 450);
            OpenCrsData.TabIndex = 2;
            OpenCrsData.CellClick += OpenCrsData_CellClick;
            // 
            // CoursePlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursePlanner";
            Text = "CoursePlanner";
            Load += CoursePlanner_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView OpenCrsData;
        private Panel panel3;
        private Button RefreshButton;
        private Button UpdateButton;
        private Button AddButton;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox CrsIDCbo;
        private ComboBox CrsNameCbo;
        private ComboBox ProgNameCbo;
        private Label label2;
        private ComboBox ProgIDCbo;
        private Label label1;
        private NumericUpDown YearUpDown;
        private NumericUpDown SemUpDown;
    }
}