﻿namespace ISS_QLNoiBo.Student_Forms
{
    partial class CourseView
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
            planData = new DataGridView();
            label2 = new Label();
            courseData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(planData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(courseData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 704);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(682, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 35);
            label1.TabIndex = 9;
            label1.Text = "Plan";
            // 
            // planData
            // 
            planData.AllowUserToAddRows = false;
            planData.AllowUserToDeleteRows = false;
            planData.AllowUserToResizeColumns = false;
            planData.AllowUserToResizeRows = false;
            planData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            planData.BorderStyle = BorderStyle.None;
            planData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planData.Location = new Point(557, 54);
            planData.Name = "planData";
            planData.ReadOnly = true;
            planData.RowHeadersVisible = false;
            planData.RowHeadersWidth = 51;
            planData.Size = new Size(347, 650);
            planData.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(213, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 35);
            label2.TabIndex = 7;
            label2.Text = "Course";
            // 
            // courseData
            // 
            courseData.AllowUserToAddRows = false;
            courseData.AllowUserToDeleteRows = false;
            courseData.AllowUserToResizeColumns = false;
            courseData.AllowUserToResizeRows = false;
            courseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            courseData.BorderStyle = BorderStyle.None;
            courseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseData.Location = new Point(0, 54);
            courseData.Name = "courseData";
            courseData.ReadOnly = true;
            courseData.RowHeadersVisible = false;
            courseData.RowHeadersWidth = 51;
            courseData.Size = new Size(523, 650);
            courseData.TabIndex = 0;
            // 
            // CourseView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseView";
            Text = "CourseView";
            Load += CourseView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planData).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView courseData;
        private DataGridView planData;
        private Label label1;
    }
}