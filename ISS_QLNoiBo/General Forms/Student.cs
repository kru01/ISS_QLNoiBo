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
    public partial class Student : Form
    {
        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new("SELECT * FROM A01_QLNOIBO.SINHVIEN", conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
