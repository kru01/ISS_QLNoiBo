using System.Data;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class InspectPriv : Form
    {
        readonly OracleConnection conn;
        readonly String sqlRole = "SELECT * FROM DBA_ROLE_PRIVS";
        readonly String sqlSys = "SELECT * FROM DBA_SYS_PRIVS";
        readonly String sqlTab = "SELECT * FROM DBA_TAB_PRIVS";

        public InspectPriv(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void InspectPriv_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void grant2Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userName.Text))
            {
                MessageBox.Show("Vui lòng nhập User hoặc Role!");
                return;
            }
            String grantee = $" WHERE GRANTEE = '{userName.Text}'";
            OracleDataAdapter adpRl = new(sqlRole + grantee, conn);
            OracleDataAdapter adpSys = new(sqlSys + grantee, conn);
            OracleDataAdapter adpTab = new(sqlTab + grantee, conn);
            try
            {
                DataTable dtRl = new();
                DataTable dtSys = new();
                DataTable dtTab = new();
                adpRl.Fill(dtRl);
                adpSys.Fill(dtSys);
                adpTab.Fill(dtTab);
                roleGrid.DataSource = dtRl;
                sysGrid.DataSource = dtSys;
                tableGrid.DataSource = dtTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String where = " WHERE GRANTEE IN (SELECT USERNAME " +
                        "FROM DBA_USERS WHERE USER_ID > 150 AND USER_ID < 1000000) " +
                    "OR GRANTEE LIKE 'RL%' ORDER BY GRANTEE";
            OracleDataAdapter adpRl = new(sqlRole + where, conn);
            OracleDataAdapter adpSys = new(sqlSys + where, conn);
            OracleDataAdapter adpTab = new(sqlTab + where, conn);
            try
            {
                DataTable dtRl = new();
                DataTable dtSys = new();
                DataTable dtTab = new();
                adpRl.Fill(dtRl);
                adpSys.Fill(dtSys);
                adpTab.Fill(dtTab);
                roleGrid.DataSource = dtRl;
                sysGrid.DataSource = dtSys;
                tableGrid.DataSource = dtTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == tableGrid.RowCount) return;
            DataGridViewRow cRow = tableGrid.Rows[e.RowIndex];
            userName.Text = cRow.Cells["GRANTEE"].Value.ToString();
        }

        private void roleGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == roleGrid.RowCount) return;
            DataGridViewRow cRow = roleGrid.Rows[e.RowIndex];
            userName.Text = cRow.Cells["GRANTEE"].Value.ToString();
        }

        private void sysGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == sysGrid.RowCount) return;
            DataGridViewRow cRow = sysGrid.Rows[e.RowIndex];
            userName.Text = cRow.Cells["GRANTEE"].Value.ToString();
        }
    }
}
