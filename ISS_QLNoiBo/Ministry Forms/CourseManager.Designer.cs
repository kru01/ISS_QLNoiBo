namespace ISS_QLNoiBo.Ministry_Forms
{
    partial class CourseManager
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
            label8 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            yearBox = new TextBox();
            semesterBox = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            courseID2 = new TextBox();
            courseName2 = new TextBox();
            planData = new DataGridView();
            courseData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            slotBox = new TextBox();
            creditBox = new TextBox();
            button1 = new Button();
            refreshButton = new Button();
            addButton = new Button();
            label3 = new Label();
            label2 = new Label();
            courseID = new TextBox();
            courseName = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(planData);
            panel1.Controls.Add(courseData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(600, 12);
            label8.Name = "label8";
            label8.Size = new Size(156, 35);
            label8.TabIndex = 22;
            label8.Text = "Course Plan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(yearBox);
            panel3.Controls.Add(semesterBox);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(courseID2);
            panel3.Controls.Add(courseName2);
            panel3.Location = new Point(458, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 217);
            panel3.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(295, 25);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 22;
            label10.Text = "Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(170, 25);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 21;
            label9.Text = "Semester";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(295, 52);
            yearBox.Name = "yearBox";
            yearBox.PlaceholderText = "Year";
            yearBox.Size = new Size(100, 27);
            yearBox.TabIndex = 20;
            yearBox.KeyPress += yearBox_KeyPress;
            // 
            // semesterBox
            // 
            semesterBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semesterBox.Location = new Point(170, 51);
            semesterBox.Name = "semesterBox";
            semesterBox.PlaceholderText = "Semester";
            semesterBox.Size = new Size(100, 27);
            semesterBox.TabIndex = 19;
            semesterBox.KeyPress += semesterBox_KeyPress;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(295, 151);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 18;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(170, 151);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 17;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(45, 151);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 15;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(45, 85);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 6;
            label4.Text = "Course Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(45, 25);
            label5.Name = "label5";
            label5.Size = new Size(26, 23);
            label5.TabIndex = 5;
            label5.Text = "ID";
            // 
            // courseID2
            // 
            courseID2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID2.Location = new Point(45, 51);
            courseID2.Name = "courseID2";
            courseID2.PlaceholderText = "ID";
            courseID2.ReadOnly = true;
            courseID2.Size = new Size(75, 27);
            courseID2.TabIndex = 4;
            // 
            // courseName2
            // 
            courseName2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName2.Location = new Point(45, 111);
            courseName2.Name = "courseName2";
            courseName2.PlaceholderText = "Course Name";
            courseName2.Size = new Size(350, 27);
            courseName2.TabIndex = 3;
            // 
            // planData
            // 
            planData.AllowUserToAddRows = false;
            planData.AllowUserToDeleteRows = false;
            planData.AllowUserToResizeColumns = false;
            planData.AllowUserToResizeRows = false;
            planData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            planData.BorderStyle = BorderStyle.None;
            planData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planData.Location = new Point(458, 253);
            planData.Name = "planData";
            planData.ReadOnly = true;
            planData.RowHeadersVisible = false;
            planData.RowHeadersWidth = 51;
            planData.Size = new Size(445, 450);
            planData.TabIndex = 2;
            planData.CellClick += planData_CellClick;
            // 
            // courseData
            // 
            courseData.AllowUserToAddRows = false;
            courseData.AllowUserToDeleteRows = false;
            courseData.AllowUserToResizeColumns = false;
            courseData.AllowUserToResizeRows = false;
            courseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            courseData.BorderStyle = BorderStyle.None;
            courseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseData.Location = new Point(0, 253);
            courseData.Name = "courseData";
            courseData.ReadOnly = true;
            courseData.RowHeadersVisible = false;
            courseData.RowHeadersWidth = 51;
            courseData.Size = new Size(445, 450);
            courseData.TabIndex = 0;
            courseData.CellClick += courseData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(86, 12);
            label1.Name = "label1";
            label1.Size = new Size(262, 35);
            label1.TabIndex = 2;
            label1.Text = "Course Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(slotBox);
            panel2.Controls.Add(creditBox);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(courseName);
            panel2.Location = new Point(3, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 217);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(295, 25);
            label7.Name = "label7";
            label7.Size = new Size(39, 23);
            label7.TabIndex = 22;
            label7.Text = "Slot";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(170, 25);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 21;
            label6.Text = "Credit";
            // 
            // slotBox
            // 
            slotBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slotBox.Location = new Point(295, 52);
            slotBox.Name = "slotBox";
            slotBox.PlaceholderText = "Slot";
            slotBox.Size = new Size(100, 27);
            slotBox.TabIndex = 20;
            slotBox.KeyPress += slotBox_KeyPress;
            // 
            // creditBox
            // 
            creditBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditBox.Location = new Point(170, 52);
            creditBox.Name = "creditBox";
            creditBox.PlaceholderText = "Credit";
            creditBox.Size = new Size(100, 27);
            creditBox.TabIndex = 19;
            creditBox.KeyPress += creditBox_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(295, 151);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 18;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(170, 151);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 17;
            refreshButton.Text = "Update";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(45, 151);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(45, 85);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(45, 25);
            label2.Name = "label2";
            label2.Size = new Size(26, 23);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(45, 51);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 4;
            // 
            // courseName
            // 
            courseName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName.Location = new Point(45, 111);
            courseName.Name = "courseName";
            courseName.PlaceholderText = "Course Name";
            courseName.Size = new Size(350, 27);
            courseName.TabIndex = 3;
            // 
            // CourseManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseManager";
            Text = "CourseManager";
            Load += CourseManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planData).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView planData;
        private Panel panel2;
        private Button refreshButton;
        private Button addButton;
        private Label label3;
        private Label label2;
        private TextBox courseID;
        private TextBox courseName;
        private Label label1;
        private DataGridView courseData;
        private Button button1;
        private TextBox slotBox;
        private TextBox creditBox;
        private Panel panel3;
        private TextBox yearBox;
        private TextBox semesterBox;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private TextBox courseID2;
        private TextBox courseName2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}