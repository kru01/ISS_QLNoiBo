using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISS_QLNoiBo.Others;

namespace ISS_QLNoiBo
{
    public partial class Admin_Main : Form
    {
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Users(), this.mainPanel);
        }

        private void privilegesButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Main_Forms.Privileges(), this.mainPanel);
        }
    }
}
