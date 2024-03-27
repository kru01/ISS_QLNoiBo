using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class CourseManager : Form
    {
        readonly String courseSql = "SELECT * FROM A01_QLNOIBO.HOCPHAN ORDER BY MAHP";

        readonly String planSql = "SELECT KH.MAHP, HP.TENHP, KH.HK, KH.NAM, KH.MACT " +
            "FROM A01_QLNOIBO.KHMO KH JOIN A01_QLNOIBO.HOCPHAN HP ON KH.MAHP=HP.MAHP " +
            "ORDER BY MAHP";

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public CourseManager()
        {
            InitializeComponent();
        }

        private void CourseManager_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adpCourse = new(courseSql, conn);
            OracleDataAdapter adpPlan = new(planSql, conn);

            try
            {
                DataTable dtCourse = new();
                DataTable dtPlan = new();
                adpCourse.Fill(dtCourse);
                adpPlan.Fill(dtPlan);
                courseData.DataSource = dtCourse;
                planData.DataSource = dtPlan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == courseData.RowCount) return;
            DataGridViewRow cRow = courseData.Rows[e.RowIndex];

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            courseName.Text = cRow.Cells["TENHP"].Value.ToString();
            creditBox.Text = cRow.Cells["SOTC"].Value.ToString();
            slotBox.Text = cRow.Cells["SOSVTD"].Value.ToString();
        }

        private void planData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == planData.RowCount) return;
            DataGridViewRow cRow = planData.Rows[e.RowIndex];

            courseID2.Text = cRow.Cells["MAHP"].Value.ToString();
            courseName2.Text = cRow.Cells["TENHP"].Value.ToString();
            semesterBox.Text = cRow.Cells["HK"].Value.ToString();
            yearBox.Text = cRow.Cells["NAM"].Value.ToString();
        }

        private void creditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void slotBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void semesterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}