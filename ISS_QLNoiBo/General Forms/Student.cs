using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Others;
using System.Data;

namespace ISS_QLNoiBo.General_Forms
{
    public partial class Student : Form
    {
        readonly OracleConnection conn;

        public Student(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new("SELECT * FROM A01_QLNOIBO.SINHVIEN SV ORDER BY SV.MASV", conn);
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
