using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptAssignemnt : Form
    {
        public string CurrentUser = string.Empty;

        public string deptHeadconn = string.Empty;

        readonly String sql = "SELECT PC.MAGV, NS.HOTEN, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, PC.MACT " +
                "FROM A01_QLNOIBO.PHANCONG PC " +
                "JOIN A01_QLNOIBO.HOCPHAN HP ON PC.MAHP=HP.MAHP " +
                "JOIN A01_QLNOIBO.DONVI DV ON DV.MADV=HP.MADV " +
                "JOIN A01_QLNOIBO.NHANSU NS ON NS.MANV=PC.MAGV " +
                "WHERE DV.TENDV='VAN PHONG KHOA' " +
                "ORDER BY PC.NAM, PC.HK";

        public DeptAssignemnt()
        {
            InitializeComponent();
        }

        private void DeptAssignemnt_Load(object sender, EventArgs e)
        {
            String lecturerSql = $"SELECT NS.MANV, NS.HOTEN " +
                $"FROM A01_QLNOIBO.NHANSU NS JOIN A01_QLNOIBO.DONVI DV ON NS.MADV=DV.MADV " +
                $"WHERE DV.TRGDV='{CurrentUser}'";

            String courseSql = $"SELECT HP.MAHP, HP.TENHP " +
                $"FROM A01_QLNOIBO.HOCPHAN HP JOIN A01_QLNOIBO.DONVI DV ON HP.MADV=DV.MADV " +
                $"WHERE DV.TRGDV='{CurrentUser}'";

            OracleConnection conn = new(deptHeadconn);
            OracleDataAdapter adp = new(sql, conn);

            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                assignmentData.DataSource = dt;

                lecturerCbo.DisplayMember = "HOTEN";
                lecturerCbo.ValueMember = "MAGV";
                lecturerCbo.DataSource = Helper.getData(lecturerSql).Tables[0];

                courseCbo.DisplayMember = "TENHP";
                courseCbo.ValueMember = "MAHP";
                courseCbo.DataSource = Helper.getData(courseSql).Tables[0];
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
            semesterBox.Text = cRow.Cells["HK"].Value.ToString();
            yearBox.Text = cRow.Cells["NAM"].Value.ToString();
            programCbo.Text = cRow.Cells["MACT"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(semesterBox.Text) < 1 || int.Parse(semesterBox.Text) > 3)
            {
                MessageBox.Show("Thông tin nhập không hợp lệ!");
            }
            else
            {
                OracleConnection conn = new(deptHeadconn);
                var itemL = (DataRowView)lecturerCbo.SelectedItem;
                var itemC = (DataRowView)courseCbo.SelectedItem;
                String updateSql = $"UPDATE A01_QLNOIBO.PHANCONG " +
                    $"SET MAHP='{itemC["MAHP"]}', " +
                    $"HK={int.Parse(semesterBox.Text)}, " +
                    $"NAME={int.Parse(yearBox.Text)}, " +
                    $"MACT='{programCbo.Text}' " +
                    $"WHERE MAGV='{itemL["MAGV"]}'";
                OracleCommand cmd = new(updateSql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    Helper.refreshData(sql, assignmentData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(sql, assignmentData);
        }

        private void semesterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && yearBox.Text.Contains('.'))
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
            if (e.KeyChar == '.' && yearBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new(deptHeadconn);
            var res = MessageBox.Show("Bạn có chắc là muốn xóa thông tin phân công này?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var itemL = (DataRowView)lecturerCbo.SelectedItem;
                var itemC = (DataRowView)courseCbo.SelectedItem;
                String deleteSql = $"DELETE FROM A01_QLNOIBO " +
                    $"WHERE MAGV='{itemL["MAGV"]}' AND MAHP='{itemC["MAHP"]}'";
                OracleCommand cmd = new(deleteSql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa phân công thành công!");
                    Helper.refreshData(sql, assignmentData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
