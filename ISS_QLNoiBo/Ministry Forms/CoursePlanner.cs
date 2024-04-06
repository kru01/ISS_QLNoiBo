using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class CoursePlanner : Form
    {
        readonly OracleConnection conn;
        readonly OracleConnection adConn = new($"Data Source = {OracleConfig.connString};" +
                    $"User Id = AD0001;password = 123;");

        readonly string orderSql = "ORDER BY KH.MACT, KH.NAM, KH.HK, KH.MAHP";
        readonly string sql = $"SELECT KH.MACT, KH.NAM, KH.HK, KH.MAHP, HP.TENHP " +
            $"FROM {OracleConfig.schema}.KHMO KH JOIN {OracleConfig.schema}.HOCPHAN HP ON KH.MAHP = HP.MAHP";

        public CoursePlanner(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CoursePlanner_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
            String crsSql = $"SELECT * FROM {OracleConfig.schema}.HOCPHAN ORDER BY MAHP";
            String progSql = $"SELECT * FROM {OracleConfig.schema}.CTDAOTAO ORDER BY MACT";
            try
            {
                CrsIDCbo.DisplayMember = "MAHP";
                CrsIDCbo.ValueMember = "MAHP";
                CrsIDCbo.DataSource = Helper.getData(crsSql, conn).Tables[0];
                CrsNameCbo.DisplayMember = "TENHP";
                CrsNameCbo.ValueMember = "MAHP";
                CrsNameCbo.DataSource = Helper.getData(crsSql, conn).Tables[0];

                ProgIDCbo.DisplayMember = "MACT";
                ProgIDCbo.ValueMember = "MACT";
                ProgIDCbo.DataSource = Helper.getData(progSql, adConn).Tables[0];
                ProgNameCbo.DisplayMember = "TENCT";
                ProgNameCbo.ValueMember = "MACT";
                ProgNameCbo.DataSource = Helper.getData(progSql, adConn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", OpenCrsData, conn);
        }

        private void OpenCrsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == OpenCrsData.RowCount) return;
            DataGridViewRow cRow = OpenCrsData.Rows[e.RowIndex];

            CrsIDCbo.Text = cRow.Cells["MAHP"].Value.ToString();
            SemUpDown.Value = Convert.ToInt32(cRow.Cells["HK"].Value.ToString());
            YearUpDown.Value = Convert.ToInt32(cRow.Cells["NAM"].Value.ToString());
            ProgIDCbo.Text = cRow.Cells["MACT"].Value.ToString();
        }

        private void ProgIDCbo_TextChanged(object sender, EventArgs e)
        {
            ProgNameCbo.SelectedValue = ProgIDCbo.Text;
        }

        private void CrsIDCbo_TextChanged(object sender, EventArgs e)
        {
            CrsNameCbo.SelectedValue = CrsIDCbo.Text;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String upSql = $"UPDATE {OracleConfig.schema}.KHMO " +
                $"SET MAHP='{CrsIDCbo.Text}', HK='{SemUpDown.Value}', NAM={YearUpDown.Value}, " +
                    $"MACT='{ProgIDCbo.Text}' WHERE MAHP='{CrsIDCbo.Text}' AND HK='{SemUpDown.Value}' " +
                    $"AND NAM={YearUpDown.Value} AND MACT='{ProgIDCbo.Text}'";
            OracleCommand cmd = new(upSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData($"{sql} WHERE KH.MAHP='{CrsIDCbo.Text}' AND KH.HK='{SemUpDown.Value}' " +
                    $"AND KH.NAM={YearUpDown.Value} AND MACT='{ProgIDCbo.Text}'", OpenCrsData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String inSql = $"INSERT INTO {OracleConfig.schema}.KHMO VALUES('{CrsIDCbo.Text}', " +
                $"'{SemUpDown.Value}', {YearUpDown.Value}, '{ProgIDCbo.Text}')";
            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                Helper.refreshData($"{sql} WHERE KH.MAHP='{CrsIDCbo.Text}' AND KH.HK='{SemUpDown.Value}' " +
                    $"AND KH.NAM={YearUpDown.Value} AND MACT='{ProgIDCbo.Text}'", OpenCrsData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }
    }
}