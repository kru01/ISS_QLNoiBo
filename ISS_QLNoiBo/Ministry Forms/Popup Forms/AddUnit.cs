using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.Others;
using System.Data;

namespace ISS_QLNoiBo.Ministry_Forms.Popup_Forms
{
    public partial class AddUnit : Form
    {
        public event EventHandler FormClosedEvent;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public AddUnit()
        {
            InitializeComponent();
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
                String helperSql = "SELECT MADV FROM A01_QLNOIBO.DONVI ORDER BY MADV DESC WHERE ROWNUM=1";
                var item = (DataRowView)unitHeadCbo.SelectedItem;

                String updateSql = $"INSERT INTO A01_QLNOIBO.DONVI " +
                    $"SELECT 10, '{unitName.Text}', '{item["MANV"]}'" +
                    $"FROM DUAL UNION ALL";

                OracleCommand cmd2 = new(updateSql, conn);

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
            string lecturerSql = "SELECT HOTEN, MANV FROM NHANSU WHERE MANV LIKE 'TD%'";
            unitHeadCbo.DisplayMember = "HOTEN";
            unitHeadCbo.ValueMember = "MANV";
            unitHeadCbo.DataSource = Helper.getData(lecturerSql).Tables[0];
        }
    }
}
