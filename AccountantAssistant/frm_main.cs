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
        }

        public static int IDC;
        private static int transaction_count;


        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes frm_main and opens frm_login
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Loads the Ledger of the Client
            Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetClient(cb_clients);
            Serverconnection.GetLedger(cb_search_ledger, IDC);

            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = true;
                ucTopBarDark.Instance.pb_save.Click += btn_save_Click;

                dgv_transaction.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_transaction.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_transaction.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_transaction.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_transaction.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_transaction.EnableHeadersVisualStyles = false;

            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = true;
                ucTopBarWhite.Instance.pb_save.Click += btn_save_main_Click;
            }


            //selects the tabPage_start
            tabCon1.SelectedTab = tabPage_start;

          

            if(IDC >= 0)
            {
                cb_clients.SelectedItem = IDC;
            }

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
            Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetClient(cb_clients);
            Serverconnection.GetLedger(cb_search_ledger, IDC);
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
            if (cb_ledger.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Konto eingeben", "Fehler");
            }
            else if (date_picker.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Datum eingeben", "Fehler");
            }
            else if (tb_referenceNumber.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen eine Belegnummer eingeben", "Fehler");
            }
            else if(cb_contraLedger.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Gegenkonto eingeben", "Fehler");
            }
            else if (tb_netto.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen den Nettobetrag eingeben eingeben", "Fehler");
            }
            else if (cb_salesTaxRate.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen einen Umsatzsteuersatz eingeben", "Fehler");
            }
            else
            {
                try
                {
                    decimal ust = Convert.ToDecimal(tb_netto.Text) / 100 * Convert.ToDecimal(cb_salesTaxRate.SelectedItem);
                    decimal brutto = Convert.ToDecimal(tb_netto.Text) + ust;
                    if(rbtn_s.Checked == true)
                    {
                        dgv_transaction.Rows.Add(date_picker.Value.ToShortDateString(), tb_referenceNumber.Text, cb_ledger.SelectedItem.ToString(), cb_contraLedger.SelectedItem.ToString(), Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString(), "S");
                    }
                    else
                    {
                        dgv_transaction.Rows.Add(date_picker.Value.ToShortDateString(), tb_referenceNumber.Text, cb_ledger.SelectedItem.ToString(), cb_contraLedger.SelectedItem.ToString(), Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString(), "H");
                    }

                    cb_contraLedger.Text = "";
                    tb_referenceNumber.Text = "";
                    tb_netto.Text = "";
                    cb_salesTaxRate.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Buchung konnte nicht durchgeführt werden");
                }
            }
        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            //opens frm_create_client
            pnl_1.Visible = false;

            this.Hide();
            frm_create_client frm_cc = new frm_create_client();
            frm_cc.ShowDialog();

            Serverconnection.GetClient(cb_clients);
        }

        private void btn_newLedger_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cb_clients.SelectedItem) == 0)
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler");
            }
            else
            {
                //opens frm_new_ledger
                this.Hide();
                frm_create_ledger frm_new_ledger = new frm_create_ledger();
                frm_new_ledger.ShowDialog();
            }
        }

        #region Save_Functions

        private void btn_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            transaction_count = dgv_transaction.Rows.Count;
            if (transaction_count > 0)
            {
                Save_Transaction();
            }
            else if (Convert.ToInt32(cb_clients.SelectedItem).Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler");
            }
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler");
            }
            pnl_1.Visible = false;
        }

        private void btn_save_main_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            transaction_count = dgv_transaction.Rows.Count;
            if(transaction_count > 0)
            {
                Save_Transaction();
            }
            else if (Convert.ToInt32(cb_clients.SelectedItem).Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler");
            }
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler");
            }
        }

        public void ucTopbar_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            transaction_count = dgv_transaction.Rows.Count;
            if (transaction_count > 0)
            {
                Save_Transaction();
            }
            else if (Convert.ToInt32(cb_clients.SelectedItem).Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler");
            }
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler");
            }
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

                    int IDLE = Serverconnection.SaveIDLE(Convert.ToInt32(cb_ledger.SelectedItem), IDC);

                    string type = Serverconnection.SaveType(Convert.ToInt32(cb_ledger.SelectedItem), IDC);
                    //controls if the type is a 'Aktives Bestandskonto' or a 'Aufwandskonto'
                    if(type == "AB" || type == "AK")
                    {
                        //Controls if the user wants that the ledger in debit side or in credit side
                        if(row.Cells[8].Value.ToString() == "S")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), 0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 2500, Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[6].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                        else if(row.Cells[8].Value.ToString() == "H")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value),0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 2500, Convert.ToInt32(row.Cells[3].Value), 0, Convert.ToDecimal(row.Cells[6].Value), row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                    }
                    //controls if the type is a 'Passives Bestandskonto' or a 'Erlöskonto'
                    else
                    {
                        //Controls if the user wants that the ledger in debit side or in credit side
                        if (row.Cells[8].Value.ToString() == "S")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), 0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 3500, Convert.ToInt32(row.Cells[3].Value), 0, Convert.ToDecimal(row.Cells[6].Value), row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                        else if(row.Cells[8].Value.ToString() == "H")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), 0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 3500, Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[6].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                    }
                }

                dgv_transaction.DataSource = null;
                dgv_transaction.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Buchung konnte nicht gespeichert werden");
            }
        }

        #endregion

        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie wirklich diese Buchuchgen löschen?", "Achtung", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dgv_transaction.DataSource = null;
                dgv_transaction.Rows.Clear();

                cb_contraLedger.Text = "";
                tb_referenceNumber.Text = "";
                tb_netto.Text = "";
                cb_salesTaxRate.Text = "";
                pnl_1.Visible = false;
            }
        }

        #region Printing
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            int height = dgv_transaction.Height;
            dgv_transaction.Height = dgv_transaction.RowCount * dgv_transaction.RowTemplate.Height * 2;
            bmp = new Bitmap(dgv_transaction.Width, dgv_transaction.Height);
            dgv_transaction.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_transaction.Width, dgv_transaction.Height));
            dgv_transaction.Height = height;

            printDia.AllowSomePages = true;
            if(printDia.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
            pnl_1.Visible = false;
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        #endregion

        private void cb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDC = Convert.ToInt32(cb_clients.SelectedItem);
            Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetLedger(cb_search_ledger, IDC);
        }

        private void cb_ledger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = Serverconnection.SaveType(Convert.ToInt32(cb_ledger.SelectedItem), IDC);
            if (type == "AB" || type == "AK")
            {
                rbtn_s.Checked = true;
            }
            else
            {
                rbtn_h.Checked = true;  
            }
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            frm_settings frm_s = new frm_settings();
            this.Hide();
            frm_s.ShowDialog();
        }

        #region search

        private void btn_search_ref_Click_1(object sender, EventArgs e)
        {
            frm_search_refNumber.search_item = tb_search_ref.Text;
            this.Hide();
            frm_search_refNumber frm_Search_Ref = new frm_search_refNumber();
            frm_Search_Ref.ShowDialog();
        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {
            frm_search_date.search_date = tb_searchDate.Text;
            this.Hide();
            frm_search_date frm_Search = new frm_search_date();
            frm_Search.ShowDialog();
        }

        private void btn_search_ledger_Click(object sender, EventArgs e)
        {
            frm_search_ledger.search_ledger = Convert.ToInt32(cb_search_ledger.SelectedItem);
            this.Hide();
            frm_search_ledger frm_Search_Ledger = new frm_search_ledger();
            frm_Search_Ledger.ShowDialog();
        }

        #endregion

        private void cb_salesTaxRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_balance frm_Balance = new frm_balance();
            frm_Balance.ShowDialog();
        }

        private void linklable_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link");
            }
        }
        private void VisitLink()
        {
            
            linklable_email.LinkVisited = true;
            
            System.Diagnostics.Process.Start("https://outlook.live.com/owa/");
        }
    }
}
