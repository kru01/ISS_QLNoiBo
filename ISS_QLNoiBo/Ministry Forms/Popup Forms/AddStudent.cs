﻿using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    public partial class AddStudent : Form
    {
        public event EventHandler FormClosedEvent;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public string order = string.Empty;

        public AddStudent()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(studentName.Text) ||
                String.IsNullOrWhiteSpace(addressBox.Text) ||
                String.IsNullOrWhiteSpace(phoneBox.Text) ||
                String.IsNullOrWhiteSpace(studentID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String updateSql = $"INSERT INTO A01_QLNOIBO.SINHVIEN " +
                    $"SELECT '{studentID.Text}', '{studentName.Text}', '{genderCbo.Text}', '{bdayBox.Text}', " +
                    $"'{addressBox.Text}', '{phoneBox.Text}', '{programCbo.Text}', '{majorCbo.Text}', 0, 0, '{facilityCbo.Text}' " +
                    $"FROM DUAL UNION ALL";

                OracleCommand cmd = new(updateSql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm sinh viên?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}