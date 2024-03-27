using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Others;
using System.Data;

namespace ISS_QLNoiBo.Lecturer_Forms
{
    public partial class Assignment : Form
    {
        public string CurrentUser = string.Empty;
        public string lecturerConn = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Assignment()
        {
            InitializeComponent();
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT PC.MAGV, NS.HOTEN, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, PC.MACT " +
                $"FROM A01_QLNOIBO.PHANCONG PC JOIN A01_QLNOIBO.HOCPHAN HP ON PC.MAHP=HP.MAHP " +
                $"JOIN A01_QLNOIBO.NHANSU NS ON NS.MANV=PC.MAGV " +
                $"WHERE PC.MAGV='{CurrentUser}'";

            //OracleConnection conn = new(lecturerConn);
            OracleDataAdapter adp = new(sql, conn);

            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                assignmentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == assignmentData.RowCount) return;
            DataGridViewRow cRow = assignmentData.Rows[e.RowIndex];

            courseIDBox.Text = cRow.Cells["MAHP"].Value.ToString();
            programBox.Text = cRow.Cells["MACT"].Value.ToString();
            yearBox.Text = cRow.Cells["NAM"].Value.ToString();
            semesterBox.Text = cRow.Cells["HK"].Value.ToString();
            lecturerName.Text = cRow.Cells["HOTEN"].Value.ToString();
            courseName.Text = cRow.Cells["TENHP"].Value.ToString();
        }
    }
}
