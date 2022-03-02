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
    public partial class frm_forget_password : Form
    {

        public frm_forget_password()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes frm_forget_password and opens frm_login
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_forget_password_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
            }

            //sets Keypreview to true
            KeyPreview = true;

            //Loads the questions of the User
            tb_sq1_question.Text = Serverconnection.SaveSQ1_Question(frm_login.IDL);
            tb_sq2_question.Text = Serverconnection.SaveSQ2_Question(frm_login.IDL);
        }

        private void frm_forget_password_KeyDown(object sender, KeyEventArgs e)
        {
            //closes the frm_forget_password and opens the frm_login again
            if(e.KeyCode == Keys.Escape)
            {
                frm_login frm_Login = new frm_login();
                this.Hide();
                frm_Login.ShowDialog();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Check if everything has been typed in correctly
            if (tb_password.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie ein Passwort ein", "Fehler");
            }
            else if (tb_passwordagain.Text.Equals(""))
            {
                MessageBox.Show("Bitte wiederholen Sie das Passwort", "Fehler");
            }
            else if (!tb_password.Text.Equals(tb_passwordagain.Text))
            {
                MessageBox.Show("Passwörter stimmen nicht überein", "Fehler");
            }
            else if (tb_sq1.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie eine Antwort bei der Sicherheitsfrage 1 ein", "Fehler");
            }
            else if (tb_sq2.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie eine Antwort bei der Sicherheitsfrage 2 ein", "Fehler");
            }
            else if (!tb_sq1.Text.Equals(Serverconnection.SaveSQ1(frm_login.IDL)))
            {
                MessageBox.Show("Ihre Antwort bei der Sicherheitsfrage 1 stimmt nicht überein", "Fehler");
            }
            else if (!tb_sq2.Text.Equals(Serverconnection.SaveSQ2(frm_login.IDL)))
            {
                MessageBox.Show("Ihre Antwort bei der Sicherheitsfrage 2 stimmt nicht überein", "Fehler");
            }
            else if(Serverconnection.Proofpassword(tb_password, frm_login.forget_username))
            {
                MessageBox.Show("Ihr altes Passwort darf nicht Ihr neues Passwort sein", "Fehler");
            }
            else
            {
                //if yes the password changes to the new and a MessageBox displays
                Serverconnection.ChangePassword(tb_password.Text, frm_login.IDL);
                MessageBox.Show("Password wurde erfolgreich geändert!", "Passwort geändert", MessageBoxButtons.OK);
                frm_login l = new frm_login();
                this.Hide();
                l.ShowDialog();
            }
        }
    }
}
