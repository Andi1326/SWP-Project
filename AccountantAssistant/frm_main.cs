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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            #region btn_ucTopBar_save Button
            btn_ucTopBar_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            btn_ucTopBar_save.BackgroundImage = Properties.Resources.SaveButton;
            btn_ucTopBar_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ucTopBar_save.FlatAppearance.BorderSize = 0;
            btn_ucTopBar_save.FlatStyle = FlatStyle.Flat;
            btn_ucTopBar_save.Location = new Point(3, 3);
            btn_ucTopBar_save.Name = "btn_save";
            btn_ucTopBar_save.Size = new Size(30, 19);
            btn_ucTopBar_save.TabIndex = 8;
            btn_ucTopBar_save.UseVisualStyleBackColor = true;
            #endregion
        }

        public static int IDC = 1;

        public static Button btn_ucTopBar_save = new Button();

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();
            ucTopBar.Instance.Controls.Add(btn_ucTopBar_save);

            tabCon1.SelectedTab = tabPage_start;

            Serverconnection.GetLedger(cb_ledger);
            dgv_transaction.Columns[5].DefaultCellStyle.Format = "c";
            dgv_transaction.Columns[6].DefaultCellStyle.Format = "c";
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            //if escape gets pushed than frm_login opens and frm_main hides
            if(e.KeyCode == Keys.Escape)
            {
                frm_login frm_Login = new frm_login();
                this.Hide();
                frm_Login.ShowDialog();
            }
        }

        

        private void tabCon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCon1.SelectedIndex == 0)
            {
                tabCon1.SelectedIndex = 1;
                pnl_1.Location = new Point(0, 30);
                pnl_1.Visible = true;
            }
            else if(tabCon1.SelectedIndex >= 1)
            {
                pnl_1.Visible = false;
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            pnl_1.Visible = false;
        }

     

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            //opens frm_create_client
            frm_create_client frm_cc = new frm_create_client();
            frm_cc.ShowDialog();
        }

        private void btn_newLedger_Click(object sender, EventArgs e)
        {
            //opens frm_new_ledger
            frm_new_ledger frm_new_ledger = new frm_new_ledger();
            frm_new_ledger.ShowDialog();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            //calculates the ust and brutto
            decimal ust = Convert.ToDecimal(tb_netto.Text) / 100 * Convert.ToDecimal(cb_salesTaxRate.SelectedItem);
            decimal brutto = Convert.ToDecimal(tb_netto.Text) + ust;
            dgv_transaction.Rows.Add(date_picker.Value.ToShortDateString(), tb_referenceNumber.Text, cb_ledger.SelectedItem.ToString(), tb_contraLedger.Text, Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString());
            
        }
    }
}
