using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            } else
            {
                string connString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    $"(HOST={OracleConfig.host})(PORT={OracleConfig.port})))(CONNECT_DATA=(SERVER=DEDICATED)" +
                    $"(SERVICE_NAME={OracleConfig.service})));User Id={username.Text};Password={password.Text};";

                OracleConnection conn = new(connString);

                try
                {
                    conn.Open();
                    this.Hide();

                    if (username.Text[..2] == "AD")
                    {
                        Admin_main form = new();
                        form.Show();
                    }

                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
                } finally { conn.Close(); }
            }
        }
    }
}
