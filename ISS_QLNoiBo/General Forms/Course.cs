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
    public partial class Course : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp1 = new("SELECT * FROM A01_QLNOIBO.HOCPHAN", conn);
            OracleDataAdapter adp2 = new("SELECT * FROM A01_QLNOIBO.DONVI", conn);
            OracleDataAdapter adp3 = new("SELECT * FROM A01_QLNOIBO.KHMO", conn);

            try
            {
                DataTable dt1 = new();
                DataTable dt2 = new();
                DataTable dt3 = new();
                adp1.Fill(dt1);
                adp2.Fill(dt2);
                adp3.Fill(dt3);
                courseData.DataSource = dt1;
                deptData.DataSource = dt2;
                planData.DataSource = dt3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
