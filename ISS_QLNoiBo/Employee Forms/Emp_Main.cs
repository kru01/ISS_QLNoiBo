using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Employee_Forms
{
    public partial class Emp_Main : Form
    {
        public string CurrentUser = string.Empty;

        public string employeeConn = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Emp_Main()
        {
            InitializeComponent();
        }

        private void Emp_Main_Load(object sender, EventArgs e)
        {
            empID.Text = CurrentUser;

            String sql = $"SELECT HOTEN FROM A01_QLNOIBO.NHANSU WHERE MANV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmpName.Text = reader["HOTEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentUser;
            f.connStr = employeeConn;
            Helper.loadform(f, this.mainPanel);
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Student(), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Announcement f = new();
            Helper.loadform(f, this.mainPanel);
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }
    }
}
