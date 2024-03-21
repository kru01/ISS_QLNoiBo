namespace ISS_QLNoiBo.Admin_Forms
{
    partial class InspectPriv
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            roleGrid = new DataGridView();
            sysGrid = new DataGridView();
            label1 = new Label();
            privilagesPanel = new Panel();
            button1 = new Button();
            grant2Button = new Button();
            label2 = new Label();
            userName = new TextBox();
            tableGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roleGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sysGrid).BeginInit();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(roleGrid);
            panel1.Controls.Add(sysGrid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(tableGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(464, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 27);
            label5.TabIndex = 7;
            label5.Text = "Role privileges";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(0, 140);
            label4.Name = "label4";
            label4.Size = new Size(174, 27);
            label4.TabIndex = 6;
            label4.Text = "System privileges";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(0, 365);
            label3.Name = "label3";
            label3.Size = new Size(185, 27);
            label3.TabIndex = 5;
            label3.Text = "Privileges on table";
            // 
            // roleGrid
            // 
            roleGrid.AllowUserToAddRows = false;
            roleGrid.AllowUserToDeleteRows = false;
            roleGrid.AllowUserToResizeColumns = false;
            roleGrid.AllowUserToResizeRows = false;
            roleGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            roleGrid.BorderStyle = BorderStyle.None;
            roleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roleGrid.Location = new Point(464, 39);
            roleGrid.Name = "roleGrid";
            roleGrid.RowHeadersWidth = 51;
            roleGrid.Size = new Size(440, 321);
            roleGrid.TabIndex = 4;
            roleGrid.CellClick += roleGrid_CellClick;
            // 
            // sysGrid
            // 
            sysGrid.AllowUserToAddRows = false;
            sysGrid.AllowUserToDeleteRows = false;
            sysGrid.AllowUserToResizeColumns = false;
            sysGrid.AllowUserToResizeRows = false;
            sysGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sysGrid.BorderStyle = BorderStyle.None;
            sysGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sysGrid.Location = new Point(0, 170);
            sysGrid.Name = "sysGrid";
            sysGrid.RowHeadersWidth = 51;
            sysGrid.Size = new Size(440, 190);
            sysGrid.TabIndex = 3;
            sysGrid.CellClick += sysGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(71, 5);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 1;
            label1.Text = "Privileges";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(button1);
            privilagesPanel.Controls.Add(grant2Button);
            privilagesPanel.Controls.Add(label2);
            privilagesPanel.Controls.Add(userName);
            privilagesPanel.Location = new Point(30, 25);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(410, 110);
            privilagesPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(285, 60);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 8;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // grant2Button
            // 
            grant2Button.BackColor = Color.SteelBlue;
            grant2Button.FlatAppearance.BorderSize = 0;
            grant2Button.FlatStyle = FlatStyle.Flat;
            grant2Button.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grant2Button.ForeColor = Color.White;
            grant2Button.Location = new Point(285, 10);
            grant2Button.Name = "grant2Button";
            grant2Button.Size = new Size(80, 40);
            grant2Button.TabIndex = 7;
            grant2Button.Text = "View";
            grant2Button.UseVisualStyleBackColor = false;
            grant2Button.Click += grant2Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "User/Role";
            // 
            // userName
            // 
            userName.CharacterCasing = CharacterCasing.Upper;
            userName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(20, 56);
            userName.Name = "userName";
            userName.PlaceholderText = "Enter user/role name";
            userName.Size = new Size(250, 27);
            userName.TabIndex = 0;
            // 
            // tableGrid
            // 
            tableGrid.AllowUserToAddRows = false;
            tableGrid.AllowUserToDeleteRows = false;
            tableGrid.AllowUserToResizeColumns = false;
            tableGrid.AllowUserToResizeRows = false;
            tableGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableGrid.BorderStyle = BorderStyle.None;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Dock = DockStyle.Bottom;
            tableGrid.Location = new Point(0, 395);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 51;
            tableGrid.Size = new Size(904, 309);
            tableGrid.TabIndex = 0;
            tableGrid.CellClick += tableGrid_CellClick;
            // 
            // InspectPriv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InspectPriv";
            StartPosition = FormStartPosition.Manual;
            Text = "PrivInspection";
            Load += InspectPriv_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roleGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sysGrid).EndInit();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel privilagesPanel;
        private Label label2;
        private TextBox userName;
        private DataGridView tableGrid;
        private Button grant2Button;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView roleGrid;
        private DataGridView sysGrid;
        private Button button1;
    }
}