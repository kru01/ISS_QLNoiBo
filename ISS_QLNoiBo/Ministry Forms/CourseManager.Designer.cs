namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class CourseManager
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
            CrsData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            UnitNameCbo = new ComboBox();
            label9 = new Label();
            UnitIDUpDown = new NumericUpDown();
            label8 = new Label();
            MaxStuUpDown = new NumericUpDown();
            label5 = new Label();
            PracUpDown = new NumericUpDown();
            label4 = new Label();
            TheoUpDown = new NumericUpDown();
            CredUpDown = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            RefreshButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            CrsIDBox = new TextBox();
            CrsNameBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrsData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UnitIDUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxStuUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PracUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TheoUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CredUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CrsData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // CrsData
            // 
            CrsData.AllowUserToAddRows = false;
            CrsData.AllowUserToDeleteRows = false;
            CrsData.AllowUserToResizeColumns = false;
            CrsData.AllowUserToResizeRows = false;
            CrsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CrsData.BorderStyle = BorderStyle.None;
            CrsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CrsData.Dock = DockStyle.Bottom;
            CrsData.Location = new Point(0, 254);
            CrsData.Name = "CrsData";
            CrsData.ReadOnly = true;
            CrsData.RowHeadersVisible = false;
            CrsData.RowHeadersWidth = 51;
            CrsData.Size = new Size(904, 450);
            CrsData.TabIndex = 0;
            CrsData.CellClick += CrsData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(321, 12);
            label1.Name = "label1";
            label1.Size = new Size(262, 35);
            label1.TabIndex = 2;
            label1.Text = "Course Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(UnitNameCbo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(UnitIDUpDown);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(MaxStuUpDown);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(PracUpDown);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TheoUpDown);
            panel2.Controls.Add(CredUpDown);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CrsIDBox);
            panel2.Controls.Add(CrsNameBox);
            panel2.Location = new Point(3, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 217);
            panel2.TabIndex = 1;
            // 
            // UnitNameCbo
            // 
            UnitNameCbo.Enabled = false;
            UnitNameCbo.FormattingEnabled = true;
            UnitNameCbo.Location = new Point(579, 106);
            UnitNameCbo.Name = "UnitNameCbo";
            UnitNameCbo.Size = new Size(250, 28);
            UnitNameCbo.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(579, 81);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 32;
            label9.Text = "Unit Name";
            // 
            // UnitIDUpDown
            // 
            UnitIDUpDown.Location = new Point(579, 51);
            UnitIDUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            UnitIDUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UnitIDUpDown.Name = "UnitIDUpDown";
            UnitIDUpDown.Size = new Size(100, 27);
            UnitIDUpDown.TabIndex = 30;
            UnitIDUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UnitIDUpDown.ValueChanged += UnitIDUpDown_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(579, 25);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 29;
            label8.Text = "Unit ID";
            // 
            // MaxStuUpDown
            // 
            MaxStuUpDown.Location = new Point(454, 107);
            MaxStuUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            MaxStuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxStuUpDown.Name = "MaxStuUpDown";
            MaxStuUpDown.Size = new Size(100, 27);
            MaxStuUpDown.TabIndex = 28;
            MaxStuUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(454, 81);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 27;
            label5.Text = "Max Student";
            // 
            // PracUpDown
            // 
            PracUpDown.Location = new Point(329, 107);
            PracUpDown.Name = "PracUpDown";
            PracUpDown.Size = new Size(100, 27);
            PracUpDown.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(329, 81);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 25;
            label4.Text = "Practice";
            // 
            // TheoUpDown
            // 
            TheoUpDown.Location = new Point(204, 107);
            TheoUpDown.Name = "TheoUpDown";
            TheoUpDown.Size = new Size(100, 27);
            TheoUpDown.TabIndex = 24;
            // 
            // CredUpDown
            // 
            CredUpDown.Location = new Point(79, 108);
            CredUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CredUpDown.Name = "CredUpDown";
            CredUpDown.Size = new Size(100, 27);
            CredUpDown.TabIndex = 23;
            CredUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(204, 81);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 22;
            label7.Text = "Theory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(79, 81);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 21;
            label6.Text = "Credit";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(522, 155);
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
            UpdateButton.Location = new Point(397, 155);
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
            AddButton.Location = new Point(272, 155);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 40);
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
            label3.Location = new Point(204, 25);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(79, 25);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 5;
            label2.Text = "Course ID";
            // 
            // CrsIDBox
            // 
            CrsIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsIDBox.Location = new Point(79, 51);
            CrsIDBox.Name = "CrsIDBox";
            CrsIDBox.PlaceholderText = "Course ID";
            CrsIDBox.Size = new Size(100, 27);
            CrsIDBox.TabIndex = 4;
            // 
            // CrsNameBox
            // 
            CrsNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsNameBox.Location = new Point(204, 51);
            CrsNameBox.Name = "CrsNameBox";
            CrsNameBox.PlaceholderText = "Course Name";
            CrsNameBox.Size = new Size(350, 27);
            CrsNameBox.TabIndex = 3;
            // 
            // CourseManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseManager";
            Text = "CourseManager";
            Load += CourseManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrsData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UnitIDUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxStuUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PracUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TheoUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CredUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button UpdateButton;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private TextBox CrsIDBox;
        private TextBox CrsNameBox;
        private Label label1;
        private DataGridView CrsData;
        private Button RefreshButton;
        private Label label6;
        private Label label7;
        private NumericUpDown CredUpDown;
        private NumericUpDown UnitIDUpDown;
        private Label label8;
        private NumericUpDown MaxStuUpDown;
        private Label label5;
        private NumericUpDown PracUpDown;
        private Label label4;
        private NumericUpDown TheoUpDown;
        private Label label9;
        private ComboBox UnitNameCbo;
    }
}