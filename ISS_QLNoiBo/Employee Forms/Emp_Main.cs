using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Employee_Forms
{
    public partial class Emp_Main : Form
    {
        readonly OracleConnection conn;

        public Emp_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void Emp_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM A01_QLNOIBO.V_NHANSU_NV";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empID.Text = reader["MANV"].ToString();
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
            Account f = new(conn);
            Helper.loadform(f, this.mainPanel);
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Student(conn), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(conn), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Announcement(conn), this.mainPanel);
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
