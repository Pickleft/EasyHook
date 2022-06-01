using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EasyHook.Calls;
using System.Windows.Forms;

namespace EasyHook
{
    public partial class ProfileManage : Form
    {
        public ProfileManage()
        {
            InitializeComponent();
        }

        private void pstbtn_Click(object sender, EventArgs e)
        {
            pstbtn.Checked = false;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pstbtn.Checked = false;
            webhookname = webhooknames.Text;
            webhookicon = webhookurlicon.Text;
        }

        private void ProfileManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form home = new MainHook();
            home.Show();
        }
    }
}
