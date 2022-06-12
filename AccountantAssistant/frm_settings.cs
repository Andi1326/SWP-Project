using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AccountantAssistant
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        public static bool password_change = false;
        public static bool darkmode = true;

        private void frm_settings_Load(object sender, EventArgs e)
        {
            if (darkmode)
            {
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed 
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;
            }
            else
            {
                //else the Theme changes to white, ucTopBarWhite gets displayed
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes this form and opens main
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //if loged out IDL is void
            frm_login.IDL = "";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (!password_change)
            {
                frm_password_query frm_pq = new frm_password_query();
                frm_pq.ShowDialog();
            }
            else
            {
                if(tb_password.Text.Equals(""))
                {
                    MessageBox.Show("Bitte geben Sie ein Passwort ein", "Fehler");
                }
                else
                {
                    Serverconnection.ChangePassword(tb_password.Text, frm_login.IDL);
                    MessageBox.Show("Password wurde erfolgreich geändert!", "Passwort geändert", MessageBoxButtons.OK);
                    tb_password.Text = "";
                    password_change = false;
                }
            }
        }

        private void btn_changeDesign_Click(object sender, EventArgs e)
        {
            if(cb_design.SelectedIndex == 0)
            {
                darkmode = true;
                Serverconnection.ChangeDarkmode(1, frm_login.IDL);

                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Remove(ucTopBarWhite.Instance);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
            }
            else
            {
                darkmode = false;
                Serverconnection.ChangeDarkmode(0, frm_login.IDL);

                Theme_White.ChangeThemeWhite(Controls, this);
                this.Hide();
                frm_settings frm_s = new frm_settings();
                frm_s.ShowDialog();
            }
        }
    }
}
