namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            panel1 = new Panel();
            label11 = new Label();
            UnitCbo = new ComboBox();
            label12 = new Label();
            RoleCbo = new ComboBox();
            label10 = new Label();
            AllowanceUpDown = new NumericUpDown();
            label9 = new Label();
            EmpIDBox = new TextBox();
            label3 = new Label();
            FacilityCbo = new ComboBox();
            EmpNameBox = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            CancelButton = new Button();
            insertButton = new Button();
            GenderCbo = new ComboBox();
            bdayBox = new DateTimePicker();
            label1 = new Label();
            PhoneBox = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(UnitCbo);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(RoleCbo);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(AllowanceUpDown);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpIDBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FacilityCbo);
            panel1.Controls.Add(EmpNameBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(GenderCbo);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PhoneBox);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 453);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(415, 274);
            label11.Name = "label11";
            label11.Size = new Size(40, 23);
            label11.TabIndex = 51;
            label11.Text = "Unit";
            // 
            // UnitCbo
            // 
            UnitCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitCbo.FormattingEnabled = true;
            UnitCbo.Location = new Point(415, 300);
            UnitCbo.Name = "UnitCbo";
            UnitCbo.Size = new Size(176, 27);
            UnitCbo.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(91, 273);
            label12.Name = "label12";
            label12.Size = new Size(44, 23);
            label12.TabIndex = 49;
            label12.Text = "Role";
            // 
            // RoleCbo
            // 
            RoleCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCbo.FormattingEnabled = true;
            RoleCbo.Location = new Point(91, 299);
            RoleCbo.Name = "RoleCbo";
            RoleCbo.Size = new Size(303, 27);
            RoleCbo.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(189, 208);
            label10.Name = "label10";
            label10.Size = new Size(91, 23);
            label10.TabIndex = 47;
            label10.Text = "Allowance";
            // 
            // AllowanceUpDown
            // 
            AllowanceUpDown.Location = new Point(189, 234);
            AllowanceUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AllowanceUpDown.Name = "AllowanceUpDown";
            AllowanceUpDown.Size = new Size(91, 27);
            AllowanceUpDown.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(266, 72);
            label9.Name = "label9";
            label9.Size = new Size(109, 23);
            label9.TabIndex = 45;
            label9.Text = "Employee ID";
            // 
            // EmpIDBox
            // 
            EmpIDBox.CharacterCasing = CharacterCasing.Upper;
            EmpIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpIDBox.Location = new Point(266, 98);
            EmpIDBox.Name = "EmpIDBox";
            EmpIDBox.PlaceholderText = "Employee ID";
            EmpIDBox.Size = new Size(150, 27);
            EmpIDBox.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(310, 208);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 43;
            label3.Text = "Facility";
            // 
            // FacilityCbo
            // 
            FacilityCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FacilityCbo.FormattingEnabled = true;
            FacilityCbo.Location = new Point(310, 234);
            FacilityCbo.Name = "FacilityCbo";
            FacilityCbo.Size = new Size(106, 27);
            FacilityCbo.TabIndex = 42;
            // 
            // EmpNameBox
            // 
            EmpNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameBox.Location = new Point(91, 164);
            EmpNameBox.Name = "EmpNameBox";
            EmpNameBox.PlaceholderText = "Employee Name";
            EmpNameBox.Size = new Size(325, 27);
            EmpNameBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(91, 208);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 35;
            label6.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(201, 18);
            label2.Name = "label2";
            label2.Size = new Size(280, 43);
            label2.TabIndex = 36;
            label2.Text = "Add New Student";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(441, 208);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 37;
            label7.Text = "Phone Number";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.SteelBlue;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(391, 358);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(200, 50);
            CancelButton.TabIndex = 35;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(91, 358);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(200, 50);
            insertButton.TabIndex = 34;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // GenderCbo
            // 
            GenderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCbo.FormattingEnabled = true;
            GenderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            GenderCbo.Location = new Point(91, 234);
            GenderCbo.Name = "GenderCbo";
            GenderCbo.Size = new Size(75, 27);
            GenderCbo.TabIndex = 34;
            GenderCbo.Text = "NAM";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "dd-MM-yyyy";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(441, 164);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(150, 27);
            bdayBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(91, 138);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 30;
            label1.Text = "Employee Name";
            // 
            // PhoneBox
            // 
            PhoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneBox.Location = new Point(441, 234);
            PhoneBox.MaxLength = 11;
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = "Phone Number";
            PhoneBox.Size = new Size(150, 27);
            PhoneBox.TabIndex = 36;
            PhoneBox.KeyPress += PhoneBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(441, 138);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 33;
            label5.Text = "Date of birth";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            Load += AddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox PhoneBox;
        private Label label6;
        private ComboBox GenderCbo;
        private Label label5;
        private Label label1;
        private DateTimePicker bdayBox;
        private TextBox EmpNameBox;
        private new Button CancelButton;
        private Button insertButton;
        private Label label2;
        private Label label3;
        private ComboBox FacilityCbo;
        private Label label9;
        private NumericUpDown AllowanceUpDown;
        private Label label10;
        private Label label11;
        private ComboBox UnitCbo;
        private Label label12;
        private ComboBox RoleCbo;
        internal TextBox EmpIDBox;
    }
}