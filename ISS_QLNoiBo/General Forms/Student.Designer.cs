namespace ISS_QLNoiBo.General_Forms
{
    partial class Student
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
            studentData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(studentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(378, 10);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 7;
            label2.Text = "Student List";
            // 
            // studentData
            // 
            studentData.AllowUserToAddRows = false;
            studentData.AllowUserToDeleteRows = false;
            studentData.AllowUserToResizeColumns = false;
            studentData.AllowUserToResizeRows = false;
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            studentData.BorderStyle = BorderStyle.None;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Dock = DockStyle.Bottom;
            studentData.Location = new Point(0, 54);
            studentData.Name = "studentData";
            studentData.ReadOnly = true;
            studentData.RowHeadersVisible = false;
            studentData.RowHeadersWidth = 51;
            studentData.Size = new Size(904, 650);
            studentData.TabIndex = 0;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView studentData;
        private Label label2;
    }
}