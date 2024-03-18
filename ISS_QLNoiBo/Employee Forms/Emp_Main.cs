using ISS_QLNoiBo.General_Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo.Employee_Forms
{
    public partial class Emp_Main : Form
    {
        public string CurrentUsername { get; set; } = string.Empty;
        public Emp_Main()
        {
            InitializeComponent();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUsername = CurrentUsername;
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
