namespace ISS_QLNoiBo.Admin_Forms
{
    partial class Announcement
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
            AnnIDUpDown = new NumericUpDown();
            label4 = new Label();
            LabelCbo = new ComboBox();
            RefreshButton = new Button();
            label2 = new Label();
            ContentBox = new TextBox();
            DeleteButton = new Button();
            label3 = new Label();
            PostButton = new Button();
            AnnData = new DataGridView();
            panel1.SuspendLayout();
            privilagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnnIDUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnnData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(privilagesPanel);
            panel1.Controls.Add(AnnData);
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
            label1.Location = new Point(363, 8);
            label1.Name = "label1";
            label1.Size = new Size(183, 35);
            label1.TabIndex = 3;
            label1.Text = "Announcement";
            // 
            // privilagesPanel
            // 
            privilagesPanel.BackColor = Color.WhiteSmoke;
            privilagesPanel.BorderStyle = BorderStyle.FixedSingle;
            privilagesPanel.Controls.Add(AnnIDUpDown);
            privilagesPanel.Controls.Add(label4);
            privilagesPanel.Controls.Add(LabelCbo);
            privilagesPanel.Controls.Add(RefreshButton);
            privilagesPanel.Controls.Add(label2);
            privilagesPanel.Controls.Add(ContentBox);
            privilagesPanel.Controls.Add(DeleteButton);
            privilagesPanel.Controls.Add(label3);
            privilagesPanel.Controls.Add(PostButton);
            privilagesPanel.Location = new Point(50, 52);
            privilagesPanel.Name = "privilagesPanel";
            privilagesPanel.Size = new Size(804, 180);
            privilagesPanel.TabIndex = 4;
            // 
            // AnnIDUpDown
            // 
            AnnIDUpDown.Location = new Point(150, 22);
            AnnIDUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            AnnIDUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AnnIDUpDown.Name = "AnnIDUpDown";
            AnnIDUpDown.Size = new Size(180, 27);
            AnnIDUpDown.TabIndex = 13;
            AnnIDUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(375, 22);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 12;
            label4.Text = "Content";
            // 
            // LabelCbo
            // 
            LabelCbo.FormattingEnabled = true;
            LabelCbo.Location = new Point(150, 69);
            LabelCbo.Name = "LabelCbo";
            LabelCbo.Size = new Size(180, 28);
            LabelCbo.TabIndex = 11;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SteelBlue;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(250, 119);
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
            label2.Location = new Point(50, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 8;
            label2.Text = "Label";
            // 
            // ContentBox
            // 
            ContentBox.AcceptsReturn = true;
            ContentBox.AcceptsTab = true;
            ContentBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContentBox.Location = new Point(375, 48);
            ContentBox.Multiline = true;
            ContentBox.Name = "ContentBox";
            ContentBox.PlaceholderText = "Enter information about the announcement here...";
            ContentBox.Size = new Size(385, 111);
            ContentBox.TabIndex = 7;
            ContentBox.UseSystemPasswordChar = true;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SteelBlue;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(150, 119);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(80, 40);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(50, 22);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 4;
            label3.Text = "Ann. ID";
            // 
            // PostButton
            // 
            PostButton.BackColor = Color.SteelBlue;
            PostButton.FlatAppearance.BorderSize = 0;
            PostButton.FlatStyle = FlatStyle.Flat;
            PostButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PostButton.ForeColor = Color.White;
            PostButton.Location = new Point(50, 119);
            PostButton.Name = "PostButton";
            PostButton.Size = new Size(80, 40);
            PostButton.TabIndex = 2;
            PostButton.Text = "Post";
            PostButton.UseVisualStyleBackColor = false;
            PostButton.Click += PostButton_Click;
            // 
            // AnnData
            // 
            AnnData.AllowUserToAddRows = false;
            AnnData.AllowUserToDeleteRows = false;
            AnnData.AllowUserToResizeColumns = false;
            AnnData.AllowUserToResizeRows = false;
            AnnData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AnnData.BorderStyle = BorderStyle.None;
            AnnData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnnData.Dock = DockStyle.Bottom;
            AnnData.Location = new Point(0, 254);
            AnnData.Name = "AnnData";
            AnnData.ReadOnly = true;
            AnnData.RowHeadersVisible = false;
            AnnData.RowHeadersWidth = 51;
            AnnData.Size = new Size(904, 450);
            AnnData.TabIndex = 1;
            AnnData.CellClick += AnnData_CellClick;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Announcement";
            Text = "RoleTab";
            Load += Announcement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            privilagesPanel.ResumeLayout(false);
            privilagesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnnIDUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnnData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel privilagesPanel;
        private Label label1;
        private Button DeleteButton;
        private Label label3;
        private Button PostButton;
        private DataGridView AnnData;
        private Label label2;
        private Button RefreshButton;
        private ComboBox LabelCbo;
        private TextBox ContentBox;
        private NumericUpDown AnnIDUpDown;
        private Label label4;
    }
}