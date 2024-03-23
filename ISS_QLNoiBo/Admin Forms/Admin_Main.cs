using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo
{
    public partial class Admin_Main : Form
    {
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {
            adminID.Text = CurrentUsername;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.InspectPriv(), this.mainPanel);
        }

        private void privilegesButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.GrantRoleTable(), this.mainPanel);
        }

        private void usersManageButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.ManageUser(), this.mainPanel);
        }

        private void roleButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.ManageRole(), this.mainPanel);
        }

        private void sysPreButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.GrantSysPriv(), this.mainPanel);
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Forms.ManageView(), this.mainPanel);
        }
    }
}
