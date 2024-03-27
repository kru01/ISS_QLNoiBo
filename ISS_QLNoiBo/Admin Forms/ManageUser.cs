using System.Data;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class ManageUser : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");
        readonly String gridSql = "SELECT US.USERNAME, US.USER_ID, US.\"PASSWORD\", US.ACCOUNT_STATUS, " +
            "US.LOCK_DATE, US.EXPIRY_DATE, US.DEFAULT_TABLESPACE, US.CREATED, " +
            "US.AUTHENTICATION_TYPE, US.LAST_LOGIN, US.PASSWORD_CHANGE_DATE, " +
            "QU.TABLESPACE_NAME \"QUOTA_TABLESPACE\", QU.BYTES \"QUOTA_BYTES\", " +
            "QU.MAX_BYTES \"QUOTA_MAX_BYTES\" " +
            "FROM DBA_USERS US LEFT JOIN DBA_TS_QUOTAS QU ON US.USERNAME = QU.USERNAME";
        public ManageUser()
        {
            InitializeComponent();
            this.Load += ManageUsers_Load;
        }

        private void ManageUsers_Load(object? sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void createUButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text)
                || String.IsNullOrWhiteSpace(password1.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            String sqlCr = $"CREATE USER {username1.Text} IDENTIFIED BY {password1.Text}";
            OracleCommand cmd = new(sqlCr, conn);
            String sqlSe = gridSql + $" WHERE US.USERNAME = '{username1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            sqlCr = $"{sqlCr[..(sqlCr.IndexOf("IDENTIFIED BY") + "IDENTIFIED BY".Length)]} *";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlCr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
                username2.Text = username1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlCr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username2.Text))
            {
                MessageBox.Show("Vui lòng nhập user muốn delete!");
                return;
            }
            String sqlDr = $"DROP USER {username2.Text} CASCADE";
            OracleCommand cmd = new(sqlDr, conn);
            String sqlSe = gridSql + $" WHERE US.USER_ID > {(int)OracleConfig.UIDBounds.low} " +
                $"AND US.USER_ID < {(int)OracleConfig.UIDBounds.high} ORDER BY US.USERNAME";
            OracleDataAdapter adp = new(sqlSe, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlDr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlDr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username2.Text))
            {
                MessageBox.Show("Vui lòng nhập user muốn update!");
                return;
            }

            String sqlAl = $"ALTER USER {username2.Text} ";
            if (!String.IsNullOrWhiteSpace(password2.Text))
                sqlAl += $"IDENTIFIED BY {password2.Text} ";
            if (quotaUpDown.Value > 0)
                sqlAl += $"QUOTA {quotaUpDown.Value}M ON USERS ";
            else if (quotaUpDown.Value == -1)
                sqlAl += "QUOTA UNLIMITED ON USERS ";
            sqlAl += $"ACCOUNT {(lockAccBox.Checked ? "LOCK" : "UNLOCK")}";

            OracleCommand cmd = new(sqlAl, conn);
            String sqlSe = gridSql + $" WHERE US.USERNAME = '{username2.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);

            if (sqlAl.Contains("IDENTIFIED BY"))
                sqlAl = $"{sqlAl[..(sqlAl.IndexOf("IDENTIFIED BY") + "IDENTIFIED BY".Length)]} * " +
                    $"{sqlAl[(sqlAl.Contains("QUOTA")
                        ? sqlAl.IndexOf("QUOTA")
                        : sqlAl.IndexOf("ACCOUNT"))..]}";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlAl} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlAl} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void usersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == usersData.RowCount) return;
            DataGridViewRow cRow = usersData.Rows[e.RowIndex];
            username2.Text = cRow.Cells["USERNAME"].Value.ToString();
            if (cRow.Cells["ACCOUNT_STATUS"].Value.ToString() != "OPEN")
                lockAccBox.Checked = true;
            else lockAccBox.Checked = false;
            if (!String.IsNullOrWhiteSpace(cRow.Cells["QUOTA_MAX_BYTES"].Value.ToString()))
                quotaUpDown.Value = Convert.ToInt32(cRow.Cells["QUOTA_MAX_BYTES"].Value);
            else quotaUpDown.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = gridSql + $" WHERE US.USER_ID > {(int)OracleConfig.UIDBounds.low} " +
                $"AND US.USER_ID < {(int)OracleConfig.UIDBounds.high} ORDER BY US.USERNAME";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
