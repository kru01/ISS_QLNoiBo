using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.General_Forms
{
    public partial class Account : Form
    {
        readonly OracleConnection conn;

        public Account(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT * FROM A01_QLNOIBO.V_NHANSU_NV";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDBox.Text = reader["MANV"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    genderBox.Text = reader["PHAI"].ToString();
                    phoneBox.Text = reader["DT"].ToString();
                    bdayBox.Text = reader["NGSINH"].ToString();
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
            String sql = $"UPDATE A01_QLNOIBO.V_NHANSU_NV SET DT='{phoneBox.Text}'";
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