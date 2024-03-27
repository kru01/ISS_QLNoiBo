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

namespace ISS_QLNoiBo.DeptHead_Forms
{
    public partial class DeptEmployee : Form
    {
        public string CurrentUser = string.Empty;

        public string deptHeadconn = string.Empty;

        readonly String sql = "SELECT * FROM A01_QLNOIBO.NHANSU";
        public DeptEmployee()
        {
            InitializeComponent();
        }

        private void DeptEmployee_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new(deptHeadconn);
            OracleDataAdapter adp = new(sql, conn);

            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                employeeData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(sql, employeeData);
        }

        private void employeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
