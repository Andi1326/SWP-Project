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

        public static string IDL;
        public static string role;
        public static string forget_username;
        private static bool showPassword = false;

        private void btn_login_Click(object sender, EventArgs e)
        {
            //check if the user and the password are ok
            if (!Serverconnection.Proofuser(tb_user))
            {
                MessageBox.Show("Ihren Benutzer gibt es nicht", "Fehler");
            }
            else
            {
                if (!Serverconnection.Proofpassword(tb_password, tb_user.Text))
                {
                    MessageBox.Show("Ihr Passwort ist falsch", "Fehler");
                }
                else
                {
                    //if yes the Role and IDL are saved and frm_customer opens
                    Serverconnection.SaveRole(tb_user);
                    Serverconnection.SaveIDL(tb_user);
                    Serverconnection.SaveDarkmode(tb_user); 
                    frm_main frm_main = new frm_main();
                    this.Hide();
                    frm_main.ShowDialog();
                }
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
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

            //Trys to connect to the server
            Serverconnection.Tryconnect();
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            //shows frm_register and hides frm_login
            frm_register frm_register = new frm_register();
            this.Hide();
            frm_register.ShowDialog();
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            //Check if you have typed in a user and if this user exists
            if (tb_user.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie ihren Benutzer ein", "Fehler");
            }
            else if (!Serverconnection.Proofuser(tb_user))
            {
                MessageBox.Show("Ihren Benutzer gibt es nicht", "Fehler");
            }
            else
            {
                //if yes the IDL saves and frm_forget_password opens
                Serverconnection.SaveIDL(tb_user);
                forget_username = tb_user.Text;
                frm_forget_password frm_Forget_Password = new frm_forget_password();
                this.Hide();
                frm_Forget_Password.ShowDialog();
            }
        }

        private void btn_showHidePassword_Click(object sender, EventArgs e)
        {
            //if showPassword is false the image changes to hidePassword_Dark or _White, else image changes to showPassword_Dark or _WHite 
            if (frm_settings.darkmode && !showPassword)
            {
                showPassword = true;
                btn_showHidePassword.BackgroundImage = Properties.Resources.hidePassword_Dark;
            }
            else if(frm_settings.darkmode && showPassword)
            {
                showPassword = false;
                btn_showHidePassword.BackgroundImage = Properties.Resources.showPassword_Dark;
            }
            else if(!frm_settings.darkmode && !showPassword)
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
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }
    }
}
