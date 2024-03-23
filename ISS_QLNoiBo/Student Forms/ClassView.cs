using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class ClassView : Form
    {

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public string CurrentUser { get; set; } = string.Empty;

        public ClassView()
        {
            InitializeComponent();
        }

        private void ClassView_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT DK.MAGV, NS.HOTEN, DK.MAHP, HP.TENHP, DK.HK, DK.NAM, DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK " +
                $"FROM A01_QLNOIBO.DANGKY DK JOIN A01_QLNOIBO.HOCPHAN HP ON DK.MAHP=HP.MAHP " +
                $"JOIN A01_QLNOIBO.NHANSU NS ON DK.MAGV=NS.MANV " +
                $"WHERE DK.MASV='{CurrentUser}' " +
                $"ORDER BY DK.NAM, DK.HK";

            OracleDataAdapter adp = new(sql, conn);

            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                classViewData.DataSource = dt;
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

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            courseName.Text = cRow.Cells["TENHP"].Value.ToString();
            eScore.Text = cRow.Cells["DIEMTH"].Value.ToString();
            pScore.Text = cRow.Cells["DIEMQT"].Value.ToString();
            fScore.Text = cRow.Cells["DIEMCK"].Value.ToString();
            aScore.Text = cRow.Cells["DIEMTK"].Value.ToString();
        }
    }
}
