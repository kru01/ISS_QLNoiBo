using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    public partial class AddEmployee : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;

        public AddEmployee(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
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

                FacilityCbo.DisplayMember = "TENCS";
                FacilityCbo.ValueMember = "MACS";
                FacilityCbo.DataSource = Helper.getData(branchSql, conn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(EmpIDBox.Text) ||
                String.IsNullOrWhiteSpace(EmpNameBox.Text) ||
                String.IsNullOrWhiteSpace(PhoneBox.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            String inSql = $"INSERT INTO {OracleConfig.schema}.NHANSU VALUES ('{EmpIDBox.Text}', '{EmpNameBox.Text}', " +
                $"'{GenderCbo.Text}', TO_DATE('{bdayBox.Text}', 'DD/MM/YYYY'), {AllowanceUpDown.Value}, '{PhoneBox.Text}', " +
                $"{RoleCbo.SelectedValue?.ToString()}, {UnitCbo.SelectedValue?.ToString()}, {FacilityCbo.SelectedValue?.ToString()})";

            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân sự thành công!");
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
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm sinh viên?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
