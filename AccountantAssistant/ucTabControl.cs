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
    public partial class ucTabControl : UserControl
    {
        //var private _instance
        private static ucTabControl _instance;


        //get of Instance
        public static ucTabControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTabControl();
                }
                return _instance;
            }
        }

        //const of UcTabControl
        public ucTabControl()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //activates page_start, deactivates the others, sets line to the page
            pageStart.Visible = true;
            pageSearch.Visible = false;
            pageLedger.Visible = false;
            pageHelp.Visible = false;
            pb_line.Location = new Point(76, 25);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //activates page_search, deactivates the others, sets line to the page
            pageStart.Visible = false;
            pageSearch.Visible = true;
            pageLedger.Visible = false;
            pageHelp.Visible = false;
            pb_line.Location = new Point(147, 25);
        }

        private void btn_ledger_Click(object sender, EventArgs e)
        {
            //activates page_ledger, deactivates the others, sets line to the page
            pageStart.Visible = false;
            pageSearch.Visible = false;
            pageLedger.Visible = true;
            pageHelp.Visible = false;
            pb_line.Location = new Point(217, 25);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //activates page_help, deactivates the others, sets line to the page
            pageStart.Visible = false;
            pageSearch.Visible = false;
            pageLedger.Visible = false;
            pageHelp.Visible = true;
            pb_line.Location = new Point(281, 25);
        }

        private void btn_chooseLedger_Click(object sender, EventArgs e)
        {
            //opens the frm_ledger_overview, after closing it, tb_ledger gets the value of ledger_number
            frm_ledger_overview frm_lo = new frm_ledger_overview();
            frm_lo.ShowDialog();
            tb_ledger.Text = frm_ledger_overview.ledger_number;
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            //opens frm_balance, closes Parentform(frm_main)
            this.ParentForm.Hide();
            frm_balance frm_Balance = new frm_balance();
            frm_Balance.ShowDialog();
        }

        private void btn_search_ref_Click(object sender, EventArgs e)
        {
            //sets the search_item of the tb_search_ref, opens frm_search_refNumber, closes Parentform(frm_main)
            frm_search_refNumber.search_item = tb_search_ref.Text;

            frm_search_refNumber frm_Search_Ref = new frm_search_refNumber();
            this.ParentForm.Hide();
            frm_Search_Ref.Show();
        }

        private void btn_search_ledger_Click(object sender, EventArgs e)
        {
            //sets the search_ledger of the cb_search_ledger, opens frm_search_ledger, closes Parentform(frm_main)
            frm_search_ledger.search_ledger = cb_search_ledger.Text.ToString();

            frm_search_ledger frm_Search_Ledger = new frm_search_ledger();
            this.ParentForm.Hide();
            frm_Search_Ledger.Show();
        }

        private void btn_newLedger_Click(object sender, EventArgs e)
        {
            //if IDC is set, frm_create_ledger opens, closes Parentform(frm_main)
            if (frm_main.IDC.Equals(0))
            {
                MessageBox.Show("Sie müssen einen Klienten auswählen", "Fehler");
            }
            else
            {
                //opens frm_new_ledger
                this.ParentForm.Hide();
                frm_create_ledger frm_new_ledger = new frm_create_ledger();
                frm_new_ledger.ShowDialog();
            }
        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {
            //sets the search_date of the tb_searchDate, opens frm_search_date, closes Parentform(frm_main)
            frm_search_date.search_date = tb_searchDate.Text;

            frm_search_date frm_Search = new frm_search_date();
            this.ParentForm.Hide();
            frm_Search.Show();
        }
    }
}
