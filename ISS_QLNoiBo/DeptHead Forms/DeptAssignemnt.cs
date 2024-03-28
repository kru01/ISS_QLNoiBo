using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptAssignemnt : Form
    {
        readonly OracleConnection conn;
        readonly String orderSql = "ORDER BY PC.MACT, PC.NAM, PC.HK, PC.MAHP, PC.MAGV";
        readonly String sql = "SELECT PC.MAGV, NS.HOTEN, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, " +
                    "PC.MACT, DV.MADV, DV.TENDV " +
                $"FROM {OracleConfig.schema}.PHANCONG PC " +
                    $"JOIN {OracleConfig.schema}.HOCPHAN HP ON PC.MAHP=HP.MAHP " +
                    $"JOIN {OracleConfig.schema}.DONVI DV ON DV.MADV=HP.MADV " +
                    $"JOIN {OracleConfig.schema}.NHANSU NS ON NS.MANV=PC.MAGV";

        public DeptAssignemnt(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void DeptAssignemnt_Load(object sender, EventArgs e)
        {
            String lecturerSql = $"SELECT MANV, HOTEN FROM {OracleConfig.schema}.NHANSU ORDER BY HOTEN";
            String courseSql = $"SELECT MAHP, TENHP FROM {OracleConfig.schema}.HOCPHAN ORDER BY TENHP";
            try
            {
                refreshButton.PerformClick();

                lecturerCbo.DisplayMember = "HOTEN";
                lecturerCbo.ValueMember = "MANV";
                lecturerCbo.DataSource = Helper.getData(lecturerSql, conn).Tables[0];

                courseCbo.DisplayMember = "TENHP";
                courseCbo.ValueMember = "MAHP";
                courseCbo.DataSource = Helper.getData(courseSql, conn).Tables[0];
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

            lecturerCbo.Text = cRow.Cells["HOTEN"].Value.ToString();
            courseCbo.Text = cRow.Cells["TENHP"].Value.ToString();
            semUpDown.Value = Int32.Parse(cRow.Cells["HK"].Value.ToString());
            yearUpDown.Value = Int32.Parse(cRow.Cells["NAM"].Value.ToString());
            programCbo.Text = cRow.Cells["MACT"].Value.ToString();
            unitIDBox.Text = cRow.Cells["MADV"].Value.ToString();
            unitNameBox.Text = cRow.Cells["TENDV"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string? lect = lecturerCbo?.SelectedValue?.ToString();
            string? crs = courseCbo?.SelectedValue?.ToString();
            string whereSql = $"WHERE MAHP='{crs}' AND HK='{semUpDown.Value}' AND NAM={yearUpDown.Value} " +
                $"AND MACT='{programCbo.Text}'";
            String upSql = $"UPDATE {OracleConfig.schema}.PHANCONG SET MAGV = '{lect}' {whereSql}";
            OracleCommand cmd = new(upSql, conn);

            whereSql = $"WHERE PC.MAHP='{crs}' AND PC.HK='{semUpDown.Value}' AND PC.NAM={yearUpDown.Value} " +
                $"AND PC.MACT='{programCbo.Text}'";
            string seSql = $"{sql} {whereSql} AND PC.MAGV='{lect}'";
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", assignmentData, conn);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa thông tin phân công này?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string? lect = lecturerCbo?.SelectedValue?.ToString();
                string? crs = courseCbo?.SelectedValue?.ToString();
                String deleteSql = $"DELETE FROM {OracleConfig.schema}.PHANCONG " +
                    $"WHERE MAGV='{lect}' AND MAHP='{crs}' AND HK='{semUpDown.Value}' " +
                        $"AND NAM={yearUpDown.Value} AND MACT='{programCbo.Text}'";
                OracleCommand cmd = new(deleteSql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa phân công thành công!");
                    refreshButton.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            }
        }
    }
}
