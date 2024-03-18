namespace ISS_QLNoiBo.Admin_Forms
{
    partial class Privileges
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
            button1 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            tableCboBox = new ComboBox();
            label7 = new Label();
            columnBox = new TextBox();
            grantOptBox = new CheckBox();
            updateBox = new CheckBox();
            deleteBox = new CheckBox();
            selectBox = new CheckBox();
            insertBox = new CheckBox();
            revoke2Button = new Button();
            grant2Button = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            privilagesPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            revoke1Button = new Button();
            grant1Button = new Button();
            role1 = new TextBox();
            username1 = new TextBox();
            usersData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(usersData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(407, 322);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(483, 32);
            label2.Name = "label2";
            label2.Size = new Size(262, 27);
            label2.TabIndex = 6;
            label2.Text = "Edit user privilege on table";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableCboBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(columnBox);
            panel2.Controls.Add(grantOptBox);
            panel2.Controls.Add(updateBox);
            panel2.Controls.Add(deleteBox);
            panel2.Controls.Add(selectBox);
            panel2.Controls.Add(insertBox);
            panel2.Controls.Add(revoke2Button);
            panel2.Controls.Add(grant2Button);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(374, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 275);
            panel2.TabIndex = 5;
            // 
            // tableCboBox
            // 
            tableCboBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCboBox.FormattingEnabled = true;
            tableCboBox.Items.AddRange(new object[] { "COSO", "CTDAOTAO", "DANGKY", "DONVI", "HOCPHAN", "KHMO", "NGANH", "NHANSU", "PHANCONG", "SINHVIEN", "THONGBAO", "VAITRO" });
            tableCboBox.Location = new Point(50, 130);
            tableCboBox.Name = "tableCboBox";
            tableCboBox.Size = new Size(200, 27);
            tableCboBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(50, 174);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 15;
            label7.Text = "Column";
            // 
            // columnBox
            // 
            columnBox.CharacterCasing = CharacterCasing.Upper;
            columnBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            columnBox.Location = new Point(50, 200);
            columnBox.Name = "columnBox";
            columnBox.PlaceholderText = "C1,C2,C3,...";
            columnBox.Size = new Size(200, 27);
            columnBox.TabIndex = 14;
            // 
            // grantOptBox
            // 
            grantOptBox.AutoSize = true;
            grantOptBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grantOptBox.Location = new Point(275, 130);
            grantOptBox.Name = "grantOptBox";
            grantOptBox.Size = new Size(156, 23);
            grantOptBox.TabIndex = 13;
            grantOptBox.Text = "With grant option";
            grantOptBox.UseVisualStyleBackColor = true;
            // 
            // updateBox
            // 
            updateBox.AutoSize = true;
            updateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBox.Location = new Point(275, 95);
            updateBox.Name = "updateBox";
            updateBox.Size = new Size(82, 23);
            updateBox.TabIndex = 12;
            updateBox.Text = "Update";
            updateBox.UseVisualStyleBackColor = true;
            // 
            // deleteBox
            // 
            deleteBox.AutoSize = true;
            deleteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBox.Location = new Point(375, 95);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(77, 23);
            deleteBox.TabIndex = 11;
            deleteBox.Text = "Delete";
            deleteBox.UseVisualStyleBackColor = true;
            // 
            // selectBox
            // 
            selectBox.AutoSize = true;
            selectBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectBox.Location = new Point(375, 60);
            selectBox.Name = "selectBox";
            selectBox.Size = new Size(76, 23);
            selectBox.TabIndex = 10;
            selectBox.Text = "Select";
            selectBox.UseVisualStyleBackColor = true;
            // 
            // insertBox
            // 
            insertBox.AutoSize = true;
            insertBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertBox.Location = new Point(275, 60);
            insertBox.Name = "insertBox";
            insertBox.Size = new Size(72, 23);
            insertBox.TabIndex = 9;
            insertBox.Text = "Insert";
            insertBox.UseVisualStyleBackColor = true;
            // 
            // revoke2Button
            // 
            revoke2Button.BackColor = Color.SteelBlue;
            revoke2Button.FlatAppearance.BorderSize = 0;
            revoke2Button.FlatStyle = FlatStyle.Flat;
            revoke2Button.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revoke2Button.ForeColor = Color.White;
            revoke2Button.Location = new Point(371, 193);
            revoke2Button.Name = "revoke2Button";
            revoke2Button.Size = new Size(80, 40);
            revoke2Button.TabIndex = 6;
            revoke2Button.Text = "Revoke";
            revoke2Button.UseVisualStyleBackColor = false;
            revoke2Button.Click += revoke2Button_Click;
            // 
            // grant2Button
            // 
            grant2Button.BackColor = Color.SteelBlue;
            grant2Button.FlatAppearance.BorderSize = 0;
            grant2Button.FlatStyle = FlatStyle.Flat;
            grant2Button.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grant2Button.ForeColor = Color.White;
            grant2Button.Location = new Point(275, 193);
            grant2Button.Name = "grant2Button";
            grant2Button.Size = new Size(80, 40);
            grant2Button.TabIndex = 6;
            grant2Button.Text = "Grant";
            grant2Button.UseVisualStyleBackColor = false;
            grant2Button.Click += grant2Button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(51, 104);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 6;
            label6.Text = "Table";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(50, 34);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 6;
            label5.Text = "User/Role";
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(50, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(131, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 3;
            label1.Text = "Edit user role";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(revoke1Button);
            privilagesPanel.Controls.Add(grant1Button);
            privilagesPanel.Controls.Add(role1);
            privilagesPanel.Controls.Add(username1);
            privilagesPanel.Location = new Point(50, 45);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(300, 275);
            privilagesPanel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(50, 104);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 5;
            label4.Text = "Role Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(50, 34);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 4;
            label3.Text = "User Name";
            // 
            // revoke1Button
            // 
            revoke1Button.BackColor = Color.SteelBlue;
            revoke1Button.FlatAppearance.BorderSize = 0;
            revoke1Button.FlatStyle = FlatStyle.Flat;
            revoke1Button.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revoke1Button.ForeColor = Color.White;
            revoke1Button.Location = new Point(160, 193);
            revoke1Button.Name = "revoke1Button";
            revoke1Button.Size = new Size(90, 40);
            revoke1Button.TabIndex = 3;
            revoke1Button.Text = "Revoke";
            revoke1Button.UseVisualStyleBackColor = false;
            revoke1Button.Click += revoke1Button_Click;
            // 
            // grant1Button
            // 
            grant1Button.BackColor = Color.SteelBlue;
            grant1Button.FlatAppearance.BorderSize = 0;
            grant1Button.FlatStyle = FlatStyle.Flat;
            grant1Button.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grant1Button.ForeColor = Color.White;
            grant1Button.Location = new Point(50, 193);
            grant1Button.Name = "grant1Button";
            grant1Button.Size = new Size(90, 40);
            grant1Button.TabIndex = 2;
            grant1Button.Text = "Grant";
            grant1Button.UseVisualStyleBackColor = false;
            grant1Button.Click += grant1Button_Click;
            // 
            // role1
            // 
            role1.CharacterCasing = CharacterCasing.Upper;
            role1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role1.Location = new Point(50, 130);
            role1.Name = "role1";
            role1.Size = new Size(200, 27);
            role1.TabIndex = 1;
            // 
            // username1
            // 
            username1.CharacterCasing = CharacterCasing.Upper;
            username1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username1.Location = new Point(50, 60);
            username1.Name = "username1";
            username1.Size = new Size(200, 27);
            username1.TabIndex = 0;
            // 
            // usersData
            // 
            usersData.AllowUserToAddRows = false;
            usersData.AllowUserToDeleteRows = false;
            usersData.AllowUserToResizeColumns = false;
            usersData.AllowUserToResizeRows = false;
            usersData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            usersData.BorderStyle = BorderStyle.None;
            usersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersData.Dock = DockStyle.Bottom;
            usersData.Location = new Point(0, 354);
            usersData.Name = "usersData";
            usersData.RowHeadersWidth = 51;
            usersData.Size = new Size(904, 350);
            usersData.TabIndex = 1;
            usersData.CellClick += usersData_CellClick;
            // 
            // Privileges
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Privileges";
            Text = "Privileges";
            Load += Privileges_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView usersData;
        private Label label1;
        private Panel privilagesPanel;
        private Panel panel2;
        private Label label2;
        private Button grant1Button;
        private TextBox role1;
        private TextBox username1;
        private Button revoke1Button;
        private Label label4;
        private Label label3;
        private Button revoke2Button;
        private Button grant2Button;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private CheckBox updateBox;
        private CheckBox deleteBox;
        private CheckBox selectBox;
        private CheckBox insertBox;
        private CheckBox grantOptBox;
        private Label label7;
        private TextBox columnBox;
        private ComboBox tableCboBox;
        private Button button1;
    }
}