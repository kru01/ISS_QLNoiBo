﻿using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms
{
    public partial class UnitManager : Form
    {
        readonly OracleConnection conn;
        readonly String orderSql = "ORDER BY MADV";
        readonly String sql = $"SELECT * FROM {OracleConfig.schema}.DONVI";

        public UnitManager(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void UnitManager_Load(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", unitData, conn);
        }

        private void unitData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == unitData.RowCount) return;
            DataGridViewRow cRow = unitData.Rows[e.RowIndex];

            unitName.Text = cRow.Cells["TENDV"].Value.ToString();
            unitID.Value = Convert.ToInt32(cRow.Cells["MADV"].Value.ToString());
            unitHeadID.Text = cRow.Cells["TRGDV"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(unitName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            String upSql = $"UPDATE {OracleConfig.schema}.DONVI " +
                $"SET TENDV='{unitName.Text}', TRGDV='{unitHeadID.Text}' " +
                $"WHERE MADV={unitID.Value}";
            OracleCommand cmd = new(upSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData($"{sql} WHERE MADV={unitID.Value}", unitData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if(conn.State != ConnectionState.Closed) conn.Close(); }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(unitName.Text) || 
                String.IsNullOrWhiteSpace(unitHeadID.Text) ||
                String.IsNullOrWhiteSpace(unitID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            String inSql = $"INSERT INTO {OracleConfig.schema}.DONVI VALUES({unitID.Value}, " +
                $"'{unitName.Text}', '{unitHeadID.Text}')";
            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                Helper.refreshData($"{sql} WHERE MADV={unitID.Value}", unitData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }
    }
}
