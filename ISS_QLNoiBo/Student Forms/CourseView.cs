using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class CourseView : Form
    {
        readonly OracleConnection conn;

        public CourseView(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CourseView_Load(object sender, EventArgs e)
        {
            String crsSql = $"SELECT * FROM {OracleConfig.schema}.HOCPHAN ORDER BY MAHP";
            String planSql = $"SELECT * FROM {OracleConfig.schema}.KHMO ORDER BY MAHP, HK, NAM, MACT";
            try
            {
                Helper.refreshData(crsSql, courseData, conn);
                Helper.refreshData(planSql, planData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
