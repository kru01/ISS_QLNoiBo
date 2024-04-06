using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.General_Forms.Popup_Forms
{
    public partial class AddAssignment : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;
        readonly string sql = $"SELECT KH.MACT, KH.NAM, KH.HK, KH.MAHP, HP.TENHP, HP.MADV, DV.TENDV " +
            $"FROM {OracleConfig.schema}.KHMO KH JOIN {OracleConfig.schema}.HOCPHAN HP ON KH.MAHP = HP.MAHP " +
                $"JOIN {OracleConfig.schema}.DONVI DV ON HP.MADV = DV.MADV";
        readonly string orderSql = $"ORDER BY KH.MACT, KH.NAM, KH.HK, KH.MAHP";

        public AddAssignment(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void AddAssignment_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql}{(UnitCheck.Checked ?
                " AND HP.MADV = (SELECT MADV FROM A01_QLNOIBO.V_NHANSU_NV)" : "")} " +
                $"{orderSql}", KhmoData, conn);
        }

        private void KhmoData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == KhmoData.RowCount) return;
            DataGridViewRow cRow = KhmoData.Rows[e.RowIndex];

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            semUpDown.Value = Convert.ToInt32(cRow.Cells["HK"].Value.ToString());
            yearUpDown.Value = Convert.ToInt32(cRow.Cells["NAM"].Value.ToString());
            progCbo.Text = cRow.Cells["MACT"].Value.ToString();
            unitIDBox.Text = cRow.Cells["MADV"].Value.ToString();
            unitNameBox.Text = cRow.Cells["TENDV"].Value.ToString();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lecturerID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên!");
                return;
            }
            String inSql = $"INSERT INTO {OracleConfig.schema}.PHANCONG VALUES ('{lecturerID.Text}', " +
                $"'{courseID.Text}', '{semUpDown.Value}', {yearUpDown.Value}, '{progCbo.Text}')";

            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phân công thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm phân công?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) this.Close();
        }

        private void UnitCheck_CheckedChanged(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
        }
    }
}
