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
        private static int transaction_count;

        public static Button btn_ucTopBar_save = new Button();

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes frm_main and opens frm_login
            ucTopBar.Instance.Controls.Remove(btn_ucTopBar_save);
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
            Serverconnection.GetLedger(cb_contraLedger);
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
            Serverconnection.GetLedger(cb_contraLedger);
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
            if (cb_ledger.Text == "")
            {
                MessageBox.Show("Sie müssen ein Konto eingeben", "Fehler");
            }
            else if (date_picker.Text == "")
            {
                MessageBox.Show("Sie müssen ein Datum eingeben", "Fehler");
            }
            else if (tb_referenceNumber.Text == "")
            {
                MessageBox.Show("Sie müssen eine Belegnummer eingeben", "Fehler");
            }
            else if(cb_contraLedger.Text == "")
            {
                MessageBox.Show("Sie müssen ein Gegenkonto eingeben", "Fehler");
            }
            else if (tb_netto.Text == "")
            {
                MessageBox.Show("Sie müssen den Nettobetrag eingeben eingeben", "Fehler");
            }
            else if (cb_salesTaxRate.Text == "")
            {
                MessageBox.Show("Sie müssen einen Umsatzsteuersatz eingeben", "Fehler");
            }
            else
            {
                try
                {
                    decimal ust = Convert.ToDecimal(tb_netto.Text) / 100 * Convert.ToDecimal(cb_salesTaxRate.SelectedItem);
                    decimal brutto = Convert.ToDecimal(tb_netto.Text) + ust;
                    dgv_transaction.Rows.Add(date_picker.Value.ToShortDateString(), tb_referenceNumber.Text, cb_ledger.SelectedItem.ToString(), cb_contraLedger.SelectedItem.ToString(), Convert.ToDecimal(tb_netto.Text), brutto, ust, cb_salesTaxRate.SelectedItem.ToString());

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
            ucTopBar.Instance.Controls.Remove(btn_ucTopBar_save);
            frm_create_client frm_cc = new frm_create_client();
            frm_cc.ShowDialog();
        }

        private void btn_newLedger_Click(object sender, EventArgs e)
        {
            //opens frm_new_ledger
            ucTopBar.Instance.Controls.Remove(btn_ucTopBar_save);
            frm_new_ledger frm_new_ledger = new frm_new_ledger();
            frm_new_ledger.ShowDialog();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            transaction_count = dgv_transaction.Rows.Count;
            if (transaction_count > 0)
            {
                Save_Transaction();
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
            else
            {
                MessageBox.Show("Sie haben noch keine Buchung durchgeführt", "Fehler");
            }
        }

        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {
            //executes the Save Function
            transaction_count = dgv_transaction.Rows.Count;
            if (transaction_count > 0)
            {
                Save_Transaction();
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
                    if(type == "AB" || type == "AK")
                    {
                        Ledger ledger1 = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                        Serverconnection.InsertDataLedger(ledger1);

                        Ledger ledger2 = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), 0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                        Serverconnection.InsertDataLedger(ledger2);

                        if(Convert.ToDecimal(row.Cells[6].Value) > 0)
                        {
                            Ledger ledgerUst = new Ledger(IDLE, IDC, 2500, Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[6].Value),0 , row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledgerUst);
                        }
                    }
                    else
                    {
                        Ledger ledger1 = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), 0, Convert.ToDecimal(row.Cells[4].Value), row.Cells[1].Value.ToString(), dateTransaction);
                        Serverconnection.InsertDataLedger(ledger1);

                        Ledger ledger2 = new Ledger(IDLE, IDC, Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value),  Convert.ToDecimal(row.Cells[4].Value), 0, row.Cells[1].Value.ToString(), dateTransaction);
                        Serverconnection.InsertDataLedger(ledger2);

                        if (Convert.ToDecimal(row.Cells[6].Value) > 0)
                        {
                            Ledger ledgerUst = new Ledger(IDLE, IDC, 3500, Convert.ToInt32(row.Cells[3].Value), 0, Convert.ToDecimal(row.Cells[6].Value), row.Cells[1].Value.ToString(), dateTransaction);
                            Serverconnection.InsertDataLedger(ledgerUst);
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

        Bitmap bitmap;
        private void btn_print_Click(object sender, EventArgs e)
        {

            //Resize DataGridView to full height.
            int height = dgv_transaction.Height;
            dgv_transaction.Height = dgv_transaction.RowCount * dgv_transaction.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dgv_transaction.Width, this.dgv_transaction.Height);
            dgv_transaction.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgv_transaction.Width, this.dgv_transaction.Height));

            //Resize DataGridView back to original height.
            dgv_transaction.Height = height;

            //Show the Print Preview Dialog.
            printPre.Document = printDoc;
            printPre.PrintPreviewControl.Zoom = 1;
            printPre.ShowDialog();




        }

        private void BindDataGridView()
        {

            //this.dgv_transaction.DataSource = dgv_transaction;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie wirklich diese Buchuchgen löschen?", "Achtung", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
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
    }
}
