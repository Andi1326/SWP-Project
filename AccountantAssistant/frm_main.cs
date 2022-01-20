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
            //Initiazlizes the Button btn_ucTopBar_save
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
            btn_ucTopBar_save.Click += new System.EventHandler(this.btn_ucTopbar_save_Click);
            #endregion
        }

        public static int IDC = 1;

        public static Button btn_ucTopBar_save = new Button();

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes frm_main and opens frm_login
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Adds User Control to the Form and adds the Button to the User Control
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();
            ucTopBar.Instance.Controls.Add(btn_ucTopBar_save);

            //selects the tabPage_start
            tabCon1.SelectedTab = tabPage_start;

            //Loads the Ledger of the Client
            Serverconnection.GetLedger(cb_ledger);
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
            //if the tabPage switches to index 0 (Datei) then the panel displays
            if (tabCon1.SelectedIndex == 0)
            {
                tabCon1.SelectedIndex = 1;
                pnl_1.Location = new Point(0, 30);
                pnl_1.Visible = true;
                pnl_1.BringToFront();
            }
            else if(tabCon1.SelectedIndex >= 1)
            {
                //if the tabPage is another Page the panel gets invisible
                pnl_1.Visible = false;
            }

            //Loads the Ledger of the Client
            Serverconnection.GetLedger(cb_ledger);
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            //the panel gets invisible
            pnl_1.Visible = false;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //trys to calculate the ust and brutto and then adds the Transaction to the Datagridview
            //then sets the Text to "" of the Textboxes
            try
            {
                decimal ust = Convert.ToDecimal(tb_netto.Text) / 100 * Convert.ToDecimal(cb_salesTaxRate.SelectedItem);
                decimal brutto = Convert.ToDecimal(tb_netto.Text) + ust;
                dgv_transaction.Rows.Add(date_picker.Value.ToShortDateString(), tb_referenceNumber.Text, cb_ledger.SelectedItem.ToString(), tb_contraLedger.Text, Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString());

                tb_contraLedger.Text = "";
                tb_referenceNumber.Text = "";
                tb_netto.Text = "";
                cb_salesTaxRate.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Buchung konnte nicht durchgeführt werden");
            }
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


        private void btn_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            Save_Transaction();
        }

        private void btn_save_main_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            Save_Transaction();
        }

        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            Save_Transaction();
        }

        private void Save_Transaction()
        {
            //trys to save every row of the DataGridView into the Table AccTransaction
            //then deletes the data of the DataGridView
            try
            {
                DataGridViewRowCollection rows = dgv_transaction.Rows;

                foreach (DataGridViewRow row in rows)
                {
                    string dateTransaction = row.Cells[0].Value.ToString();
                    AccTransaction newAccTransaction = new AccTransaction(IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), Convert.ToDecimal(row.Cells[5].Value), Convert.ToDecimal(row.Cells[6].Value), Convert.ToInt32(row.Cells[7].Value), row.Cells[1].Value.ToString(), dateTransaction);
                    Serverconnection.InsertDataAccTransaction(newAccTransaction);
                }

                dgv_transaction.DataSource = null;
                dgv_transaction.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Buchung konnte nicht gespeichert werden");
            }
        }
    }
}
