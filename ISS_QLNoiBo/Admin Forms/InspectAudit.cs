using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class InspectAudit : Form
    {
        readonly OracleConnection conn;
        readonly String gridSql = $"SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, SCN, ACTION_NAME, " +
            $"OBJECT_SCHEMA, OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, OBJECT_PRIVILEGES, " +
            $"TARGET_USER, CURRENT_USER, UNIFIED_AUDIT_POLICIES, FGA_POLICY_NAME FROM UNIFIED_AUDIT_TRAIL";
        readonly String excludeSql = "DBUSERNAME NOT IN ('SYS', 'A01_QLNOIBO')";
        readonly String orderSql = "ORDER BY EVENT_TIMESTAMP";

        public InspectAudit(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Announcement_Load(object sender, EventArgs e)
        {
            ExSysDBCkbo.Checked = true;
            RefreshButton.PerformClick();
        }

        private void AnnData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == AuditData.RowCount) return;
            DataGridViewRow cRow = AuditData.Rows[e.RowIndex];
            userBox.Text = cRow.Cells["DBUSERNAME"].Value.ToString();
            scnBox.Text = cRow.Cells["SCN"].Value.ToString();
            sqlTextBox.Text = cRow.Cells["SQL_TEXT"].Value.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            String seSql = gridSql;
            if (ExSysDBCkbo.Checked) seSql += $" WHERE {excludeSql}";
            Helper.refreshData($"{seSql} {orderSql}", AuditData, conn);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userBox.Text))
            {
                MessageBox.Show("Vui lòng nhập username!");
                return;
            }
            String seSql = $"{gridSql} WHERE DBUSERNAME = '{userBox.Text}' {orderSql}";
            Helper.refreshData(seSql, AuditData, conn);
        }
    }
}
