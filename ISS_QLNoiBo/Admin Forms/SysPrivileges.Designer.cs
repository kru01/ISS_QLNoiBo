namespace ISS_QLNoiBo.Admin_Forms
{
    partial class SysPrivileges
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
            adminOptBox = new CheckBox();
            button1 = new Button();
            sysPrivilegedBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            createUButton = new Button();
            username1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
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
            label1.Location = new Point(341, 50);
            label1.Name = "label1";
            label1.Size = new Size(222, 35);
            label1.TabIndex = 7;
            label1.Text = "System Privileges";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(adminOptBox);
            privilagesPanel.Controls.Add(button1);
            privilagesPanel.Controls.Add(sysPrivilegedBox);
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(createUButton);
            privilagesPanel.Controls.Add(username1);
            privilagesPanel.Location = new Point(250, 70);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(404, 304);
            privilagesPanel.TabIndex = 4;
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
            button1.Location = new Point(220, 215);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 18;
            button1.Text = "Revoke";
            button1.UseVisualStyleBackColor = false;
            // 
            // sysPrivilegedBox
            // 
            sysPrivilegedBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sysPrivilegedBox.FormattingEnabled = true;
            sysPrivilegedBox.Location = new Point(50, 130);
            sysPrivilegedBox.Name = "sysPrivilegedBox";
            sysPrivilegedBox.Size = new Size(290, 27);
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
            label3.Size = new Size(143, 23);
            label3.TabIndex = 4;
            label3.Text = "Name User/Role";
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
            createUButton.Size = new Size(120, 40);
            createUButton.TabIndex = 2;
            createUButton.Text = "Grant";
            createUButton.UseVisualStyleBackColor = false;
            // 
            // username1
            // 
            username1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username1.Location = new Point(50, 60);
            username1.Name = "username1";
            username1.Size = new Size(290, 27);
            username1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(904, 300);
            dataGridView1.TabIndex = 8;
            // 
            // SysPrivileges
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SysPrivileges";
            Text = "SysPrivileges";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}