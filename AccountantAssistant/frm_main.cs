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
            //Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetClient(cb_clients);
            Serverconnection.GetLedger(ucTabControl.Instance.cb_search_ledger, IDC);

            

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

                ucTabControl.Instance.BackColor = Theme_Dark.DarkBackColor;
                datePicker.SkinColor = Theme_Dark.DarkBackColor;
                datePicker.TextColor = Color.White;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = true;
                ucTopBarWhite.Instance.pb_save.Click += btn_save_main_Click;
                ucTabControl.Instance.BackColor = Color.White;
            }

            #region ucTabControl
            Controls.Add(ucTabControl.Instance);
            ucTabControl.Instance.Dock = DockStyle.Top;
            ucTabControl.Instance.BringToFront();
            lbl_client.BringToFront();
            cb_clients.BringToFront();
            pb_settings.BringToFront();

            ucTabControl.Instance.btn_file.Click += TabCon_btnFile;
            ucTabControl.Instance.btn_start.Click += TabCon_HidePanel;
            ucTabControl.Instance.btn_search.Click += TabCon_HidePanel;
            ucTabControl.Instance.btn_ledger.Click += TabCon_HidePanel;
            ucTabControl.Instance.btn_help.Click += TabCon_HidePanel;

            ucTabControl.Instance.btn_chooseLedger.Click += btn_chooseLedger_Click;
            ucTabControl.Instance.btn_balance.Click += btn_balance_Click;
            ucTabControl.Instance.btn_search_ref.Click += btn_search_ref_Click_1;
            ucTabControl.Instance.btn_searchDate.Click += btn_searchDate_Click;
            ucTabControl.Instance.btn_newLedger.Click += btn_newLedger_Click;
            ucTabControl.Instance.btn_search_ledger.Click += btn_search_ledger_Click;
            ucTabControl.Instance.tb_ledger.TextChanged += tb_ledger_TextChanged;
            ucTabControl.Instance.linklable_email.LinkClicked += linklable_email_LinkClicked;
            ucTabControl.Instance.btn_email.Click += btn_email_Click;

            
            #endregion

            if (IDC >= 0)
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

        private void TabCon_btnFile(object sender, EventArgs e)
        {
            pnl_1.Location = new Point(0, 30);
            pnl_1.Visible = true;
            pnl_1.BringToFront();
        }

        private void TabCon_HidePanel(object sender, EventArgs e)
        {
            pnl_1.Visible = false;
        }

        private void tabCon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the tabPage switches to index 0 (Datei) then the panel displays
            //if (tabCon1.SelectedIndex == 0)
            //{
            //    tabCon1.SelectedIndex = 1;
            //    pnl_1.Location = new Point(0, 30);
            //    pnl_1.Visible = true;
            //    pnl_1.BringToFront();
            //}
            //else if(tabCon1.SelectedIndex >= 1)
            //{
            //    //if the tabPage is another Page the panel gets invisible
            //    pnl_1.Visible = false;
            //}

            //Loads the Ledger of the Client
            //Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetClient(cb_clients);
            Serverconnection.GetLedger(ucTabControl.Instance.cb_search_ledger, IDC);
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
            if (ucTabControl.Instance.tb_ledger.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Konto eingeben", "Fehler");
            }
            else if (datePicker.Text.Equals(""))
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
                        dgv_transaction.Rows.Add(datePicker.Value.ToShortDateString(), tb_referenceNumber.Text, ucTabControl.Instance.tb_ledger.Text, cb_contraLedger.SelectedItem.ToString(), Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString(), "S");
                    }
                    else
                    {
                        dgv_transaction.Rows.Add(datePicker.Value.ToShortDateString(), tb_referenceNumber.Text, ucTabControl.Instance.tb_ledger.Text, cb_contraLedger.SelectedItem.ToString(), Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString(), "H");
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
            if (cb_clients.Text.ToString().Equals(null))
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
                    //creates a string var of the different number --> then replace the ',' with a '.' so it can save correctly into the DataBase
                    string netto_s = row.Cells[4].Value.ToString();
                    string brutto_s = row.Cells[5].Value.ToString();
                    string ust_s = row.Cells[6].Value.ToString();

                    netto_s = netto_s.Replace(",", ".");
                    brutto_s = brutto_s.Replace(",", ".");
                    ust_s = ust_s.Replace(",", ".");

                    string dateTransaction = row.Cells[0].Value.ToString();
                    AccTransaction newAccTransaction = new AccTransaction(IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), netto_s, brutto_s, ust_s, Convert.ToInt32(row.Cells[7].Value), row.Cells[1].Value.ToString(), dateTransaction);
                    Serverconnection.InsertDataAccTransaction(newAccTransaction);

                    int IDLE = Serverconnection.SaveIDLE(Convert.ToInt32(ucTabControl.Instance.tb_ledger.Text), IDC);

                    string type = Serverconnection.SaveType(ucTabControl.Instance.tb_ledger.Text.ToString(), IDC);
                    //controls if the type is a 'Aktives Bestandskonto' or a 'Aufwandskonto'
                    if(type == "AB" || type == "AK")
                    {
                        //Controls if the user wants that the ledger in debit side or in credit side
                        if(row.Cells[8].Value.ToString() == "S")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), netto_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), "0", netto_s, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 2500, Convert.ToInt32(row.Cells[3].Value), ust_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                        else if(row.Cells[8].Value.ToString() == "H")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), "0", netto_s, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), netto_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 2500, Convert.ToInt32(row.Cells[3].Value), "0", ust_s, row.Cells[1].Value.ToString(), dateTransaction);
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
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), netto_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), "0", netto_s, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 3500, Convert.ToInt32(row.Cells[3].Value), "0", ust_s, row.Cells[1].Value.ToString(), dateTransaction);
                                Serverconnection.InsertDataLedger(ledgerUst);
                            }
                        }
                        else if(row.Cells[8].Value.ToString() == "H")
                        {
                            Ledger ledger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), "0",netto_s, row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledger);

                            Ledger contraLedger = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), netto_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(contraLedger);

                            if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                            {
                                Ledger ledgerUst = new Ledger(IDLE, IDC, 3500, Convert.ToInt32(row.Cells[3].Value), ust_s, "0", row.Cells[1].Value.ToString(), dateTransaction);
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

        
        private void cb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDC = Convert.ToInt32(cb_clients.SelectedItem);
            //Serverconnection.GetLedger(cb_ledger, IDC);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetLedger(ucTabControl.Instance.cb_search_ledger, IDC);
        }


        private void pb_settings_Click(object sender, EventArgs e)
        {
            frm_settings frm_s = new frm_settings();
            this.Hide();
            frm_s.ShowDialog();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_balance frm_Balance = new frm_balance();
            frm_Balance.ShowDialog();
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
            if (printDia.ShowDialog() == DialogResult.OK)
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

        #region search

        private void btn_search_ref_Click_1(object sender, EventArgs e)
        {
            frm_search_refNumber.search_item = ucTabControl.Instance.tb_search_ref.Text;
            this.Hide();
            frm_search_refNumber frm_Search_Ref = new frm_search_refNumber();
            frm_Search_Ref.ShowDialog();
        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {
            frm_search_date.search_date = ucTabControl.Instance.tb_searchDate.Text;
            this.Hide();
            frm_search_date frm_Search = new frm_search_date();
            frm_Search.ShowDialog();
        }

        private void btn_search_ledger_Click(object sender, EventArgs e)
        {
            frm_search_ledger.search_ledger = ucTabControl.Instance.cb_search_ledger.SelectedItem.ToString();
            this.Hide();
            frm_search_ledger frm_Search_Ledger = new frm_search_ledger();
            frm_Search_Ledger.ShowDialog();
        }

        #endregion

        #region tbLedger

        private void btn_chooseLedger_Click(object sender, EventArgs e)
        {
            frm_ledger_overview frm_lo = new frm_ledger_overview();
            frm_lo.ShowDialog();
            ucTabControl.Instance.tb_ledger.Text = frm_ledger_overview.ledger_number;
        }


        private void tb_ledger_TextChanged(object sender, EventArgs e)
        {
            string type = Serverconnection.SaveType(ucTabControl.Instance.tb_ledger.Text.ToString(), IDC);
            if (type == "AB" || type == "AK")
            {
                rbtn_s.Checked = true;
            }
            else
            {
                rbtn_h.Checked = true;
            }
        }

        #endregion

        #region eMail

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
            ucTabControl.Instance.linklable_email.LinkVisited = true;
            System.Diagnostics.Process.Start("https://outlook.live.com/owa/");
        }

        private void btn_email_Click(object sender, EventArgs e)
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

        #endregion

    }
}
