namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    partial class AddUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUnit));
            panel1 = new Panel();
            unitName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            cancelButton = new Button();
            insertButton = new Button();
            unitHeadCbo = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(unitName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(unitHeadCbo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 353);
            panel1.TabIndex = 1;
            // 
            // unitName
            // 
            unitName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitName.Location = new Point(66, 100);
            unitName.Name = "unitName";
            unitName.PlaceholderText = "Unit Name";
            unitName.Size = new Size(350, 27);
            unitName.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(66, 149);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 35;
            label6.Text = "Unit Head";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(128, 15);
            label2.Name = "label2";
            label2.Size = new Size(226, 43);
            label2.TabIndex = 36;
            label2.Text = "Add New Unit";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.SteelBlue;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(266, 240);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 50);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.SteelBlue;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(66, 240);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(150, 50);
            insertButton.TabIndex = 34;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // unitHeadCbo
            // 
            unitHeadCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitHeadCbo.FormattingEnabled = true;
            unitHeadCbo.Items.AddRange(new object[] { "NAM", "NU" });
            unitHeadCbo.Location = new Point(66, 175);
            unitHeadCbo.Name = "unitHeadCbo";
            unitHeadCbo.Size = new Size(350, 27);
            unitHeadCbo.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(66, 74);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 30;
            label1.Text = "Unit Name";
            // 
            // AddUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Unit";
            Load += AddUnit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox facilityCbo;
        private TextBox unitName;
        private Label label6;
        private Label label;
        private Label label2;
        private Label label8;
        private ComboBox programCbo;
        private Label label7;
        private Button cancelButton;
        private Button insertButton;
        private Label label4;
        private ComboBox unitHeadCbo;
        private TextBox addressBox;
        private ComboBox majorCbo;
        private DateTimePicker bdayBox;
        private Label label1;
        private TextBox phoneBox;
        private Label label5;
    }
}