using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISS_QLNoiBo.Student_Forms
{
    public partial class CourseReg : Form
    {
        public string CurrentUser { get; set; } = string.Empty;

        public string Program { get; set; } = string.Empty;

        private string registerC = string.Empty;

        private string availableC = string.Empty;

        readonly OracleConnection conn = new($"Data Source = {OracleConfig.connString};" +
            $"User Id = AD0001;password = 123;");

        public CourseReg()
        {
            InitializeComponent();
        }

        private void CourseReg_Load(object sender, EventArgs e)
        {
            String sqlRegister = $"SELECT DK.MAHP, HP.TENHP, DK.HK, DK.NAM " +
                $"FROM A01_QLNOIBO.DANGKY DK JOIN A01_QLNOIBO.HOCPHAN HP ON HP.MAHP=DK.MAHP " +
                $"WHERE DK.MASV='{CurrentUser}' " +
                $"ORDER BY DK.NAM, DK.HK, DK.MAHP";
            registerC = sqlRegister;

            String sqlAvailable = $"SELECT KH.MAHP, HP.TENHP, KH.HK, KH.NAM " +
                $"FROM A01_QLNOIBO.KHMO KH JOIN A01_QLNOIBO.HOCPHAN HP ON HP.MAHP=KH.MAHP " +
                $"WHERE MACT='{Program}' AND KH.MAHP NOT IN (SELECT MAHP " +
                                                            $"FROM A01_QLNOIBO.DANGKY " +
                                                            $"WHERE MASV ='{CurrentUser}')" +
                $"ORDER BY KH.NAM, KH.HK, KH.MAHP";
            availableC = sqlAvailable;

            OracleDataAdapter adpRegister = new(sqlRegister, conn);
            OracleDataAdapter adpAvailable = new(sqlAvailable, conn);

            try
            {
                DataTable dtRegister = new();
                DataTable dtAvailable = new();
                adpRegister.Fill(dtRegister);
                adpAvailable.Fill(dtAvailable);
                registeredCourse.DataSource = dtRegister;
                availableCourse.DataSource = dtAvailable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registeredCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == registeredCourse.RowCount) return;
            DataGridViewRow cRow = registeredCourse.Rows[e.RowIndex];

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            courseName.Text = cRow.Cells["TENHP"].Value.ToString();
        }

        private void availableCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == availableCourse.RowCount) return;
            DataGridViewRow cRow = availableCourse.Rows[e.RowIndex];

            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            courseName.Text = cRow.Cells["TENHP"].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //String sql = $"INSERT INTO A01_QLNOIBO.DANGKY " +
                //$"SELECT '{CurrentUser}', '{courseID.Text}', '{}', 0, 0, 0, 0 FROM DUAL UNION ALL";

            //OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký học phần thành công!");
                Helper.refreshData(registerC, registeredCourse);
                Helper.refreshData(availableC, availableCourse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    MessageBox.Show("Không thể hủy học phần đã có điểm!");
            //}
            //else
            //{
            //    String sql = $"DELETE FROM A01_QLNOIBO.DANGKY " +
            //        $"WHERE MASV='{CurrentUser}' AND MAHP='{courseID.Text}'";

            //    OracleCommand cmd = new(sql, conn);
            //    try
            //    {
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Hủy học phần thành công!");
            //        Helper.refreshData(registerC, registeredCourse);
            //        Helper.refreshData(availableC, availableCourse);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally { conn.Close(); }
            //}
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(registerC, registeredCourse);
            Helper.refreshData(availableC, availableCourse);
        }
    }
}
