using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class Assignment : Form
    {
        readonly OracleConnection conn;
        readonly String orderSql = "ORDER BY PC.MACT, PC.NAM, PC.HK, PC.MAHP, PC.MAGV";
        readonly String sql = "SELECT PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, PC.MACT, DV.MADV, DV.TENDV " +
            $"FROM {OracleConfig.schema}.PHANCONG PC JOIN {OracleConfig.schema}.HOCPHAN HP ON HP.MAHP=PC.MAHP " +
                $"JOIN {OracleConfig.schema}.DONVI DV ON HP.MADV=DV.MADV";

        public Assignment(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void assignmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == assignmentData.RowCount) return;
            DataGridViewRow cRow = assignmentData.Rows[e.RowIndex];

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            lecturerID.Text = cRow.Cells["MAGV"].Value.ToString();
            semUpDown.Value = Int32.Parse(cRow.Cells["HK"].Value.ToString() ?? "1");
            yearUpDown.Value = Int32.Parse(cRow.Cells["NAM"].Value.ToString() ?? "2024");
            progCbo.Text = cRow.Cells["MACT"].Value.ToString();
            unitIDBox.Text = cRow.Cells["MADV"].Value.ToString();
            unitNameBox.Text = cRow.Cells["TENDV"].Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", assignmentData, conn);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string whereSql = $"WHERE MAHP='{courseID.Text}' AND HK='{semUpDown.Value}' AND NAM={yearUpDown.Value}" +
                $"AND MACT='{progCbo.Text}'";
            string upSql = $"UPDATE {OracleConfig.schema}.PHANCONG SET MAGV='{lecturerID.Text}' {whereSql}";

            whereSql = $"WHERE PC.MAHP='{courseID.Text}' AND PC.HK='{semUpDown.Value}' AND PC.NAM={yearUpDown.Value}" +
                $"AND PC.MACT='{progCbo.Text}'";
            string seSql = $"{sql} {whereSql} AND PC.MAGV='{lecturerID.Text}'";
            OracleCommand cmd = new(upSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData(seSql, assignmentData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
}
