using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class ClassView : Form
    {
        readonly string sql = $"SELECT * FROM {OracleConfig.schema}.DANGKY " +
            $"ORDER BY NAM, HK, MACT, MAHP, MAGV, MASV";
        readonly OracleConnection conn;

        public ClassView(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ClassView_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.refreshData(sql, classViewData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == classViewData.RowCount) return;
            DataGridViewRow cRow = classViewData.Rows[e.RowIndex];

            stuID.Text = cRow.Cells["MASV"].Value.ToString();
            lectID.Text = cRow.Cells["MAGV"].Value.ToString();
            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            semBox.Text = cRow.Cells["HK"].Value.ToString();
            yearBox.Text = cRow.Cells["NAM"].Value.ToString();
            progID.Text = cRow.Cells["MACT"].Value.ToString();
            eScore.Text = cRow.Cells["DIEMTH"].Value.ToString();
            pScore.Text = cRow.Cells["DIEMQT"].Value.ToString();
            fScore.Text = cRow.Cells["DIEMCK"].Value.ToString();
            aScore.Text = cRow.Cells["DIEMTK"].Value.ToString();
        }
    }
}
