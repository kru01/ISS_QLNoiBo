using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Lecturer_Forms
{
    public partial class Class : Form
    {
        public string CurrentUser { get; set; } = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Class()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT DK.MASV, SV.HOTEN, SV.PHAI, DK.MAHP, HP.TENHP, DK.HK, DK.NAM, DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK " +
                $"FROM A01_QLNOIBO.DANGKY DK JOIN A01_QLNOIBO.SINHVIEN SV ON DK.MASV=SV.MASV " +
                $"JOIN A01_QLNOIBO.HOCPHAN HP ON HP.MAHP=DK.MAHP " +
                $"WHERE DK.MAGV='{CurrentUser}' " +
                $"ORDER BY DK.MAHP, DK.MASV, DK.NAM, DK.HK";

            OracleDataAdapter adp = new(sql, conn);

            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                classData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == classData.RowCount) return;
            DataGridViewRow cRow = classData.Rows[e.RowIndex];

            studentID.Text = cRow.Cells["MASV"].Value.ToString();
            studentName.Text = cRow.Cells["HOTEN"].Value.ToString();
            eScore.Text = cRow.Cells["DIEMTH"].Value.ToString();
            pScore.Text = cRow.Cells["DIEMQT"].Value.ToString();
            fScore.Text = cRow.Cells["DIEMCK"].Value.ToString();
            aScore.Text = cRow.Cells["DIEMTK"].Value.ToString();
        }
    }
}
