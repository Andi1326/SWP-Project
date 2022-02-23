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
    public partial class frm_password_query : Form
    {
        public frm_password_query()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!Serverconnection.PasswordQuery(tb_password, Convert.ToInt32(frm_login.IDL)))
            {
                MessageBox.Show("Das eingegebene Passwort ist falsch", "Falsches Passwort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm_settings.password_change = true;
                this.Close();
            }
        }
    }
}
