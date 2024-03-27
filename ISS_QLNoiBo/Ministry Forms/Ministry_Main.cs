using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class Ministry_Main : Form
    {
        public string CurrentUser = string.Empty;
        public string ministryConn = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Ministry_Main()
        {
            InitializeComponent();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Account f = new();
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }

        private void Ministry_Main_Load(object sender, EventArgs e)
        {
            ministryID.Text = CurrentUser;

            String sql = $"SELECT HOTEN FROM A01_QLNOIBO.NHANSU WHERE MANV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
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
            StudentManager f = new();
            f.ministryConn = ministryConn;
            Helper.loadform(new StudentManager(), this.mainPanel);
        }

        private void unitMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new UnitManager(), this.mainPanel);
        }

        private void courseMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new CourseManager(), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Assignment(), this.mainPanel);
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
