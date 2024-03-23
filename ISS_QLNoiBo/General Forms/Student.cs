using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.General_Forms
{
    public partial class Student : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new("SELECT * FROM A01_QLNOIBO.SINHVIEN ORDER BY MASV", conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
