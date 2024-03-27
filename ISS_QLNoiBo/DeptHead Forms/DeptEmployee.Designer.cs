namespace ISS_QLNoiBo.DeptHead_Forms
{
    partial class DeptEmployee
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
            refreshButton = new Button();
            deleteButton = new Button();
            insertButton = new Button();
            updateButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            genderCbo = new ComboBox();
            courseCbo = new ComboBox();
            employeeData = new DataGridView();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(employeeData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(343, 260);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 19;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(131, 260);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 40);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(25, 260);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 17;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(237, 260);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 40);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(326, 10);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 3;
            label1.Text = "Employee Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(genderCbo);
            panel2.Controls.Add(courseCbo);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 225);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(468, 34);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 20;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(189, 124);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 17;
            label5.Text = "Course Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(189, 34);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 16;
            label6.Text = "Employee Name";
            // 
            // genderCbo
            // 
            genderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCbo.FormattingEnabled = true;
            genderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            genderCbo.Location = new Point(468, 60);
            genderCbo.Name = "genderCbo";
            genderCbo.Size = new Size(75, 27);
            genderCbo.TabIndex = 15;
            // 
            // courseCbo
            // 
            courseCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCbo.FormattingEnabled = true;
            courseCbo.Location = new Point(189, 150);
            courseCbo.Name = "courseCbo";
            courseCbo.Size = new Size(250, 27);
            courseCbo.TabIndex = 12;
            // 
            // employeeData
            // 
            employeeData.AllowUserToAddRows = false;
            employeeData.AllowUserToDeleteRows = false;
            employeeData.AllowUserToResizeColumns = false;
            employeeData.AllowUserToResizeRows = false;
            employeeData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            employeeData.BorderStyle = BorderStyle.None;
            employeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeData.Dock = DockStyle.Bottom;
            employeeData.Location = new Point(0, 304);
            employeeData.Name = "employeeData";
            employeeData.ReadOnly = true;
            employeeData.RowHeadersVisible = false;
            employeeData.RowHeadersWidth = 51;
            employeeData.Size = new Size(904, 400);
            employeeData.TabIndex = 0;
            employeeData.CellClick += employeeData_CellClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(189, 60);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Employee Name";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 21;
            // 
            // DeptEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeptEmployee";
            Text = "DeptEmployee";
            Load += DeptEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button refreshButton;
        private Button deleteButton;
        private Button insertButton;
        private Button updateButton;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox genderCbo;
        private ComboBox courseCbo;
        private DataGridView employeeData;
        private TextBox textBox1;
    }
}