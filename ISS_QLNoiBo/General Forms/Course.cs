using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Others;
using System.Data;

namespace ISS_QLNoiBo.General_Forms
{
    public partial class Course : Form
    {
        readonly OracleConnection conn;
        public Course(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Course_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adpCourse = new("SELECT * FROM A01_QLNOIBO.HOCPHAN", conn);
            OracleDataAdapter adpUnit = new("SELECT * FROM A01_QLNOIBO.DONVI", conn);
            OracleDataAdapter adpPlan = new("SELECT * FROM A01_QLNOIBO.KHMO", conn);

            try
            {
                DataTable dtCourse = new();
                DataTable dtUnit = new();
                DataTable dtPlan = new();
                adpCourse.Fill(dtCourse);
                adpUnit.Fill(dtUnit);
                adpPlan.Fill(dtPlan);
                courseData.DataSource = dtCourse;
                unitData.DataSource = dtUnit;
                planData.DataSource = dtPlan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
