using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.CodeAnalysis;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class Privileges : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");
        readonly String gridSql = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE, \"TYPE\"";
        public Privileges()
        {
            InitializeComponent();
        }

        private void Privileges_Load(object sender, EventArgs e)
        {
            tableCboBox.SelectedItem = "COSO";

            String sql = gridSql + " FROM (SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE IN " +
                        "(SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS " +
                        "WHERE GRANTEE IN (SELECT MANV FROM A01_QLNOIBO.NHANSU)) " +
                    "UNION ALL " +
                    "SELECT * FROM DBA_TAB_PRIVS " +
                    "WHERE GRANTEE IN (SELECT MANV FROM A01_QLNOIBO.NHANSU))";
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

        private void grant1Button_Click(object sender, EventArgs e)
        {
            if (username1.Text == "" || role1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String sql = $"GRANT {role1.Text} TO {username1.Text}";
                OracleCommand cmd = new(sql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{sql} thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{sql} thất bại! " + ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void revoke1Button_Click(object sender, EventArgs e)
        {
            if (username1.Text == "" || role1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String sql = $"REVOKE {role1.Text} FROM {username1.Text}";
                OracleCommand cmd = new(sql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{sql} thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{sql} thất bại! " + ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void grant2Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập User hoặc Role!");
                return;
            }
            if (!String.IsNullOrWhiteSpace(columnBox.Text) && !updateBox.Checked)
            {
                MessageBox.Show("Cần Update để phân quyền trên cột!");
                return;
            }

            List<String> opts = [];
            if (insertBox.Checked) opts.Add("INSERT");
            if (selectBox.Checked) opts.Add("SELECT");
            if (updateBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(columnBox.Text))
                {
                    opts.Add($"UPDATE({columnBox.Text})");
                }
                else opts.Add("UPDATE");
            }
            if (deleteBox.Checked) opts.Add("DELETE");

            String sqlGr = $"GRANT {String.Join(", ", [.. opts])} "
                + $"ON {OracleConfig.schema}.{tableCboBox.Text} TO {textBox1.Text}";
            if (grantOptBox.Checked) sqlGr += " WITH GRANT OPTION";

            OracleCommand cmd = new(sqlGr, conn);
            String sqlSe = gridSql + $" FROM DBA_TAB_PRIVS WHERE GRANTEE = '{textBox1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlGr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlGr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void revoke2Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập User hoặc Role!");
                return;
            }
            if (grantOptBox.Checked)
            {
                MessageBox.Show("Không dùng WITH GRANT OPTION với REVOKE!");
                return;
            }
            if (!String.IsNullOrWhiteSpace(columnBox.Text))
            {
                MessageBox.Show("Chỉ có thể REVOKE trên cả TABLE, không trên COLUMN!");
                return;
            }
            List<String> opts = [];
            if (insertBox.Checked) opts.Add("INSERT");
            if (selectBox.Checked) opts.Add("SELECT");
            if (updateBox.Checked) opts.Add("UPDATE");
            if (deleteBox.Checked) opts.Add("DELETE");

            String sqlRe = $"REVOKE {String.Join(", ", [.. opts])} "
                + $"ON {OracleConfig.schema}.{tableCboBox.Text} FROM {textBox1.Text}";

            OracleCommand cmd = new(sqlRe, conn);
            String sqlSe = gridSql + $" FROM DBA_TAB_PRIVS WHERE GRANTEE = '{textBox1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlRe} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlRe} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void usersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == usersData.RowCount) return;
            DataGridViewRow cRow = usersData.Rows[e.RowIndex];
            textBox1.Text = cRow.Cells["GRANTEE"].Value.ToString();
            tableCboBox.Text = cRow.Cells["TABLE_NAME"].Value.ToString();

            selectBox.Checked = insertBox.Checked
                = updateBox.Checked = deleteBox.Checked = false;
            switch (cRow.Cells["PRIVILEGE"].Value.ToString())
            {
                case "SELECT":
                    selectBox.Checked = true;
                    break;
                case "INSERT":
                    insertBox.Checked = true;
                    break;
                case "UPDATE":
                    updateBox.Checked = true;
                    break;
                case "DELETE":
                    deleteBox.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = gridSql + " FROM (SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE IN " +
                        "(SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS " +
                        "WHERE GRANTEE IN (SELECT MANV FROM A01_QLNOIBO.NHANSU)) " +
                    "UNION ALL " +
                    "SELECT * FROM DBA_TAB_PRIVS " +
                    "WHERE GRANTEE IN (SELECT MANV FROM A01_QLNOIBO.NHANSU))";
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
