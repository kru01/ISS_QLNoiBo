namespace ISS_QLNoiBo
{
    partial class Users
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
            label2 = new Label();
            privilegesData = new DataGridView();
            userName = new TextBox();
            usersData = new DataGridView();
            panel1.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)privilegesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(usersData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(386, 28);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 1;
            label1.Text = "Privileges";
            // 
            // privilagesPanel
            // 
            privilagesPanel.Controls.Add(label2);
            privilagesPanel.Controls.Add(privilegesData);
            privilagesPanel.Controls.Add(userName);
            privilagesPanel.Location = new Point(50, 45);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(804, 275);
            privilagesPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(374, 30);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // privilegesData
            // 
            privilegesData.AllowUserToAddRows = false;
            privilegesData.AllowUserToDeleteRows = false;
            privilegesData.AllowUserToResizeColumns = false;
            privilegesData.AllowUserToResizeRows = false;
            privilegesData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            privilegesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            privilegesData.Location = new Point(0, 125);
            privilegesData.Name = "privilegesData";
            privilegesData.RowHeadersWidth = 51;
            privilegesData.Size = new Size(804, 150);
            privilegesData.TabIndex = 1;
            // 
            // userName
            // 
            userName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(275, 56);
            userName.Name = "userName";
            userName.PlaceholderText = "User Name";
            userName.Size = new Size(250, 27);
            userName.TabIndex = 0;
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
            usersData.TabIndex = 0;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)privilegesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView usersData;
        private Label label1;
        private Panel privilagesPanel;
        private DataGridView privilegesData;
        private TextBox userName;
        private Label label2;
    }
}