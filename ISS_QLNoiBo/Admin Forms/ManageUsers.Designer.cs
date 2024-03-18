namespace ISS_QLNoiBo.Admin_Forms
{
    partial class ManageUsers
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            lockAccBox = new CheckBox();
            quotaUpDown = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            label2 = new Label();
            label5 = new Label();
            button2 = new Button();
            password2 = new TextBox();
            username2 = new TextBox();
            label1 = new Label();
            privilagesPanel = new Panel();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            createUButton = new Button();
            password1 = new TextBox();
            username1 = new TextBox();
            usersData = new DataGridView();
            quotaTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quotaUpDown).BeginInit();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(usersData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lockAccBox);
            panel2.Controls.Add(quotaUpDown);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(password2);
            panel2.Controls.Add(username2);
            panel2.Location = new Point(374, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 275);
            panel2.TabIndex = 7;
            // 
            // lockAccBox
            // 
            lockAccBox.AutoSize = true;
            lockAccBox.Location = new Point(298, 61);
            lockAccBox.Name = "lockAccBox";
            lockAccBox.Size = new Size(117, 24);
            lockAccBox.TabIndex = 10;
            lockAccBox.Text = "Lock account";
            lockAccBox.UseVisualStyleBackColor = true;
            // 
            // quotaUpDown
            // 
            quotaUpDown.Location = new Point(50, 200);
            quotaUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quotaUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            quotaUpDown.Name = "quotaUpDown";
            quotaUpDown.Size = new Size(200, 27);
            quotaUpDown.TabIndex = 9;
            quotaTip.SetToolTip(quotaUpDown, "In MB, 0 to ignore, -1 for Unlimited");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(50, 174);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 8;
            label6.Text = "Quota";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(370, 193);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(50, 104);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(50, 34);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 4;
            label5.Text = "Username";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(275, 193);
            button2.Name = "button2";
            button2.Size = new Size(80, 40);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // password2
            // 
            password2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password2.Location = new Point(50, 130);
            password2.Name = "password2";
            password2.PlaceholderText = "Leave blank to not update";
            password2.Size = new Size(200, 27);
            password2.TabIndex = 1;
            password2.UseSystemPasswordChar = true;
            // 
            // username2
            // 
            username2.CharacterCasing = CharacterCasing.Upper;
            username2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username2.Location = new Point(50, 60);
            username2.Name = "username2";
            username2.Size = new Size(200, 27);
            username2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(363, 4);
            label1.Name = "label1";
            label1.Size = new Size(178, 35);
            label1.TabIndex = 7;
            label1.Text = "Manage User";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(button3);
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(createUButton);
            privilagesPanel.Controls.Add(password1);
            privilagesPanel.Controls.Add(username1);
            privilagesPanel.Location = new Point(50, 45);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(300, 275);
            privilagesPanel.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(170, 193);
            button3.Name = "button3";
            button3.Size = new Size(80, 40);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(50, 104);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(50, 34);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // createUButton
            // 
            createUButton.BackColor = Color.SteelBlue;
            createUButton.FlatAppearance.BorderSize = 0;
            createUButton.FlatStyle = FlatStyle.Flat;
            createUButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createUButton.ForeColor = Color.White;
            createUButton.Location = new Point(50, 193);
            createUButton.Name = "createUButton";
            createUButton.Size = new Size(80, 40);
            createUButton.TabIndex = 2;
            createUButton.Text = "Create";
            createUButton.UseVisualStyleBackColor = false;
            createUButton.Click += createUButton_Click;
            // 
            // password1
            // 
            password1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password1.Location = new Point(50, 130);
            password1.Name = "password1";
            password1.Size = new Size(200, 27);
            password1.TabIndex = 1;
            password1.UseSystemPasswordChar = true;
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
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            Text = "ManageUsers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quotaUpDown).EndInit();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox tableCboBox;
        private Panel privilagesPanel;
        private Label label4;
        private Label label3;
        private Button createUButton;
        private TextBox password1;
        private TextBox username1;
        private DataGridView usersData;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label5;
        private Button button2;
        private TextBox password2;
        private TextBox username2;
        private Label label6;
        private NumericUpDown quotaUpDown;
        private ToolTip quotaTip;
        private CheckBox lockAccBox;
        private Button button3;
    }
}