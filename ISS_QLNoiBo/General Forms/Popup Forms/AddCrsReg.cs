﻿using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.General_Forms.Popup_Forms
{
    public partial class AddCrsReg : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;
        readonly OracleConnection adConn = new($"Data Source = {OracleConfig.connString};" +
                    $"User Id = AD0001;password = 123;");

        public AddCrsReg(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CourseReg_Load(object sender, EventArgs e)
        {
            String openCrsSql = $"SELECT KH.MACT, KH.NAM, KH.HK, KH.MAHP, HP.TENHP " +
                $"FROM {OracleConfig.schema}.KHMO KH JOIN {OracleConfig.schema}.HOCPHAN HP ON KH.MAHP = HP.MAHP " +
                "ORDER BY KH.MACT, KH.NAM, KH.HK, KH.MAHP";
            String stuSql = $"SELECT * FROM {OracleConfig.schema}.SINHVIEN ORDER BY MASV";

            Helper.refreshData(openCrsSql, OpenCrsData, conn);
            Helper.refreshData(stuSql, StudentData, conn);

            OpenCrsData_CellClick(this.OpenCrsData, new DataGridViewCellEventArgs(0, 0));
        }

        private void StudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == StudentData.RowCount) return;
            DataGridViewRow cRow = StudentData.Rows[e.RowIndex];

            StuIDBox.Text = cRow.Cells["MASV"].Value.ToString();
            StuNameBox.Text = cRow.Cells["HOTEN"].Value.ToString();
        }

        private void OpenCrsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == OpenCrsData.RowCount) return;
            DataGridViewRow cRow = OpenCrsData.Rows[e.RowIndex];

            CrsIDBox.Text = cRow.Cells["MAHP"].Value.ToString();
            CrsNameBox.Text = cRow.Cells["TENHP"].Value.ToString();
            SemBox.Text = cRow.Cells["HK"].Value.ToString();
            YearBox.Text = cRow.Cells["NAM"].Value.ToString();
            ProgIDBox.Text = cRow.Cells["MACT"].Value.ToString();

            String lectSql = $"SELECT NS.MANV, NS.HOTEN FROM {OracleConfig.schema}.PHANCONG PC " +
                    $"JOIN {OracleConfig.schema}.NHANSU NS ON PC.MAGV = NS.MANV " +
                $"WHERE MAHP='{CrsIDBox.Text}' AND HK='{SemBox.Text}' AND NAM={YearBox.Text} " +
                    $"AND MACT='{ProgIDBox.Text}' ORDER BY NS.HOTEN";
            try
            {
                LectIDCbo.DisplayMember = "HOTEN";
                LectIDCbo.ValueMember = "MANV";
                LectIDCbo.DataSource = Helper.getData(lectSql, adConn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(StuIDBox.Text) ||
                String.IsNullOrWhiteSpace(LectIDCbo.Text)
            )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            String inSql = $"INSERT INTO {OracleConfig.schema}.DANGKY VALUES ('{StuIDBox.Text}', " +
                $"'{LectIDCbo.SelectedValue?.ToString()}', '{CrsIDBox.Text}', '{SemBox.Text}', " +
                $"{YearBox.Text}, '{ProgIDBox.Text}', NULL, NULL, NULL, NULL)";

            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đăng ký thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm đăng ký?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
