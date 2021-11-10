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
    }
}
