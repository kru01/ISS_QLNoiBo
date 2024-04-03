using ISS_QLNoiBo.Others;
using ISS_QLNoiBo.Admin_Forms;
using Oracle.ManagedDataAccess.Client;

namespace ISS_QLNoiBo
{
    public partial class Admin_Main : Form
    {
        readonly string curUser;
        readonly OracleConnection conn;
        public Admin_Main(string curUser, string connString)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = new(connString);
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {
            adminID.Text = curUser;
        }

        private void InsPrivButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new InspectPriv(conn), this.mainPanel);
        }

        private void privilegesButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GrantRoleTable(conn), this.mainPanel);
        }

        private void usersManageButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ManageUser(conn), this.mainPanel);
        }

        private void roleButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ManageRole(conn), this.mainPanel);
        }

        private void sysPreButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GrantSysPriv(conn), this.mainPanel);
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
            Helper.loadform(new ManageView(conn), this.mainPanel);
        }

        private void AnnounButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Announcement(conn), this.mainPanel);
        }

        private void InsAuditButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new InspectAudit(conn), this.mainPanel);
        }
    }
}
