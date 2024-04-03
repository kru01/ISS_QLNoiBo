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

namespace ISS_QLNoiBo.General_Forms
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
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{gridSql} {orderSql}", AnnData, conn);
            AnnData.Columns[1].Width = 400;
            AnnData.Columns[2].Width = 300;
        }

        private void AnnData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == AnnData.RowCount) return;
            DataGridViewRow cRow = AnnData.Rows[e.RowIndex];
            AnnIDUpDown.Value = (decimal)cRow.Cells["MATB"].Value;
            LabelCbo.Text = cRow.Cells["LAB_TB"].Value.ToString();
            ContentBox.Text = cRow.Cells["NOIDUNG"].Value.ToString();
        }
    }
}
