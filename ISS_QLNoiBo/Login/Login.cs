using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Employee_Forms;
using ISS_QLNoiBo.Lecturer_Forms;
using ISS_QLNoiBo.Others;

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
                string connString = $"Data Source = {OracleConfig.connString};" +
                    $"User Id = {username.Text};password = {password.Text};";

                OracleConnection conn = new(connString);

                try
                { 
                    conn.Open();
                    this.Hide();

                    if (username.Text[..2] == "AD")
                    {
                        Admin_Main form = new();
                        form.CurrentUsername = username.Text;
                        form.ShowDialog();
                    }

                    else if (username.Text[..2] == "NV")
                    {
                        Emp_Main form = new();
                        form.CurrentUser = username.Text;
                        form.ShowDialog();
                    }

                    else if (username.Text[..1] == "V")
                    {
                        Lecturer_Main form = new();
                        form.CurrentUser = username.Text;
                        form.ShowDialog();
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
