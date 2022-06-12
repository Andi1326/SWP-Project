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
    public partial class frm_cancel : Form
    {
        public frm_cancel()
        {
            InitializeComponent();
        }

        private void frm_cancel_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed 
                Theme_Dark.ChangeThemeDark(Controls, this);
                datePicker.SkinColor = Theme_Dark.DarkBackColor;
                datePicker.TextColor = Color.White;
            }
            else
            {
                //the dgv gets the data of balance
                Theme_White.ChangeThemeWhite(Controls, this);
            }

            tb_ledger.Text = Serverconnection.ledgerCancel;
            tb_contraledger.Text = Serverconnection.contraLedgerCancel;
            tb_netto.Text = Serverconnection.nettoCancel;
            tb_salestaxrate.Text = Serverconnection.salestaxrateCancel;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (tb_referenceNumber.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen eine Belegnummer eingeben", "Fehlende Belegnummer");
            }
            else
            {
                decimal ust = Convert.ToDecimal(tb_netto.Text) / 100 * Convert.ToDecimal(tb_salestaxrate.Text);
                decimal brutto = Convert.ToDecimal(tb_netto.Text) + ust;

                string netto_s = tb_netto.Text.ToString().Replace(",", ".");
                string brutto_s = brutto.ToString().Replace(",", ".");
                string ust_s = ust.ToString().Replace(",", ".");
                MessageBox.Show(netto_s);

                AccTransaction newAccTransaction = new AccTransaction(frm_main.IDC, Convert.ToInt32(tb_ledger.Text), Convert.ToInt32(tb_contraledger.Text), netto_s, brutto_s, ust_s, Convert.ToInt32(tb_salestaxrate.Text), tb_referenceNumber.Text, datePicker.Text);
                Serverconnection.InsertDataAccTransaction(newAccTransaction);

                this.Hide();
            }
        }
    }
}
