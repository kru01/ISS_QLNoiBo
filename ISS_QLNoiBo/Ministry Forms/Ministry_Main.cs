using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class Ministry_Main : Form
    {
        readonly OracleConnection conn;

        public Ministry_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Account f = new(conn);
            Helper.loadform(f, this.mainPanel);
        }

        private void Ministry_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM A01_QLNOIBO.V_NHANSU_NV";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ministryID.Text = reader["MANV"].ToString();
                    ministryName.Text = reader["HOTEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void studentMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new StudentManager(conn), this.mainPanel);
        }

        private void unitMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new UnitManager(conn), this.mainPanel);
        }

        private void courseMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new CourseManager(), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Assignment(conn), this.mainPanel);
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
