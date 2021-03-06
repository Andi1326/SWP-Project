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
        public static bool tabConCreated = false;


        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes frm_main and opens frm_login
            frm_login frm_Login = new frm_login();
            this.Hide();
            frm_Login.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Loads the Ledger of the Client, the Clients and the ledger of search
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetClient(cb_clients);
            Serverconnection.GetLedger(ucTabControl.Instance.cb_search_ledger, IDC);

            #region Design_settings
            //if darkmode is activated, Theme_Dark class is executed, adds ucTopBarDark to the Controls
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = true;
                ucTopBarDark.Instance.pb_save.Click += btn_save_Click;

                //the Background of dgv_transaction sets to the dark design
                dgv_transaction.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_transaction.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_transaction.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_transaction.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_transaction.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_transaction.EnableHeadersVisualStyles = false;

                //ucTabControl Backcolor and the datePicker is set to the dark design
                ucTabControl.Instance.BackColor = Theme_Dark.DarkBackColor;
                datePicker.SkinColor = Theme_Dark.DarkBackColor;
                datePicker.TextColor = Color.White;
            }
            else
            {
                //if whitemode is activated, Theme_White class is executed, adds ucTopbBarWhite to the controls
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = true;
                ucTopBarWhite.Instance.pb_save.Click += btn_save_main_Click;
                ucTabControl.Instance.BackColor = Color.White;
            }
            #endregion

            #region ucTabControl
            //adds ucTabControl to the Controls and brings the controls above to front
            Controls.Add(ucTabControl.Instance);
            ucTabControl.Instance.Dock = DockStyle.Top;
            ucTabControl.Instance.BringToFront();
            lbl_client.BringToFront();
            cb_clients.BringToFront();
            pb_settings.BringToFront();

            //assigns the methods of frm_main to ucTabControl controls
            if (!tabConCreated)
            {
                ucTabControl.Instance.btn_file.Click += TabCon_btnFile;
                ucTabControl.Instance.btn_start.Click += TabCon_HidePanel;
                ucTabControl.Instance.btn_search.Click += TabCon_HidePanel;
                ucTabControl.Instance.btn_ledger.Click += TabCon_HidePanel;
                ucTabControl.Instance.btn_help.Click += TabCon_HidePanel;

                ucTabControl.Instance.tb_ledger.TextChanged += tb_ledger_TextChanged;
                ucTabControl.Instance.linklable_email.LinkClicked += linklable_email_LinkClicked;
                ucTabControl.Instance.btn_email.Click += btn_email_Click;
                tabConCreated = true;
            }
            #endregion

            //if IDC is already set, cb_clients Item is IDC
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

        public void TabCon_btnFile(object sender, EventArgs e)
        {
            //opens the blue menu panel
            pnl_1.Location = new Point(0, 30);
            pnl_1.Visible = true;
            pnl_1.BringToFront();
        }

        private void TabCon_HidePanel(object sender, EventArgs e)
        {
            //hides the blue menu panel
            pnl_1.Visible = false;
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            //hides the blue menu panel
            pnl_1.Visible = false;
        }
        
        private void btn_enter_Click(object sender, EventArgs e)
        {
            //trys to calculate the ust and brutto and then adds the Transaction to the Datagridview
            //then sets the Text to "" of the Textboxes
            if (ucTabControl.Instance.tb_ledger.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Konto eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (datePicker.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Datum eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_referenceNumber.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen eine Belegnummer eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cb_contraLedger.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen ein Gegenkonto eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_netto.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen den Nettobetrag eingeben eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_salesTaxRate.Text.Equals(""))
            {
                MessageBox.Show("Sie müssen einen Umsatzsteuersatz eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //calculates ust and brutto and then adds it to the DataGridView
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
                catch
                {
                    MessageBox.Show("Buchung konnte nicht durchgeführt werden. Bitte informieren Sie Ihren Administrator", "Buchung konnte nicht durchgeführt werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_newClient_Click(object sender, EventArgs e)
        {
            //opens frm_create_client and closes pnl_1
            pnl_1.Visible = false;

            this.Hide();
            frm_create_client frm_cc = new frm_create_client();
            frm_cc.ShowDialog();

            Serverconnection.GetClient(cb_clients);
        }

        #region Save_Functions

        private void btn_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function if the transaction_count is higher than 0 and if a client is selected
            transaction_count = dgv_transaction.Rows.Count;
            if (transaction_count > 0)
            {
                Save_Transaction();
            }
            else if (Convert.ToInt32(cb_clients.SelectedItem).Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pnl_1.Visible = false;
        }

        private void btn_save_main_Click(object sender, EventArgs e)
        {
            //executes the Save Function if the transaction_count is higher than 0 and if a client is selected
            transaction_count = dgv_transaction.Rows.Count;
            if(transaction_count > 0)
            {
                Save_Transaction();
            }
            else if (Convert.ToInt32(cb_clients.SelectedItem).Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch
            {
                MessageBox.Show("Buchung konnte nicht durchgeführt werden. Bitte informieren Sie Ihren Administrator", "Buchung konnte nicht gespeichert werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btn_new_Click(object sender, EventArgs e)
        {
            //delets all columns of the dgv_transaction
            DialogResult result = MessageBox.Show("Wollen Sie wirklich diese Buchuchgen löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            //if index is changed, the boxes gets the new values
            IDC = Convert.ToInt32(cb_clients.SelectedItem);
            Serverconnection.GetLedger(cb_contraLedger, IDC);
            Serverconnection.GetLedger(ucTabControl.Instance.cb_search_ledger, IDC);
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            //opens frm_settings
            frm_settings frm_s = new frm_settings();
            this.Hide();
            frm_s.ShowDialog();
        }

        #region Printing
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            //creates a Bitmap of the dgv_transaction and then prints the document
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
            //creates and image of the bmp
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        #endregion

        #region tbLedger

        private void tb_ledger_TextChanged(object sender, EventArgs e)
        {
            //if tb_ledger text is changed, it looks if "Soll" or "Haben" shoot be checked
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
            //trys to execute the method 'VisitLink'
            try
            {
                VisitLink();
            }
            catch
            {
                MessageBox.Show("Link konnte nicht geöffnet werden. Bitte informieren Sie Ihren Administrator", "Fehler Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VisitLink()
        {
            //opens outlook
            ucTabControl.Instance.linklable_email.LinkVisited = true;
            System.Diagnostics.Process.Start("https://outlook.live.com/owa/");
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            //trys to execute the method 'VisitLink'
            try
            {
                VisitLink();
            }
            catch
            {
                MessageBox.Show("Link konnte nicht geöffnet werden. Bitte informieren Sie Ihren Administrator", "Fehler Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

    }
}
