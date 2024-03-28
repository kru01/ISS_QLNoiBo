namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label9 = new Label();
            studentID = new TextBox();
            label3 = new Label();
            facilityCbo = new ComboBox();
            studentName = new TextBox();
            label6 = new Label();
            label = new Label();
            label2 = new Label();
            label8 = new Label();
            programCbo = new ComboBox();
            label7 = new Label();
            cancelButton = new Button();
            insertButton = new Button();
            label4 = new Label();
            genderCbo = new ComboBox();
            addressBox = new TextBox();
            majorCbo = new ComboBox();
            bdayBox = new DateTimePicker();
            label1 = new Label();
            phoneBox = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(studentID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(facilityCbo);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(programCbo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(genderCbo);
            panel1.Controls.Add(addressBox);
            panel1.Controls.Add(majorCbo);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 453);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(266, 72);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 45;
            label9.Text = "Student ID";
            // 
            // studentID
            // 
            studentID.CharacterCasing = CharacterCasing.Upper;
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(266, 98);
            studentID.Name = "studentID";
            studentID.PlaceholderText = "Student ID";
            studentID.Size = new Size(150, 27);
            studentID.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(366, 138);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 43;
            label3.Text = "Facility";
            // 
            // facilityCbo
            // 
            facilityCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facilityCbo.FormattingEnabled = true;
            facilityCbo.Items.AddRange(new object[] { "1", "2" });
            facilityCbo.Location = new Point(366, 164);
            facilityCbo.Name = "facilityCbo";
            facilityCbo.Size = new Size(50, 27);
            facilityCbo.TabIndex = 42;
            facilityCbo.Text = "1";
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(91, 164);
            studentName.Name = "studentName";
            studentName.PlaceholderText = "Student Name";
            studentName.Size = new Size(250, 27);
            studentName.TabIndex = 26;
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
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.White;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(189, 208);
            label.Name = "label";
            label.Size = new Size(79, 23);
            label.TabIndex = 41;
            label.Text = "Program";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(291, 208);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 39;
            label8.Text = "Major";
            // 
            // programCbo
            // 
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            programCbo.Location = new Point(189, 234);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(75, 27);
            programCbo.TabIndex = 40;
            programCbo.Text = "CQ";
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
            // cancelButton
            // 
            cancelButton.BackColor = Color.SteelBlue;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(391, 358);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(91, 273);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 28;
            label4.Text = "Address";
            // 
            // genderCbo
            // 
            genderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCbo.FormattingEnabled = true;
            genderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            genderCbo.Location = new Point(91, 234);
            genderCbo.Name = "genderCbo";
            genderCbo.Size = new Size(75, 27);
            genderCbo.TabIndex = 34;
            genderCbo.Text = "NAM";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(91, 299);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(500, 27);
            addressBox.TabIndex = 27;
            // 
            // majorCbo
            // 
            majorCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            majorCbo.FormattingEnabled = true;
            majorCbo.Items.AddRange(new object[] { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" });
            majorCbo.Location = new Point(291, 234);
            majorCbo.Name = "majorCbo";
            majorCbo.Size = new Size(125, 27);
            majorCbo.TabIndex = 38;
            majorCbo.Text = "HTTT";
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
            label1.Size = new Size(122, 23);
            label1.TabIndex = 30;
            label1.Text = "Student Name";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(441, 234);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone Number";
            phoneBox.Size = new Size(150, 27);
            phoneBox.TabIndex = 36;
            phoneBox.KeyPress += phoneBox_KeyPress;
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
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label;
        private ComboBox programCbo;
        private Label label8;
        private ComboBox majorCbo;
        private Label label7;
        private TextBox phoneBox;
        private Label label6;
        private ComboBox genderCbo;
        private Label label5;
        private Label label1;
        private DateTimePicker bdayBox;
        private Label label4;
        private TextBox addressBox;
        private TextBox studentName;
        private Button cancelButton;
        private Button insertButton;
        private Label label2;
        private Label label3;
        private ComboBox facilityCbo;
        private Label label9;
        public TextBox studentID;
    }
}