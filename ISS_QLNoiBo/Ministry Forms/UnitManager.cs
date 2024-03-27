using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class UnitManager : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        readonly String sql = "SELECT DV.*, NS.HOTEN " +
            "FROM A01_QLNOIBO.DONVI DV JOIN A01_QLNOIBO.NHANSU NS ON DV.TRGDV = NS.MANV " +
            "ORDER BY DV.MADV";

        public UnitManager()
        {
            InitializeComponent();
        }

        private void UnitManager_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                unitData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unitData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == unitData.RowCount) return;
            DataGridViewRow cRow = unitData.Rows[e.RowIndex];

            unitName.Text = cRow.Cells["TENDV"].Value.ToString();
            unitID.Text = cRow.Cells["MADV"].Value.ToString();
            unitHeadID.Text = cRow.Cells["TRGDV"].Value.ToString();
            unitHeadName.Text = cRow.Cells["HOTEN"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(unitName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                String sql = $"UPDATE A01_QLNOIBO.DONVI " +
                    $"SET TENDV='{unitName.Text}' WHERE MADV='{unitID.Text}'";
                OracleCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    Helper.refreshData(sql, unitData);
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
            Helper.refreshData(sql, unitData);
        }
    }
}
