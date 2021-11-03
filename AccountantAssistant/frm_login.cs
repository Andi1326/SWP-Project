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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            frm_register frm_register = new frm_register();
            this.Hide();
            frm_register.ShowDialog();
        }
    }
}
