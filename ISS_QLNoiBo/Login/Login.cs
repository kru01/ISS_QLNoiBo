using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Employee_Forms;
using ISS_QLNoiBo.Lecturer_Forms;
using ISS_QLNoiBo.Student_Forms;
using ISS_QLNoiBo.Ministry_Forms;
using ISS_QLNoiBo.UnitHead_Forms;
using ISS_QLNoiBo.DeptHead_Forms;
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
            if (String.IsNullOrWhiteSpace(username.Text) || String.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string connStr = $"Data Source = {OracleConfig.connString};" +
                    $"User Id = {username.Text};password = {password.Text};";

                OracleConnection conn = new(connStr);

                try
                { 
                    conn.Open();
                    this.Hide();
                    string type = username.Text[..2];

                    if (type == "AD")
                    {
                        Admin_Main form = new(username.Text, connStr);
                        form.ShowDialog();
                    }

                    else if (type == "NV")
                    {
                        Emp_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type[0] == 'V')
                    {
                        Lecturer_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type == "GV")
                    {
                        Ministry_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type == "TD")
                    {
                        UnitHead_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type == "TK")
                    {
                        DeptHead_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type[0] == 'S')
                    {
                        Student_Main form = new(connStr);
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
