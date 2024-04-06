namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class UnitManager
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
            label2 = new Label();
            panel2 = new Panel();
            refreshButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            label3 = new Label();
            unitHeadID = new TextBox();
            label1 = new Label();
            label5 = new Label();
            unitName = new TextBox();
            unitData = new DataGridView();
            unitID = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unitData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitID).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(unitData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 703);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(614, 99);
            label2.Name = "label2";
            label2.Size = new Size(181, 35);
            label2.TabIndex = 8;
            label2.Text = "Unit Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(unitID);
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(insertButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(unitHeadID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(unitName);
            panel2.Location = new Point(492, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 450);
            panel2.TabIndex = 2;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(137, 370);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(125, 40);
            refreshButton.TabIndex = 26;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(224, 320);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(125, 40);
            updateButton.TabIndex = 25;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(49, 320);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(125, 40);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(224, 192);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 22;
            label3.Text = "Unit Head ID";
            // 
            // unitHeadID
            // 
            unitHeadID.CharacterCasing = CharacterCasing.Upper;
            unitHeadID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitHeadID.Location = new Point(224, 218);
            unitHeadID.Name = "unitHeadID";
            unitHeadID.PlaceholderText = "Unit Head ID";
            unitHeadID.Size = new Size(125, 27);
            unitHeadID.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(49, 192);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 20;
            label1.Text = "Unit ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(49, 107);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 18;
            label5.Text = "Unit Name";
            // 
            // unitName
            // 
            unitName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitName.Location = new Point(49, 133);
            unitName.Name = "unitName";
            unitName.PlaceholderText = "Unit Name";
            unitName.Size = new Size(300, 27);
            unitName.TabIndex = 0;
            // 
            // unitData
            // 
            unitData.AllowUserToAddRows = false;
            unitData.AllowUserToDeleteRows = false;
            unitData.AllowUserToResizeColumns = false;
            unitData.AllowUserToResizeRows = false;
            unitData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            unitData.BorderStyle = BorderStyle.None;
            unitData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            unitData.Location = new Point(12, 122);
            unitData.Name = "unitData";
            unitData.ReadOnly = true;
            unitData.RowHeadersVisible = false;
            unitData.RowHeadersWidth = 51;
            unitData.Size = new Size(474, 450);
            unitData.TabIndex = 1;
            unitData.CellClick += unitData_CellClick;
            // 
            // unitID
            // 
            unitID.Location = new Point(49, 218);
            unitID.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            unitID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            unitID.Name = "unitID";
            unitID.Size = new Size(125, 27);
            unitID.TabIndex = 27;
            unitID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UnitManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 703);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UnitManager";
            Text = "c";
            Load += UnitManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)unitData).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView unitData;
        private Panel panel2;
        private Label label2;
        private TextBox unitName;
        private Label label5;
        private Label label3;
        private TextBox unitHeadID;
        private Label label1;
        private Button updateButton;
        private Button insertButton;
        private Button refreshButton;
        private NumericUpDown unitID;
    }
}