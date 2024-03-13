using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = username;
            username.Focus();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                loginButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username.Focus();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string connString = "Data Source = (DESCRIPTION = " +
                    "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                    "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE));" +
                    $"User Id = {username.Text};password = {password.Text};";

                OracleConnection conn = new(connString);

                try
                { 
                    conn.Open();
                    this.Hide();

                    if (username.Text[..2] == "AD")
                    {
                        Admin_Main form = new();
                        form.Show();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
