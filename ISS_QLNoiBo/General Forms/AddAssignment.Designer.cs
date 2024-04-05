namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    partial class AddAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAssignment));
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            UnitCheck = new CheckBox();
            progCbo = new ComboBox();
            yearUpDown = new NumericUpDown();
            label3 = new Label();
            cancelButton = new Button();
            label4 = new Label();
            insertButton = new Button();
            semUpDown = new NumericUpDown();
            courseID = new TextBox();
            RefreshButton = new Button();
            label7 = new Label();
            label6 = new Label();
            unitNameBox = new TextBox();
            label5 = new Label();
            unitIDBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lecturerID = new TextBox();
            KhmoData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KhmoData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(KhmoData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 677);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(319, 9);
            label8.Name = "label8";
            label8.Size = new Size(269, 35);
            label8.TabIndex = 48;
            label8.Text = "Add New Assignment";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(UnitCheck);
            panel2.Controls.Add(progCbo);
            panel2.Controls.Add(yearUpDown);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(insertButton);
            panel2.Controls.Add(semUpDown);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(unitNameBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(unitIDBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lecturerID);
            panel2.Location = new Point(12, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 175);
            panel2.TabIndex = 47;
            // 
            // UnitCheck
            // 
            UnitCheck.AutoSize = true;
            UnitCheck.Checked = true;
            UnitCheck.CheckState = CheckState.Checked;
            UnitCheck.Location = new Point(413, 109);
            UnitCheck.Name = "UnitCheck";
            UnitCheck.Size = new Size(109, 44);
            UnitCheck.TabIndex = 47;
            UnitCheck.Text = "Show only\r\nrelated Unit";
            UnitCheck.UseVisualStyleBackColor = true;
            UnitCheck.CheckedChanged += UnitCheck_CheckedChanged;
            // 
            // progCbo
            // 
            progCbo.Enabled = false;
            progCbo.FormattingEnabled = true;
            progCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            progCbo.Location = new Point(684, 61);
            progCbo.Name = "progCbo";
            progCbo.Size = new Size(100, 28);
            progCbo.TabIndex = 46;
            progCbo.Text = "CQ";
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(549, 62);
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
            label3.Location = new Point(684, 100);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 44;
            label3.Text = "Unit Name";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.SteelBlue;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(170, 111);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 40);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(549, 100);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 43;
            label4.Text = "Unit ID";
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 13.8F);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(58, 111);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 34;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(413, 62);
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
            courseID.Location = new Point(233, 62);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(150, 27);
            courseID.TabIndex = 41;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(283, 111);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(100, 40);
            RefreshButton.TabIndex = 40;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(684, 36);
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
            label6.Location = new Point(549, 36);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 36;
            label6.Text = "Year";
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(685, 126);
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
            label5.Location = new Point(412, 36);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 33;
            label5.Text = "Semester";
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(549, 126);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.PlaceholderText = "Unit ID";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(100, 27);
            unitIDBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(233, 36);
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
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 27;
            label1.Text = "Lecturer ID";
            // 
            // lecturerID
            // 
            lecturerID.CharacterCasing = CharacterCasing.Upper;
            lecturerID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerID.Location = new Point(58, 62);
            lecturerID.Name = "lecturerID";
            lecturerID.PlaceholderText = "Lecturer ID";
            lecturerID.Size = new Size(151, 27);
            lecturerID.TabIndex = 25;
            // 
            // KhmoData
            // 
            KhmoData.AllowUserToAddRows = false;
            KhmoData.AllowUserToDeleteRows = false;
            KhmoData.AllowUserToResizeColumns = false;
            KhmoData.AllowUserToResizeRows = false;
            KhmoData.BorderStyle = BorderStyle.None;
            KhmoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KhmoData.Dock = DockStyle.Bottom;
            KhmoData.Location = new Point(0, 227);
            KhmoData.Name = "KhmoData";
            KhmoData.ReadOnly = true;
            KhmoData.RowHeadersVisible = false;
            KhmoData.RowHeadersWidth = 51;
            KhmoData.Size = new Size(906, 450);
            KhmoData.TabIndex = 1;
            KhmoData.CellClick += KhmoData_CellClick;
            // 
            // AddAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 677);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Assignment";
            Load += AddAssignment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)KhmoData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelButton;
        private Button insertButton;
        private DataGridView KhmoData;
        private Label label8;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button RefreshButton;
        private Label label7;
        private Label label6;
        private TextBox unitNameBox;
        private Label label5;
        private TextBox unitIDBox;
        private Label label2;
        private Label label1;
        private CheckBox UnitCheck;
        internal TextBox lecturerID;
        internal TextBox courseID;
        internal NumericUpDown semUpDown;
        internal NumericUpDown yearUpDown;
        internal ComboBox progCbo;
    }
}