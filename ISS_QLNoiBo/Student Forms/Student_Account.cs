using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class Student_Account : Form
    {
        public string CurrentUser { get; set; } = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Student_Account()
        {
            InitializeComponent();
        }

        private void Student_Account_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT * FROM A01_QLNOIBO.SINHVIEN WHERE MASV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDBox.Text = reader["MASV"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    genderBox.Text = reader["PHAI"].ToString();
                    phoneBox.Text = reader["DT"].ToString();
                    bdayBox.Text = reader["NGSINH"].ToString();
                    addressBox.Text = reader["DCHI"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            String sql = $"UPDATE A01_QLNOIBO.SINHVIEN " +
                $"SET DT='{phoneBox.Text}', DCHI='{addressBox.Text}' " +
                $"WHERE MASV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
