namespace ISS_QLNoiBo.Admin_Forms
{
    partial class GrantSysPriv
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
            gridData = new DataGridView();
            label1 = new Label();
            privilagesPanel = new Panel();
            button3 = new Button();
            adminOptBox = new CheckBox();
            button1 = new Button();
            sysPrivilegedBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            createUButton = new Button();
            username1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            privilagesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gridData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // gridData
            // 
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToDeleteRows = false;
            gridData.AllowUserToResizeColumns = false;
            gridData.AllowUserToResizeRows = false;
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridData.BorderStyle = BorderStyle.None;
            gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridData.Dock = DockStyle.Bottom;
            gridData.Location = new Point(0, 368);
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.RowHeadersVisible = false;
            gridData.RowHeadersWidth = 51;
            gridData.Size = new Size(904, 336);
            gridData.TabIndex = 8;
            gridData.CellClick += gridData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(341, 20);
            label1.Name = "label1";
            label1.Size = new Size(222, 35);
            label1.TabIndex = 7;
            label1.Text = "System Privileges";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(button3);
            privilagesPanel.Controls.Add(adminOptBox);
            privilagesPanel.Controls.Add(button1);
            privilagesPanel.Controls.Add(sysPrivilegedBox);
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(createUButton);
            privilagesPanel.Controls.Add(username1);
            privilagesPanel.Location = new Point(250, 40);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(404, 304);
            privilagesPanel.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(286, 215);
            button3.Name = "button3";
            button3.Size = new Size(80, 40);
            button3.TabIndex = 7;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // adminOptBox
            // 
            adminOptBox.AutoSize = true;
            adminOptBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminOptBox.Location = new Point(50, 171);
            adminOptBox.Name = "adminOptBox";
            adminOptBox.Size = new Size(163, 23);
            adminOptBox.TabIndex = 19;
            adminOptBox.Text = "With admin option";
            adminOptBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 215);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 18;
            button1.Text = "Revoke";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sysPrivilegedBox
            // 
            sysPrivilegedBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sysPrivilegedBox.FormattingEnabled = true;
            sysPrivilegedBox.Location = new Point(50, 130);
            sysPrivilegedBox.Name = "sysPrivilegedBox";
            sysPrivilegedBox.Size = new Size(316, 27);
            sysPrivilegedBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(50, 104);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 5;
            label4.Text = "System privileges";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(50, 34);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 4;
            label3.Text = "User/Role";
            // 
            // createUButton
            // 
            createUButton.BackColor = Color.SteelBlue;
            createUButton.FlatAppearance.BorderSize = 0;
            createUButton.FlatStyle = FlatStyle.Flat;
            createUButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createUButton.ForeColor = Color.White;
            createUButton.Location = new Point(50, 215);
            createUButton.Name = "createUButton";
            createUButton.Size = new Size(80, 40);
            createUButton.TabIndex = 2;
            createUButton.Text = "Grant";
            createUButton.UseVisualStyleBackColor = false;
            createUButton.Click += createUButton_Click;
            // 
            // username1
            // 
            username1.CharacterCasing = CharacterCasing.Upper;
            username1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username1.Location = new Point(50, 60);
            username1.Name = "username1";
            username1.PlaceholderText = "Enter user/role name";
            username1.Size = new Size(316, 27);
            username1.TabIndex = 0;
            // 
            // GrantSysPriv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GrantSysPriv";
            Text = "SysPrivileges";
            Load += GrantSysPriv_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel privilagesPanel;
        private Label label4;
        private Label label3;
        private Button createUButton;
        private TextBox username1;
        private ComboBox sysPrivilegedBox;
        private Button button1;
        private CheckBox adminOptBox;
        private DataGridView gridData;
        private Button button3;
    }
}