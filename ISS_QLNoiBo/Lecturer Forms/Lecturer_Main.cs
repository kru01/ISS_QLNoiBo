﻿using Oracle.ManagedDataAccess.Client;
using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Lecturer_Forms
{
    public partial class Lecturer_Main : Form
    {
        public string CurrentUser = string.Empty;
        public string lecturerConn = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public Lecturer_Main()
        {
            InitializeComponent();
        }

        private void Lecturer_Main_Load(object sender, EventArgs e)
        {
            lecturerID.Text = CurrentUser;

            String sql = $"SELECT HOTEN FROM A01_QLNOIBO.NHANSU WHERE MANV='{CurrentUser}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lecturerName.Text = reader["HOTEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Account f = new();
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Student(), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Assignment f = new();
            f.CurrentUser = CurrentUser;
            f.lecturerConn = lecturerConn;
            Helper.loadform(f, this.mainPanel);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            Class f = new();
            f.CurrentUser = CurrentUser;
            f.lecturerConn = lecturerConn;
            Helper.loadform(f, this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Announcement f = new();
            Helper.loadform(f, this.mainPanel);
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }
    }
}
