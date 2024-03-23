namespace ISS_QLNoiBo.Admin_Forms
{
    partial class ManageView
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
            viewPanel = new Panel();
            colCboBox = new ComboBox();
            tableCboBox = new ComboBox();
            readCkBox = new CheckBox();
            checkCkBox = new CheckBox();
            label4 = new Label();
            colText = new TextBox();
            updateButton = new Button();
            button3 = new Button();
            label2 = new Label();
            deleteRButton = new Button();
            label3 = new Label();
            createRButton = new Button();
            viewname = new TextBox();
            viewsData = new DataGridView();
            panel1.SuspendLayout();
            viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(viewPanel);
            panel1.Controls.Add(viewsData);
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
            label1.Size = new Size(185, 35);
            label1.TabIndex = 3;
            label1.Text = "Manage View";
            // 
            // viewPanel
            // 
            viewPanel.BackColor = Color.WhiteSmoke;
            viewPanel.BorderStyle = BorderStyle.FixedSingle;
            viewPanel.Controls.Add(colCboBox);
            viewPanel.Controls.Add(tableCboBox);
            viewPanel.Controls.Add(readCkBox);
            viewPanel.Controls.Add(checkCkBox);
            viewPanel.Controls.Add(label4);
            viewPanel.Controls.Add(colText);
            viewPanel.Controls.Add(updateButton);
            viewPanel.Controls.Add(button3);
            viewPanel.Controls.Add(label2);
            viewPanel.Controls.Add(deleteRButton);
            viewPanel.Controls.Add(label3);
            viewPanel.Controls.Add(createRButton);
            viewPanel.Controls.Add(viewname);
            viewPanel.Location = new Point(50, 52);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(804, 180);
            viewPanel.TabIndex = 4;
            // 
            // colCboBox
            // 
            colCboBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCboBox.FormattingEnabled = true;
            colCboBox.Location = new Point(415, 132);
            colCboBox.Name = "colCboBox";
            colCboBox.Size = new Size(150, 27);
            colCboBox.TabIndex = 18;
            colCboBox.SelectedIndexChanged += colCboBox_SelectedIndexChanged;
            // 
            // tableCboBox
            // 
            tableCboBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCboBox.FormattingEnabled = true;
            tableCboBox.Location = new Point(130, 75);
            tableCboBox.Name = "tableCboBox";
            tableCboBox.Size = new Size(250, 27);
            tableCboBox.TabIndex = 17;
            tableCboBox.TextChanged += tableCboBox_TextChanged;
            // 
            // readCkBox
            // 
            readCkBox.AutoSize = true;
            readCkBox.Location = new Point(415, 76);
            readCkBox.Name = "readCkBox";
            readCkBox.Size = new Size(128, 24);
            readCkBox.TabIndex = 15;
            readCkBox.Text = "With read only";
            readCkBox.UseVisualStyleBackColor = true;
            readCkBox.CheckedChanged += readCkBox_CheckedChanged;
            // 
            // checkCkBox
            // 
            checkCkBox.AutoSize = true;
            checkCkBox.Location = new Point(415, 19);
            checkCkBox.Name = "checkCkBox";
            checkCkBox.Size = new Size(151, 24);
            checkCkBox.TabIndex = 14;
            checkCkBox.Text = "With check option";
            checkCkBox.UseVisualStyleBackColor = true;
            checkCkBox.CheckedChanged += checkCkBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(30, 134);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 13;
            label4.Text = "Column";
            // 
            // colText
            // 
            colText.CharacterCasing = CharacterCasing.Upper;
            colText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colText.Location = new Point(130, 132);
            colText.Name = "colText";
            colText.PlaceholderText = "C1,C2,C3,...";
            colText.Size = new Size(250, 27);
            colText.TabIndex = 12;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(589, 125);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(80, 40);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(686, 125);
            button3.Name = "button3";
            button3.Size = new Size(80, 40);
            button3.TabIndex = 9;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 8;
            label2.Text = "Table";
            // 
            // deleteRButton
            // 
            deleteRButton.BackColor = Color.SteelBlue;
            deleteRButton.FlatAppearance.BorderSize = 0;
            deleteRButton.FlatStyle = FlatStyle.Flat;
            deleteRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteRButton.ForeColor = Color.White;
            deleteRButton.Location = new Point(686, 72);
            deleteRButton.Name = "deleteRButton";
            deleteRButton.Size = new Size(80, 40);
            deleteRButton.TabIndex = 6;
            deleteRButton.Text = "Delete";
            deleteRButton.UseVisualStyleBackColor = false;
            deleteRButton.Click += deleteRButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(30, 20);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 4;
            label3.Text = "View name";
            // 
            // createRButton
            // 
            createRButton.BackColor = Color.SteelBlue;
            createRButton.FlatAppearance.BorderSize = 0;
            createRButton.FlatStyle = FlatStyle.Flat;
            createRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createRButton.ForeColor = Color.White;
            createRButton.Location = new Point(589, 72);
            createRButton.Name = "createRButton";
            createRButton.Size = new Size(80, 40);
            createRButton.TabIndex = 2;
            createRButton.Text = "Create";
            createRButton.UseVisualStyleBackColor = false;
            createRButton.Click += createRButton_Click;
            // 
            // viewname
            // 
            viewname.CharacterCasing = CharacterCasing.Upper;
            viewname.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewname.Location = new Point(130, 18);
            viewname.Name = "viewname";
            viewname.Size = new Size(250, 27);
            viewname.TabIndex = 0;
            // 
            // viewsData
            // 
            viewsData.AllowUserToAddRows = false;
            viewsData.AllowUserToDeleteRows = false;
            viewsData.AllowUserToResizeColumns = false;
            viewsData.AllowUserToResizeRows = false;
            viewsData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewsData.BorderStyle = BorderStyle.None;
            viewsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewsData.Dock = DockStyle.Bottom;
            viewsData.Location = new Point(0, 254);
            viewsData.Name = "viewsData";
            viewsData.RowHeadersWidth = 51;
            viewsData.Size = new Size(904, 450);
            viewsData.TabIndex = 1;
            viewsData.CellClick += viewsData_CellClick;
            // 
            // ManageView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageView";
            Text = "RoleTab";
            Load += ManageView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            viewPanel.ResumeLayout(false);
            viewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel viewPanel;
        private Label label1;
        private Button deleteRButton;
        private Label label3;
        private Button createRButton;
        private TextBox role1;
        private TextBox viewname;
        private DataGridView viewsData;
        private Label label2;
        private Button button3;
        private Button updateButton;
        private Label label4;
        private TextBox colText;
        private CheckBox checkCkBox;
        private CheckBox readCkBox;
        private ComboBox tableCboBox;
        private ComboBox colCboBox;
    }
}