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
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        //var for frm_register
        private static bool showPassword = false;

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes frm_register and opens frm_login
            frm_login frm_login = new frm_login();
            this.Hide();
            frm_login.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //chech if the textboxes are empty and if the user is already taken
            if (tb_user.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen einen Username eingeben", "Kein Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Serverconnection.Proofuser(tb_user))
            {
                MessageBox.Show("Der Username ist bereits vergeben", "Username vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_password.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Passwort eingeben", "Kein Passwort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_passwordagain.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen das Passwort wiederholen", "Passwort wiederholen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!tb_password.Text.Equals(tb_passwordagain.Text))
            {
                MessageBox.Show("Ihre Passwörter stimmen nicht überein", "Passwort stimmt nicht überein", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_sq1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Sie müssen eine Sicherheitsfrage auswählen", "Keine Sicherheitsfrage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_sq1.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen die Sicherheitsfrage beantworten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_sq2.SelectedItem.Equals(null))
            {
                MessageBox.Show("Sie müssen eine Sicherheitsfrage auswählen", "Keine Sicherheitsfrage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_sq2.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen die Sicherheitsfrage beantworten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if everything is ok, data inserts into the table with the method Serverconnection.InsertData
                Login newlogin = new Login(tb_user.Text, tb_password.Text, tb_sq1.Text, tb_sq2.Text, cb_sq1.SelectedItem.ToString(), cb_sq2.SelectedItem.ToString(), cb_role.SelectedItem.ToString(), 1);
                Serverconnection.InsertDataLogin(newlogin);

                frm_login l = new frm_login();
                this.Hide();
                l.ShowDialog();
            }
        }

        private void frm_register_KeyDown(object sender, KeyEventArgs e)
        {
            //if Escape gets pushed frm_register closes and opens frm_login
            if (e.KeyCode == Keys.Escape)
            {
                frm_login frm_login = new frm_login();
                this.Hide();
                frm_login.ShowDialog();
            }
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;
                btn_showHidePassword.BackgroundImage = Properties.Resources.showPassword_Dark;
            }
            else
            {
                //else the Theme changes to white, ucTopBarWhite gets displayed
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = false;
                btn_showHidePassword.BackgroundImage = Properties.Resources.showPassword_White;
            }

            //sets Keypreview to true and adds User Control to the form
            KeyPreview = true;
        }

        private void btn_showHidePassword_Click(object sender, EventArgs e)
        {
            //if showPassword is false the image changes to hidePassword_Dark or _White, else image changes to showPassword_Dark or _WHite 
            if (frm_settings.darkmode && !showPassword)
            {
                showPassword = true;
                btn_showHidePassword.BackgroundImage = Properties.Resources.hidePassword_Dark;
            }
            else if (frm_settings.darkmode && showPassword)
            {
                showPassword = false;
                btn_showHidePassword.BackgroundImage = Properties.Resources.showPassword_Dark;
            }
            else if (!frm_settings.darkmode && !showPassword)
            {
                showPassword = true;
                btn_showHidePassword.BackgroundImage = Properties.Resources.hidePassword_White;
            }
            else
            {
                showPassword = false;
                btn_showHidePassword.BackgroundImage = Properties.Resources.showPassword_White;
            }
            //if the password stars are activated changes to false, else changes to true
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                tb_passwordagain.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
                tb_passwordagain.UseSystemPasswordChar = true;
            }
        }
    }
}
