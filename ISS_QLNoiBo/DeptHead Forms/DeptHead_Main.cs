using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptHead_Main : Form
    {
        readonly OracleConnection conn;
        public DeptHead_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void DeptHead_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM A01_QLNOIBO.V_NHANSU_NV";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    deptHeadID.Text = reader["MANV"].ToString();
                    deptHeadName.Text = reader["HOTEN"].ToString();
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
            Helper.loadform(new Account(conn), this.mainPanel);
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Student(conn), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(conn), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new DeptAssignemnt(conn), this.mainPanel);
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

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new DeptEmployee(conn), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Announcement(conn), this.mainPanel);
        }
    }
}
