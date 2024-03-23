using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class CourseView : Form
    {
        public string Program { get; set; } = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public CourseView()
        {
            InitializeComponent();
        }

        private void CourseView_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT KH.MAHP, HP.TENHP, KH.HK, KH.NAM, KH.MACT " +
                $"FROM A01_QLNOIBO.KHMO KH JOIN A01_QLNOIBO.HOCPHAN HP ON HP.MAHP=KH.MAHP " +
                $"WHERE MACT='{Program}' " +
                $"ORDER BY KH.NAM, KH.HK, KH.MAHP";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                courseData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
