namespace ISS_QLNoiBo.Admin_Forms
{
    partial class InspectAudit
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
            label1 = new Label();
            privilagesPanel = new Panel();
            ExSysDBCkbo = new CheckBox();
            scnBox = new TextBox();
            userBox = new TextBox();
            label4 = new Label();
            RefreshButton = new Button();
            label2 = new Label();
            sqlTextBox = new TextBox();
            label3 = new Label();
            ViewButton = new Button();
            AuditData = new DataGridView();
            panel1.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AuditData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(AuditData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 35);
            label1.TabIndex = 3;
            label1.Text = "Inspect Audit Trail";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(ExSysDBCkbo);
            privilagesPanel.Controls.Add(scnBox);
            privilagesPanel.Controls.Add(userBox);
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(RefreshButton);
            privilagesPanel.Controls.Add(label2);
            privilagesPanel.Controls.Add(sqlTextBox);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(ViewButton);
            privilagesPanel.Location = new Point(50, 52);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(804, 180);
            privilagesPanel.TabIndex = 4;
            // 
            // ExSysDBCkbo
            // 
            ExSysDBCkbo.AutoSize = true;
            ExSysDBCkbo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ExSysDBCkbo.Location = new Point(244, 119);
            ExSysDBCkbo.Name = "ExSysDBCkbo";
            ExSysDBCkbo.Size = new Size(125, 38);
            ExSysDBCkbo.TabIndex = 16;
            ExSysDBCkbo.Text = "Exclude SYS and\r\nA01_QLNOIBO";
            ExSysDBCkbo.UseVisualStyleBackColor = true;
            // 
            // scnBox
            // 
            scnBox.Location = new Point(142, 72);
            scnBox.Name = "scnBox";
            scnBox.ReadOnly = true;
            scnBox.Size = new Size(180, 27);
            scnBox.TabIndex = 15;
            // 
            // userBox
            // 
            userBox.Location = new Point(142, 20);
            userBox.Name = "userBox";
            userBox.Size = new Size(180, 27);
            userBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(375, 22);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 12;
            label4.Text = "SQL";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(142, 118);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(80, 40);
            RefreshButton.TabIndex = 9;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 8;
            label2.Text = "SCN";
            // 
            // sqlTextBox
            // 
            sqlTextBox.AcceptsReturn = true;
            sqlTextBox.AcceptsTab = true;
            sqlTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sqlTextBox.Location = new Point(375, 48);
            sqlTextBox.Multiline = true;
            sqlTextBox.Name = "sqlTextBox";
            sqlTextBox.PlaceholderText = "SQL Text...";
            sqlTextBox.ReadOnly = true;
            sqlTextBox.Size = new Size(390, 111);
            sqlTextBox.TabIndex = 7;
            sqlTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(40, 22);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // ViewButton
            // 
            ViewButton.BackColor = Color.SteelBlue;
            ViewButton.FlatAppearance.BorderSize = 0;
            ViewButton.FlatStyle = FlatStyle.Flat;
            ViewButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewButton.ForeColor = Color.White;
            ViewButton.Location = new Point(40, 119);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(80, 40);
            ViewButton.TabIndex = 2;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // AuditData
            // 
            AuditData.AllowUserToAddRows = false;
            AuditData.AllowUserToDeleteRows = false;
            AuditData.AllowUserToResizeColumns = false;
            AuditData.AllowUserToResizeRows = false;
            AuditData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AuditData.BorderStyle = BorderStyle.None;
            AuditData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuditData.Dock = DockStyle.Bottom;
            AuditData.Location = new Point(0, 254);
            AuditData.Name = "AuditData";
            AuditData.ReadOnly = true;
            AuditData.RowHeadersVisible = false;
            AuditData.RowHeadersWidth = 51;
            AuditData.Size = new Size(904, 450);
            AuditData.TabIndex = 1;
            AuditData.CellClick += AnnData_CellClick;
            // 
            // InspectAudit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InspectAudit";
            Text = "RoleTab";
            Load += Announcement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AuditData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel privilagesPanel;
        private Label label1;
        private Label label3;
        private Button ViewButton;
        private DataGridView AuditData;
        private Button RefreshButton;
        private TextBox sqlTextBox;
        private Label label4;
        private TextBox userBox;
        private TextBox scnBox;
        private Label label2;
        private CheckBox ExSysDBCkbo;
    }
}