using ISS_QLNoiBo.Ministry_Forms.Popup_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptEmployee : Form
    {
        AddEmployee? formAddEmp;
        readonly OracleConnection conn;
        readonly String orderSql = "ORDER BY NS.MANV";
        readonly String sql = "SELECT NS.MANV, NS.HOTEN, NS.PHAI, NS.NGSINH, NS.PHUCAP, NS.DT, " +
                "NS.VAITRO, VT.TENVT, NS.MADV, DV.TENDV, NS.MACS, CS.TENCS " +
            $"FROM {OracleConfig.schema}.NHANSU NS JOIN {OracleConfig.schema}.VAITRO VT ON NS.VAITRO = VT.MAVT " +
                $"JOIN {OracleConfig.schema}.DONVI DV ON NS.MADV = DV.MADV " +
                $"JOIN {OracleConfig.schema}.COSO CS ON NS.MACS = CS.MACS";

        public DeptEmployee(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void DeptEmployee_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
            String roleSql = $"SELECT * FROM {OracleConfig.schema}.VAITRO ORDER BY MAVT";
            String unitSql = $"SELECT MADV, TENDV FROM {OracleConfig.schema}.DONVI ORDER BY MADV";
            String branchSql = $"SELECT * FROM {OracleConfig.schema}.COSO ORDER BY MACS";
            try
            {
                RoleCbo.DisplayMember = "TENVT";
                RoleCbo.ValueMember = "MAVT";
                RoleCbo.DataSource = Helper.getData(roleSql, conn).Tables[0];

                UnitCbo.DisplayMember = "TENDV";
                UnitCbo.ValueMember = "MADV";
                UnitCbo.DataSource = Helper.getData(unitSql, conn).Tables[0];

                BranchCbo.DisplayMember = "TENCS";
                BranchCbo.ValueMember = "MACS";
                BranchCbo.DataSource = Helper.getData(branchSql, conn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", EmpData, conn);
        }

        private void EmpData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == EmpData.RowCount) return;
            DataGridViewRow cRow = EmpData.Rows[e.RowIndex];

            EmpIDBox.Text = cRow.Cells["MANV"].Value.ToString();
            EmpNameBox.Text = cRow.Cells["HOTEN"].Value.ToString();
            GenderCbo.Text = cRow.Cells["PHAI"].Value.ToString();
            BirthDateTime.Value = DateTime.Parse(cRow.Cells["NGSINH"].Value.ToString() ?? "01/01/2024");
            AllowanceUpDown.Value = Int32.Parse(cRow.Cells["PHUCAP"].Value.ToString() ?? "0");
            PhoneBox.Text = cRow.Cells["DT"].Value.ToString();
            RoleCbo.Text = cRow.Cells["TENVT"].Value.ToString();
            UnitCbo.Text = cRow.Cells["TENDV"].Value.ToString();
            BranchCbo.Text = cRow.Cells["TENCS"].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa nhân sự này?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            string delSql = $"DELETE FROM {OracleConfig.schema}.NHANSU WHERE MANV='{EmpIDBox.Text}'";
            OracleCommand cmd = new(delSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân sự thành công!");
                RefreshButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string upSql = $"UPDATE {OracleConfig.schema}.NHANSU SET HOTEN='{EmpNameBox.Text}', " +
                $"PHAI='{GenderCbo.Text}', NGSINH=TO_DATE('{BirthDateTime.Text}', 'DD/MM/YYYY'), " +
                $"PHUCAP={AllowanceUpDown.Value}, DT='{PhoneBox.Text}', " +
                $"VAITRO={RoleCbo.SelectedValue?.ToString()}, MADV={UnitCbo.SelectedValue?.ToString()}, " +
                $"MACS={BranchCbo.SelectedValue?.ToString()} WHERE MANV='{EmpIDBox.Text}'";

            OracleCommand cmd = new(upSql, conn);
            string seSql = $"{sql} WHERE MANV='{EmpIDBox.Text}'";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData(seSql, EmpData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            formAddEmp = new(conn);
            formAddEmp.FormClosedEvent += FormClosedEvent;
            formAddEmp.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            Helper.refreshData($"{sql} WHERE NS.MANV='{formAddEmp?.EmpIDBox.Text}'", EmpData, conn);
        }
    }
}
