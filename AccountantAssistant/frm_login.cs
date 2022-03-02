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
                Theme_Dark.ChangeThemeDark(Controls, this);
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
            }

            //Adds User Controls to the Form
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();

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
    }
}
