using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptEmployee : Form
    {
        readonly OracleConnection conn;
        readonly String sql = "SELECT * FROM A01_QLNOIBO.NHANSU";

        public DeptEmployee(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void DeptEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.refreshData(sql, employeeData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(sql, employeeData, conn);
        }

        private void employeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
