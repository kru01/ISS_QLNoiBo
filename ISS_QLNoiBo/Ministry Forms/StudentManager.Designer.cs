namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class StudentManager
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
            refreshButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            label2 = new Label();
            studentData = new DataGridView();
            panel2 = new Panel();
            label = new Label();
            programCbo = new ComboBox();
            label8 = new Label();
            majorCbo = new ComboBox();
            label7 = new Label();
            phoneBox = new TextBox();
            label6 = new Label();
            genderCbo = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            studentID = new TextBox();
            label1 = new Label();
            bdayBox = new DateTimePicker();
            label4 = new Label();
            addressBox = new TextBox();
            studentName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(studentData);
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
            refreshButton.Location = new Point(237, 309);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 19;
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
            updateButton.Location = new Point(131, 309);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 40);
            updateButton.TabIndex = 17;
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
            insertButton.Location = new Point(25, 309);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(378, 10);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 7;
            label2.Text = "Student List";
            // 
            // studentData
            // 
            studentData.AllowUserToAddRows = false;
            studentData.AllowUserToDeleteRows = false;
            studentData.AllowUserToResizeColumns = false;
            studentData.AllowUserToResizeRows = false;
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            studentData.BorderStyle = BorderStyle.None;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Dock = DockStyle.Bottom;
            studentData.Location = new Point(0, 354);
            studentData.Name = "studentData";
            studentData.ReadOnly = true;
            studentData.RowHeadersVisible = false;
            studentData.RowHeadersWidth = 51;
            studentData.Size = new Size(904, 350);
            studentData.TabIndex = 0;
            studentData.CellClick += studentData_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label);
            panel2.Controls.Add(programCbo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(majorCbo);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(phoneBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(genderCbo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(studentID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(bdayBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addressBox);
            panel2.Controls.Add(studentName);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 275);
            panel2.TabIndex = 8;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(274, 109);
            label.Name = "label";
            label.Size = new Size(79, 23);
            label.TabIndex = 25;
            label.Text = "Program";
            // 
            // programCbo
            // 
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            programCbo.Location = new Point(274, 135);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(75, 27);
            programCbo.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(376, 109);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 23;
            label8.Text = "Major";
            // 
            // majorCbo
            // 
            majorCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            majorCbo.FormattingEnabled = true;
            majorCbo.Items.AddRange(new object[] { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" });
            majorCbo.Location = new Point(376, 135);
            majorCbo.Name = "majorCbo";
            majorCbo.Size = new Size(125, 27);
            majorCbo.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(526, 109);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 21;
            label7.Text = "Phone Number";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(526, 135);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone Number";
            phoneBox.Size = new Size(150, 27);
            phoneBox.TabIndex = 20;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(176, 109);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 19;
            label6.Text = "Gender";
            // 
            // genderCbo
            // 
            genderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCbo.FormattingEnabled = true;
            genderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            genderCbo.Location = new Point(176, 135);
            genderCbo.Name = "genderCbo";
            genderCbo.Size = new Size(75, 27);
            genderCbo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(274, 39);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 17;
            label5.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(176, 39);
            label3.Name = "label3";
            label3.Size = new Size(26, 23);
            label3.TabIndex = 16;
            label3.Text = "ID";
            // 
            // studentID
            // 
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(176, 65);
            studentID.Name = "studentID";
            studentID.PlaceholderText = "ID";
            studentID.ReadOnly = true;
            studentID.Size = new Size(75, 27);
            studentID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(426, 39);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 14;
            label1.Text = "Student Name";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Enabled = false;
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(274, 65);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(125, 27);
            bdayBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(176, 174);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(176, 200);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(500, 27);
            addressBox.TabIndex = 1;
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(426, 65);
            studentName.Name = "studentName";
            studentName.PlaceholderText = "Student Name";
            studentName.Size = new Size(250, 27);
            studentName.TabIndex = 0;
            // 
            // StudentManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentManager";
            Text = "StudentManager";
            Load += StudentManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView studentData;
        private Panel panel2;
        private TextBox studentName;
        private Button updateButton;
        private Button insertButton;
        private TextBox addressBox;
        private Label label4;
        private DateTimePicker bdayBox;
        private TextBox studentID;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label6;
        private ComboBox genderCbo;
        private Label label7;
        private TextBox phoneBox;
        private ComboBox majorCbo;
        private Label label;
        private ComboBox programCbo;
        private Label label8;
        private Button refreshButton;
    }
}