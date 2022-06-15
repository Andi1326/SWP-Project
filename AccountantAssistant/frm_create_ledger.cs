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
    public partial class frm_create_ledger : Form
    {
        public frm_create_ledger()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes frm_new_ledger and opens frm_main
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //checks if the ledger already exists
            //checks if the textboxes are empty
            if (Serverconnection.ProofLedger(tb_number, frm_main.IDC))
            {
                MessageBox.Show("Dieses Konto existiert bereits", "Konto existiert bereits");
            }
            else if(tb_number.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen eine Kontonummer eingeben", "Keine Kontonummer");
            }
            else if(tb_name.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen einen Kontonamen eingeben", "Kein Kontoname");
            }
            else
            {
                //Saves the new Ledger into the table AllLedgers
                AllLedgers newAllLedgers = new AllLedgers(frm_main.IDC, Convert.ToInt32(tb_number.Text), tb_name.Text, cb_type.SelectedItem.ToString());
                Serverconnection.InsertDataAllLedgers(newAllLedgers);
                this.Hide();
                frm_main frm_Main = new frm_main();
                frm_Main.ShowDialog();
            }
        }

        private void frm_new_ledger_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
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
    }
}
