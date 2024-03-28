using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Others;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    public partial class AddUnit : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;

        readonly OracleConnection adConn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public AddUnit(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm đơn vị?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(unitName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị!");
            }
            else
            {
                var item = unitHeadCbo.SelectedItem as DataRowView;
                String inSql = $"INSERT INTO A01_QLNOIBO.DONVI VALUES " +
                    $"({unitIDUpDown.Value}, '{unitName.Text}', '{item?["MANV"]}')";

                OracleCommand cmd2 = new(inSql, conn);
                try
                {
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Thêm đơn vị thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            string lecturerSql = "SELECT HOTEN, MANV FROM NHANSU WHERE MANV LIKE 'TD%' ORDER BY HOTEN";
            unitHeadCbo.DisplayMember = "HOTEN";
            unitHeadCbo.ValueMember = "MANV";
            unitHeadCbo.DataSource = Helper.getData(lecturerSql, adConn).Tables[0];
        }
    }
}
