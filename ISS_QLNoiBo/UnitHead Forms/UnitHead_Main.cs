using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.UnitHead_Forms
{
    public partial class UnitHead_Main : Form
    {
        readonly OracleConnection conn;

        public UnitHead_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
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

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new UnitAssignment(conn), this.mainPanel);
        }

        private void UnitHead_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM A01_QLNOIBO.V_NHANSU_NV";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    unitHeadID.Text = reader["MANV"].ToString();
                    unitHeadName.Text = reader["HOTEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
