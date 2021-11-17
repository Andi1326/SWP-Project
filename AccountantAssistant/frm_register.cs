﻿using System;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            this.Hide();
            frm_login.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //chech if the textboxes are empty and if the user is already taken
            if (tb_user.Text == "")
            {
                MessageBox.Show("Sie müssen einen Username eingeben", "Kein Username");
            }
            else if (Serverconnection.Proofuser(tb_user))
            {
                MessageBox.Show("Der Username ist bereits vergeben", "Username vorhanden");
            }
            else if (tb_password.Text == "")
            {
                MessageBox.Show("Sie müssen ein Passwort eingeben", "Kein Passwort");
            }
            else if (tb_passwordagain.Text == "")
            {
                MessageBox.Show("Sie müssen das Passwort wiederholen", "Passwort wiederholen!");
            }
            else if (tb_password.Text != tb_passwordagain.Text)
            {
                MessageBox.Show("Ihre Passwörter stimmen nicht überein", "Passwort stimmt nicht überein");
            }
            else if (cb_sq1.SelectedItem == null)
            {
                MessageBox.Show("Sie müssen eine Sicherheitsfrage auswählen", "Keine Sicherheitsfrage");
            }
            else if (tb_sq1.Text == "")
            {
                MessageBox.Show("Sie müssen die Sicherheitsfrage beantworten", "Fehler");
            }
            else if (cb_sq2.SelectedItem == null)
            {
                MessageBox.Show("Sie müssen eine Sicherheitsfrage auswählen", "Keine Sicherheitsfrage");
            }
            else if (tb_sq2.Text == "")
            {
                MessageBox.Show("Sie müssen die Sicherheitsfrage beantworten", "Fehler");
            }
            else
            {
                //if everything is ok, data inserts into the table with the method Serverconnection.InsertData

                Login newlogin = new Login(tb_user.Text, tb_password.Text, tb_sq1.Text, tb_sq2.Text, cb_sq1.SelectedItem.ToString(), cb_sq2.SelectedItem.ToString(), cb_role.SelectedItem.ToString());
                Serverconnection.InsertDataLogin(newlogin);

                frm_login l = new frm_login();
                this.Hide();
                l.ShowDialog();
            }
        }

        private void frm_register_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                frm_login frm_login = new frm_login();
                this.Hide();
                frm_login.ShowDialog();
            }
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}