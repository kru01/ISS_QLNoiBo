using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS_QLNoiBo.Others
{
    internal class Helper
    {
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
    }
}
