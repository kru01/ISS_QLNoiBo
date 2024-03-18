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
    public partial class Account : Form
    {
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;

        OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
        $"User Id = AD0001;password = 123;");
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT * FROM NHANSU WHERE MANV='{CurrentUsername}'";
            OracleCommand cmd = new(sql, conn);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    conn.Open();
                    IDBox.Text = reader["MANV"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    genderBox.Text = reader["PHAI"].ToString();
                    phoneBox.Text = reader["DT"].ToString();
                    bdayBox.Text = reader["NGSINH"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            String sql = $"UPDATE NHANSU SET DT = {phoneBox.Text} WHERE MANV = {CurrentUsername}";
            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}