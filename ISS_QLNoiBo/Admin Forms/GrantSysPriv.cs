using System.Data;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class GrantSysPriv : Form
    {
        readonly OracleConnection conn;
        readonly String gridSql = "SELECT * FROM DBA_SYS_PRIVS";

        public GrantSysPriv(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void GrantSysPriv_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
            String sql = "SELECT \"NAME\" FROM SYSTEM_PRIVILEGE_MAP ORDER BY PRIVILEGE DESC";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataSet ds = new();
                adp.Fill(ds, "PRIVS");
                sysPrivilegedBox.DisplayMember = "NAME";
                sysPrivilegedBox.ValueMember = "NAME";
                sysPrivilegedBox.DataSource = ds.Tables["PRIVS"];
                sysPrivilegedBox.Text = "CREATE SESSION";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = gridSql + " WHERE GRANTEE IN (SELECT USERNAME " +
                    $"FROM DBA_USERS WHERE USER_ID > {(int)OracleConfig.UIDBounds.low} " +
                        $"AND USER_ID < {(int)OracleConfig.UIDBounds.high}) " +
                $"OR GRANTEE LIKE 'RL%' ORDER BY GRANTEE";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                gridData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createUButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text))
            {
                MessageBox.Show("Vui lòng nhập User hoặc Role!");
                return;
            }
            String sqlGr = $"GRANT {sysPrivilegedBox.Text} TO {username1.Text}";
            if (adminOptBox.Checked) sqlGr += " WITH ADMIN OPTION";
            OracleCommand cmd = new(sqlGr, conn);
            String sqlSe = gridSql + $" WHERE GRANTEE = '{username1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlGr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                gridData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlGr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text))
            {
                MessageBox.Show("Vui lòng nhập User hoặc Role!");
                return;
            }
            if (adminOptBox.Checked)
            {
                MessageBox.Show("Không dùng WITH ADMIN OPTION với REVOKE!");
                return;
            }
            String sqlRe = $"REVOKE {sysPrivilegedBox.Text} FROM {username1.Text}";
            OracleCommand cmd = new(sqlRe, conn);
            String sqlSe = gridSql + $" WHERE GRANTEE = '{username1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlRe} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                gridData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlRe} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == gridData.RowCount) return;
            DataGridViewRow cRow = gridData.Rows[e.RowIndex];
            username1.Text = cRow.Cells["GRANTEE"].Value.ToString();
            sysPrivilegedBox.Text = cRow.Cells["PRIVILEGE"].Value.ToString();
            adminOptBox.Checked = false;
        }
    }
}
