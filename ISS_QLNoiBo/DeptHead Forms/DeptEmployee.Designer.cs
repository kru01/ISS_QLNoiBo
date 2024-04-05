namespace ISS_QLNoiBo.DeptHead_Forms
{
    partial class DeptEmployee
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
            RefreshButton = new Button();
            DeleteButton = new Button();
            InsertButton = new Button();
            UpdateButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            BranchCbo = new ComboBox();
            label9 = new Label();
            UnitCbo = new ComboBox();
            label8 = new Label();
            PhoneBox = new TextBox();
            label7 = new Label();
            AllowanceUpDown = new NumericUpDown();
            label3 = new Label();
            BirthDateTime = new DateTimePicker();
            label2 = new Label();
            EmpIDBox = new TextBox();
            EmpNameBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            GenderCbo = new ComboBox();
            RoleCbo = new ComboBox();
            EmpData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(InsertButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(EmpData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(343, 260);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(100, 40);
            RefreshButton.TabIndex = 19;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SteelBlue;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(131, 260);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 40);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = Color.SteelBlue;
            InsertButton.FlatAppearance.BorderSize = 0;
            InsertButton.FlatStyle = FlatStyle.Flat;
            InsertButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsertButton.ForeColor = Color.White;
            InsertButton.Location = new Point(25, 260);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(100, 40);
            InsertButton.TabIndex = 17;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.SteelBlue;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(237, 260);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 40);
            UpdateButton.TabIndex = 16;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(326, 10);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 3;
            label1.Text = "Employee Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(BranchCbo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(UnitCbo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(PhoneBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(AllowanceUpDown);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BirthDateTime);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(EmpIDBox);
            panel2.Controls.Add(EmpNameBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(GenderCbo);
            panel2.Controls.Add(RoleCbo);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 225);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(661, 123);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 33;
            label10.Text = "Facility";
            // 
            // BranchCbo
            // 
            BranchCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchCbo.FormattingEnabled = true;
            BranchCbo.Location = new Point(661, 149);
            BranchCbo.Name = "BranchCbo";
            BranchCbo.Size = new Size(131, 27);
            BranchCbo.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(461, 124);
            label9.Name = "label9";
            label9.Size = new Size(40, 23);
            label9.TabIndex = 31;
            label9.Text = "Unit";
            // 
            // UnitCbo
            // 
            UnitCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitCbo.FormattingEnabled = true;
            UnitCbo.Location = new Point(461, 149);
            UnitCbo.Name = "UnitCbo";
            UnitCbo.Size = new Size(176, 27);
            UnitCbo.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(58, 123);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 29;
            label8.Text = "Phone Number";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(58, 149);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = "Phone Number";
            PhoneBox.Size = new Size(109, 27);
            PhoneBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(701, 33);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 27;
            label7.Text = "Allowance";
            // 
            // AllowanceUpDown
            // 
            AllowanceUpDown.Location = new Point(701, 59);
            AllowanceUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AllowanceUpDown.Name = "AllowanceUpDown";
            AllowanceUpDown.Size = new Size(91, 27);
            AllowanceUpDown.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(555, 33);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 25;
            label3.Text = "Birthdate";
            // 
            // BirthDateTime
            // 
            BirthDateTime.CustomFormat = "dd/MM/yyyy";
            BirthDateTime.Format = DateTimePickerFormat.Custom;
            BirthDateTime.Location = new Point(555, 59);
            BirthDateTime.Name = "BirthDateTime";
            BirthDateTime.Size = new Size(124, 27);
            BirthDateTime.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(58, 33);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 23;
            label2.Text = "Employee ID";
            // 
            // EmpIDBox
            // 
            EmpIDBox.Location = new Point(58, 59);
            EmpIDBox.Name = "EmpIDBox";
            EmpIDBox.PlaceholderText = "Employee ID";
            EmpIDBox.ReadOnly = true;
            EmpIDBox.Size = new Size(109, 27);
            EmpIDBox.TabIndex = 22;
            // 
            // EmpNameBox
            // 
            EmpNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameBox.Location = new Point(189, 59);
            EmpNameBox.Name = "EmpNameBox";
            EmpNameBox.PlaceholderText = "Employee Name";
            EmpNameBox.Size = new Size(250, 27);
            EmpNameBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(461, 34);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 20;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(189, 124);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 17;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(189, 34);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 16;
            label6.Text = "Employee Name";
            // 
            // GenderCbo
            // 
            GenderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCbo.FormattingEnabled = true;
            GenderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            GenderCbo.Location = new Point(461, 59);
            GenderCbo.Name = "GenderCbo";
            GenderCbo.Size = new Size(72, 27);
            GenderCbo.TabIndex = 15;
            // 
            // RoleCbo
            // 
            RoleCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCbo.FormattingEnabled = true;
            RoleCbo.Location = new Point(189, 150);
            RoleCbo.Name = "RoleCbo";
            RoleCbo.Size = new Size(250, 27);
            RoleCbo.TabIndex = 12;
            // 
            // EmpData
            // 
            EmpData.AllowUserToAddRows = false;
            EmpData.AllowUserToDeleteRows = false;
            EmpData.AllowUserToResizeColumns = false;
            EmpData.AllowUserToResizeRows = false;
            EmpData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmpData.BorderStyle = BorderStyle.None;
            EmpData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpData.Dock = DockStyle.Bottom;
            EmpData.Location = new Point(0, 304);
            EmpData.Name = "EmpData";
            EmpData.ReadOnly = true;
            EmpData.RowHeadersVisible = false;
            EmpData.RowHeadersWidth = 51;
            EmpData.Size = new Size(904, 400);
            EmpData.TabIndex = 0;
            EmpData.CellClick += EmpData_CellClick;
            // 
            // DeptEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeptEmployee";
            Text = "DeptEmployee";
            Load += DeptEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button RefreshButton;
        private Button DeleteButton;
        private Button InsertButton;
        private Button UpdateButton;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox GenderCbo;
        private ComboBox RoleCbo;
        private DataGridView EmpData;
        private TextBox EmpNameBox;
        private TextBox EmpIDBox;
        private Label label2;
        private DateTimePicker BirthDateTime;
        private Label label3;
        private NumericUpDown AllowanceUpDown;
        private Label label7;
        private TextBox PhoneBox;
        private Label label8;
        private ComboBox BranchCbo;
        private Label label9;
        private ComboBox UnitCbo;
        private Label label10;
    }
}