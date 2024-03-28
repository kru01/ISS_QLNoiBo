using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class Student_Main : Form
    {
        readonly OracleConnection conn;

        public Student_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void Student_Main_Load(object sender, EventArgs e)
        {
            String sql = "SELECT MASV, HOTEN, MACT FROM A01_QLNOIBO.SINHVIEN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentID.Text = reader["MASV"].ToString();
                    studentName.Text = reader["HOTEN"].ToString();
                    program.Text = reader["MACT"].ToString();
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
            Helper.loadform(new Student_Account(conn), this.mainPanel);
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

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new CourseView(conn), this.mainPanel);
        }

        private void cRegistrationButton_Click(object sender, EventArgs e)
        {
            CourseReg f = new CourseReg();
            Helper.loadform(f, this.mainPanel);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ClassView(conn), this.mainPanel);
        }
    }
}
