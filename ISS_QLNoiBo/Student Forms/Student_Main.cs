using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class Student_Main : Form
    {
        public string CurrentUser { get; set; } = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Student_Main()
        {
            InitializeComponent();
        }

        private void Student_Main_Load(object sender, EventArgs e)
        {
            studentID.Text = CurrentUser;

            String sql = $"SELECT HOTEN, MACT FROM A01_QLNOIBO.SINHVIEN WHERE MASV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
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
            Student_Account f = new Student_Account();
            f.CurrentUser = CurrentUser;
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

        private void courseButton_Click(object sender, EventArgs e)
        {
            CourseView f = new CourseView();
            f.Program = program.Text;
            Helper.loadform(f, this.mainPanel);
        }

        private void cRegistrationButton_Click(object sender, EventArgs e)
        {
            CourseReg f = new CourseReg();
            f.Program = program.Text;
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            ClassView f = new ClassView();
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }
    }
}
