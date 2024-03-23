using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class StudentManager : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        readonly String studentSql = "SELECT * FROM A01_QLNOIBO.SINHVIEN ORDER BY MASV";

        public StudentManager()
        {
            InitializeComponent();
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new(studentSql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == studentData.RowCount) return;
            DataGridViewRow cRow = studentData.Rows[e.RowIndex];

            studentID.Text = cRow.Cells["MASV"].Value.ToString();
            studentName.Text = cRow.Cells["HOTEN"].Value.ToString();
            bdayBox.Text = cRow.Cells["NGSINH"].Value.ToString();
            genderCbo.Text = cRow.Cells["PHAI"].Value.ToString();
            label.Text = cRow.Cells["MACT"].Value.ToString();
            majorCbo.Text = cRow.Cells["MANGANH"].Value.ToString();
            phoneBox.Text = cRow.Cells["DT"].Value.ToString();
            addressBox.Text = cRow.Cells["DCHI"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(studentName.Text) ||
                String.IsNullOrWhiteSpace(addressBox.Text) ||
                String.IsNullOrWhiteSpace(phoneBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String updateSql = $"UPDATE SINHVIEN SET " +
                    $"HOTEN = '{studentName.Text}', " +
                    $"PHAI = '{genderCbo.Text}', " +
                    $"NGSINH = '{bdayBox.Text}', " +
                    $"DCHI = '{addressBox.Text}', " +
                    $"DT = '{phoneBox.Text}', " +
                    $"MACT = '{programCbo.Text}', " +
                    $"MANGANH = '{majorCbo.Text}', " +
                    $"WHERE MASV = '{studentID.Text}'";
                OracleCommand cmd = new(updateSql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Helper.refreshData(studentSql, studentData);
                }
                finally { conn.Close(); }
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(studentSql, studentData);
        }
    }
}
