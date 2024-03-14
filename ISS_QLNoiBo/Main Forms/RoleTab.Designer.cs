namespace ISS_QLNoiBo.Main_Forms
{
    partial class RoleTab
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
            privilagesPanel = new Panel();
            label1 = new Label();
            deleteRButton = new Button();
            label3 = new Label();
            createRButton = new Button();
            username1 = new TextBox();
            usersData = new DataGridView();
            panel1.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(usersData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.Controls.Add(deleteRButton);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(createRButton);
            privilagesPanel.Controls.Add(username1);
            privilagesPanel.Location = new Point(50, 52);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(804, 150);
            privilagesPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(363, 8);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 3;
            label1.Text = "Manage Role";
            // 
            // deleteRButton
            // 
            deleteRButton.BackColor = Color.SteelBlue;
            deleteRButton.FlatAppearance.BorderSize = 0;
            deleteRButton.FlatStyle = FlatStyle.Flat;
            deleteRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteRButton.ForeColor = Color.White;
            deleteRButton.Location = new Point(424, 84);
            deleteRButton.Name = "deleteRButton";
            deleteRButton.Size = new Size(130, 40);
            deleteRButton.TabIndex = 6;
            deleteRButton.Text = "Delete";
            deleteRButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(250, 25);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 4;
            label3.Text = "Role name";
            // 
            // createRButton
            // 
            createRButton.BackColor = Color.SteelBlue;
            createRButton.FlatAppearance.BorderSize = 0;
            createRButton.FlatStyle = FlatStyle.Flat;
            createRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createRButton.ForeColor = Color.White;
            createRButton.Location = new Point(250, 84);
            createRButton.Name = "createRButton";
            createRButton.Size = new Size(130, 40);
            createRButton.TabIndex = 2;
            createRButton.Text = "Create";
            createRButton.UseVisualStyleBackColor = false;
            // 
            // username1
            // 
            username1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username1.Location = new Point(250, 51);
            username1.Name = "username1";
            username1.Size = new Size(304, 27);
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
            usersData.Location = new Point(0, 254);
            usersData.Name = "usersData";
            usersData.RowHeadersWidth = 51;
            usersData.Size = new Size(904, 450);
            usersData.TabIndex = 1;
            // 
            // RoleTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleTab";
            Text = "RoleTab";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel privilagesPanel;
        private Label label1;
        private Button deleteRButton;
        private Label label4;
        private Label label3;
        private Button createRButton;
        private TextBox role1;
        private TextBox username1;
        private DataGridView usersData;
    }
}