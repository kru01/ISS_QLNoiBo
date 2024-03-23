namespace ISS_QLNoiBo.Student_Forms
{
    partial class CourseReg
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
            availableCourse = new DataGridView();
            panel2 = new Panel();
            refreshButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            label3 = new Label();
            label2 = new Label();
            courseID = new TextBox();
            courseName = new TextBox();
            label1 = new Label();
            registeredCourse = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableCourse).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registeredCourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(availableCourse);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(registeredCourse);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // availableCourse
            // 
            availableCourse.AllowUserToAddRows = false;
            availableCourse.AllowUserToDeleteRows = false;
            availableCourse.AllowUserToResizeColumns = false;
            availableCourse.AllowUserToResizeRows = false;
            availableCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            availableCourse.BorderStyle = BorderStyle.None;
            availableCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableCourse.Location = new Point(458, 253);
            availableCourse.Name = "availableCourse";
            availableCourse.ReadOnly = true;
            availableCourse.RowHeadersVisible = false;
            availableCourse.RowHeadersWidth = 51;
            availableCourse.Size = new Size(445, 450);
            availableCourse.TabIndex = 2;
            availableCourse.CellClick += availableCourse_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(removeButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(courseID);
            panel2.Controls.Add(courseName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 200);
            panel2.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(534, 120);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(120, 40);
            refreshButton.TabIndex = 17;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.SteelBlue;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(366, 120);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(120, 40);
            removeButton.TabIndex = 16;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(200, 120);
            addButton.Name = "addButton";
            addButton.Size = new Size(120, 40);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(354, 54);
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
            label2.Location = new Point(200, 53);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 5;
            label2.Text = "Course ID";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(200, 80);
            courseID.Name = "courseID";
            courseID.PlaceholderText = "Course ID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(100, 27);
            courseID.TabIndex = 4;
            // 
            // courseName
            // 
            courseName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseName.Location = new Point(354, 80);
            courseName.Name = "courseName";
            courseName.PlaceholderText = "Course Name";
            courseName.ReadOnly = true;
            courseName.Size = new Size(300, 27);
            courseName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(305, -1);
            label1.Name = "label1";
            label1.Size = new Size(246, 35);
            label1.TabIndex = 2;
            label1.Text = "Course Registration";
            // 
            // registeredCourse
            // 
            registeredCourse.AllowUserToAddRows = false;
            registeredCourse.AllowUserToDeleteRows = false;
            registeredCourse.AllowUserToResizeColumns = false;
            registeredCourse.AllowUserToResizeRows = false;
            registeredCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            registeredCourse.BorderStyle = BorderStyle.None;
            registeredCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredCourse.Location = new Point(0, 253);
            registeredCourse.Name = "registeredCourse";
            registeredCourse.ReadOnly = true;
            registeredCourse.RowHeadersVisible = false;
            registeredCourse.RowHeadersWidth = 51;
            registeredCourse.Size = new Size(445, 450);
            registeredCourse.TabIndex = 0;
            registeredCourse.CellClick += registeredCourse_CellClick;
            // 
            // CourseReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseReg";
            Text = "CourseReg";
            Load += CourseReg_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)availableCourse).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registeredCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button removeButton;
        private Button addButton;
        private Label label3;
        private Label label2;
        private TextBox courseID;
        private TextBox courseName;
        private Label label1;
        private DataGridView registeredCourse;
        private DataGridView availableCourse;
        private Button refreshButton;
    }
}