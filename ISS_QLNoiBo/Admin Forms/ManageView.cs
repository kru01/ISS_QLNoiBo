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
    public partial class ManageView : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");
        readonly String gridSql = "SELECT OWNER, VIEW_NAME, TEXT_LENGTH, TEXT_VC, READ_ONLY, ORIGIN_CON_ID " +
            "FROM DBA_VIEWS WHERE OWNER = 'A01_QLNOIBO'";
        public ManageView()
        {
            InitializeComponent();
        }

        private void ManageView_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
            String sql = "SELECT TABLE_NAME FROM DBA_TABLES " +
                "WHERE OWNER = 'A01_QLNOIBO' ORDER BY TABLE_NAME";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataSet ds = new();
                adp.Fill(ds, "TABLES");
                tableCboBox.DisplayMember = "TABLE_NAME";
                tableCboBox.ValueMember = "TABLE_NAME";
                tableCboBox.DataSource = ds.Tables["TABLES"];
                tableCboBox.Text = "COSO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == viewsData.RowCount) return;
            DataGridViewRow cRow = viewsData.Rows[e.RowIndex];
            viewname.Text = cRow.Cells["VIEW_NAME"].Value.ToString();

            String? sql = cRow.Cells["TEXT_VC"].Value.ToString();
            checkCkBox.Checked = sql!.Contains("WITH CHECK OPTION");
            readCkBox.Checked = cRow.Cells["READ_ONLY"].Value.ToString() != "N";

            int end = sql.Length;
            if (sql.Contains("WHERE")) end = sql.IndexOf("WHERE");
            else if (sql.Contains("WITH")) end = sql.IndexOf("WITH");

            String table = sql[(sql.IndexOf("FROM") + "FROM ".Length)..end];
            tableCboBox.Text = table.Trim();

            if (sql.Contains("SELECT *")) colText.Text = "";
            else
            {
                String col = sql["SELECT ".Length..sql.IndexOf("FROM")];
                colText.Text = col.Replace("\"", "").Trim();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new(gridSql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                viewsData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createRButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(viewname.Text))
            {
                MessageBox.Show("Vui lòng nhập View!");
                return;
            }
            String view = viewname.Text.StartsWith("V_")
                ? viewname.Text : $"V_{viewname.Text}";
            String sqlCr = $"CREATE VIEW {OracleConfig.schema}.{view} AS SELECT ";
            sqlCr += $"{(String.IsNullOrWhiteSpace(colText.Text) ? "*"
                : colText.Text)} FROM {tableCboBox.Text}";

            if (checkCkBox.Checked) sqlCr += " WITH CHECK OPTION";
            if (readCkBox.Checked) sqlCr += " WITH READ ONLY";

            OracleCommand cmd = new(sqlCr, conn);
            String sqlSe = gridSql + $" AND VIEW_NAME = '{view}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlCr} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                viewsData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlCr} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void deleteRButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(viewname.Text))
            {
                MessageBox.Show("Vui lòng nhập Role!");
                return;
            }
            String sql = $"DROP VIEW {OracleConfig.schema}.{viewname.Text} CASCADE CONSTRAINTS";
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
            if (String.IsNullOrWhiteSpace(viewname.Text))
            {
                MessageBox.Show("Vui lòng nhập View!");
                return;
            }
            String view = viewname.Text.StartsWith("V_")
                ? viewname.Text : $"V_{viewname.Text}";
            String sqlAl = $"CREATE OR REPLACE VIEW {OracleConfig.schema}.{view} AS SELECT ";
            sqlAl += $"{(String.IsNullOrWhiteSpace(colText.Text) ? "*"
                : colText.Text)} FROM {tableCboBox.Text}";

            if (checkCkBox.Checked) sqlAl += " WITH CHECK OPTION";
            if (readCkBox.Checked) sqlAl += " WITH READ ONLY";

            OracleCommand cmd = new(sqlAl, conn);
            String sqlSe = gridSql + $" AND VIEW_NAME = '{view}'";
            OracleDataAdapter adp = new(sqlSe, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{sqlAl} thành công!");
                DataTable dt = new();
                adp.Fill(dt);
                viewsData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{sqlAl} thất bại! " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void checkCkBox_CheckedChanged(object sender, EventArgs e)
        {
            readCkBox.Checked = !checkCkBox.Checked;
        }

        private void readCkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkCkBox.Checked = !readCkBox.Checked;
        }

        private void colCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colText.Text.Contains(colCboBox.Text)) return;
            if (String.IsNullOrWhiteSpace(colText.Text))
                colText.Text = colCboBox.Text;
            else colText.Text += $",{colCboBox.Text}";
        }

        private void tableCboBox_TextChanged(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new("SELECT COLUMN_NAME FROM DBA_TAB_COLUMNS " +
                $"WHERE OWNER = '{OracleConfig.schema}' " +
                $"AND TABLE_NAME = '{tableCboBox?.Text}'", conn);
            try
            {
                DataSet ds = new();
                adp.Fill(ds, "COLS");
                colCboBox.DisplayMember = "COLUMN_NAME";
                colCboBox.ValueMember = "COLUMN_NAME";
                colCboBox.DataSource = ds.Tables["COLS"];
                colText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
