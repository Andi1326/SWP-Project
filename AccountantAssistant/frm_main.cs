using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantAssistant
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            tabCon1.SelectedTab = tabPage_start;
            
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                frm_login frm_Login = new frm_login();
                this.Hide();
                frm_Login.ShowDialog();
            }
        }

        private void tabPage_file_Click(object sender, EventArgs e)
        {
            //tabCon1.SelectedTab = tabPage_start;
            //pnl_1.Visible = true;
        }

        private void tabCon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCon1.SelectedIndex == 0)
            {
                tabCon1.SelectedIndex = 1;
                pnl_1.Location = new Point(0, 30);
                pnl_1.Visible = true;
            }
            else if(tabCon1.SelectedIndex >= 1)
            {
                pnl_1.Visible = false;
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            pnl_1.Visible = false;
        }

        private void lbl_client_Click(object sender, EventArgs e)
        {

        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            frm_create_client frm_cc = new frm_create_client();
            frm_cc.Show();
        }
    }
}
