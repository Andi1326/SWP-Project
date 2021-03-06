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
            //closes the form
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //if the password is incorrect, MessageBox gets displayed, else password_change gets true and form closes
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

        private void frm_password_query_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                //if darkmode is activated the Theme changes to dark
                Theme_Dark.ChangeThemeDark(Controls, this);
            }
            else
            {
                //else the Theme changes to white, ucTopBarWhite gets displayed
                Theme_White.ChangeThemeWhite(Controls, this);
            }
        }
    }
}
