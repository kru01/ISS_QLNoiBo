using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS_QLNoiBo.Admin_Forms
{
    public partial class ManageRole : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");
        readonly String gridSql = "SELECT * FROM DBA_ROLES";
        public ManageRole()
        {
            InitializeComponent();
        }

        private void ManageRole_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void usersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == usersData.RowCount) return;
            DataGridViewRow cRow = usersData.Rows[e.RowIndex];
            username1.Text = cRow.Cells["ROLE"].Value.ToString();
            password1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = gridSql + " WHERE ORACLE_MAINTAINED = 'N'";
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

        private void createRButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text))
            {
                MessageBox.Show("Vui lòng nhập Role!");
                return;
            }
            String sqlCr = $"CREATE ROLE {username1.Text}";
            if (!String.IsNullOrWhiteSpace(password1.Text))
                sqlCr += $" IDENTIFIED BY {password1.Text}";
            OracleCommand cmd = new(sqlCr, conn);
            String sqlSe = gridSql + $" WHERE ROLE = '{username1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);

            if (sqlCr.Contains("IDENTIFIED BY"))
                sqlCr = $"{sqlCr[..(sqlCr.IndexOf("IDENTIFIED BY") + "IDENTIFIED BY".Length)]} *";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlCr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                usersData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlCr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void deleteRButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text))
            {
                MessageBox.Show("Vui lòng nhập Role!");
                return;
            }
            String sql = $"DROP ROLE {username1.Text}";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sql} thành công!");
                button3.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sql} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username1.Text))
            {
                MessageBox.Show("Vui lòng nhập Role!");
                return;
            }
            String sqlAl = $"ALTER ROLE {username1.Text}";
            if (!String.IsNullOrWhiteSpace(password1.Text))
                sqlAl += $" IDENTIFIED BY {password1.Text}";
            else sqlAl += " NOT IDENTIFIED";

            OracleCommand cmd = new(sqlAl, conn);
            String sqlSe = gridSql + $" WHERE ROLE = '{username1.Text}'";
            OracleDataAdapter adp = new(sqlSe, conn);

            if (sqlAl.Contains("IDENTIFIED BY"))
                sqlAl = $"{sqlAl[..(sqlAl.IndexOf("IDENTIFIED BY") + "IDENTIFIED BY".Length)]} *";

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
    }
}
