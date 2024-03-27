using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptHead_Main : Form
    {
        public string CurrentUser = string.Empty;

        public string deptHeadconn = string.Empty;

        public DeptHead_Main()
        {
            InitializeComponent();
        }

        private void DeptHead_Main_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new(deptHeadconn);
            deptHeadID.Text = CurrentUser;

            String sql = $"SELECT HOTEN FROM A01_QLNOIBO.NHANSU WHERE MANV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
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
            Account f = new();
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Student(), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            DeptAssignemnt f = new();
            f.CurrentUser = CurrentUser;
            f.deptHeadconn = deptHeadconn;
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

        private void employeeButton_Click(object sender, EventArgs e)
        {
            DeptEmployee f = new();
            f.CurrentUser = CurrentUser;
            f.deptHeadconn = deptHeadconn;
            Helper.loadform(f, this.mainPanel);
        }
    }
}
