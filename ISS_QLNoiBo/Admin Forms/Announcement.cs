using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class Announcement : Form
    {
        readonly OracleConnection conn;
        readonly String gridSql = $"SELECT MATB, NOIDUNG, LABEL_TO_CHAR(LAB_TB) \"LAB_TB\"" +
            $"FROM {OracleConfig.schema}.THONGBAO";
        readonly String orderSql = "ORDER BY MATB";

        public Announcement(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Announcement_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
            String selLabSql = "SELECT LABEL FROM DBA_SA_LABELS ORDER BY LABEL_TAG DESC";
            OracleDataAdapter adp = new(selLabSql, conn);
            try
            {
                DataSet ds = new();
                adp.Fill(ds, "ALL_LABS");
                LabelCbo.DisplayMember = "LABEL";
                LabelCbo.ValueMember = "LABEL";
                LabelCbo.DataSource = ds.Tables["ALL_LABS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnnData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == AnnData.RowCount) return;
            DataGridViewRow cRow = AnnData.Rows[e.RowIndex];
            AnnIDUpDown.Value = (decimal)cRow.Cells["MATB"].Value;
            LabelCbo.Text = cRow.Cells["LAB_TB"].Value.ToString();
            ContentBox.Text = cRow.Cells["NOIDUNG"].Value.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{gridSql} {orderSql}", AnnData, conn);
            AnnData.Columns[1].Width = 400;
            AnnData.Columns[2].Width = 300;
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ContentBox.Text))
            {
                MessageBox.Show("Vui lòng nhập thông báo!");
                return;
            }

            String postSql = $"INSERT INTO {OracleConfig.schema}.THONGBAO VALUES ({AnnIDUpDown.Value}, " +
                $"'{ContentBox.Text}', CHAR_TO_LABEL('{OracleConfig.olsPolicy}', '{LabelCbo.Text}'))";
            OracleCommand cmd = new(postSql, conn);
            String seSql = gridSql + $" WHERE MATB = {AnnIDUpDown.Value}";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{postSql} thành công!");
                Helper.refreshData(seSql, AnnData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{postSql} thất bại! " + ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String delSql = $"DELETE FROM {OracleConfig.schema}.THONGBAO WHERE MATB = {AnnIDUpDown.Text}";
            OracleCommand cmd = new(delSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{delSql} thành công!");
                RefreshButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{delSql} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
