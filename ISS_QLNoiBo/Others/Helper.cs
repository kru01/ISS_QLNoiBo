using Oracle.ManagedDataAccess.Client;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS_QLNoiBo.Others
{
    internal class Helper
    {
        readonly static OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public static DataSet getData(string query)
        {
            conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(query, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void loadform(object Form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }

        public static void refreshData(string query, DataGridView d)
        {
            d.DataSource = getData(query).Tables[0];
        }
    }
}
