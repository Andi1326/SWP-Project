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

        public static bool darkmode = false;

        private void frm_settings_Load(object sender, EventArgs e)
        {
            Controls.Remove(ucTopBar.Instance);
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();

            if (darkmode)
            {
                Theme_Dark.ChangeThemeDark(this.Controls, this);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
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
                Theme_Dark.ChangeThemeDark(Controls, this);
            }
            else
            {
                darkmode = false;
                this.Hide();
                frm_settings frm_s = new frm_settings();
                frm_s.ShowDialog();

                //Controls.Remove(ucTopBar.Instance);
                //Controls.Add(ucTopBar.Instance);
                //ucTopBar.Instance.Dock = DockStyle.Top;
                //ucTopBar.Instance.BringToFront();

                //ucTopBar.Instance.Update();

                Theme_White.ChangeThemeWhite(Controls, this);
            }
        }
    }
}
