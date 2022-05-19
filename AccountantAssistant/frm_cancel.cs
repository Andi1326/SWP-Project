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

            tb_referenceNumber.Text = Serverconnection.referenceNumberCancel;
            tb_ledger.Text = Serverconnection.ledgerCancel;
            tb_contraledger.Text = Serverconnection.contraLedgerCancel;
            tb_netto.Text = Serverconnection.nettoCancel;
            tb_salestaxrate.Text = Serverconnection.salestaxrateCancel;
        }
    }
}
