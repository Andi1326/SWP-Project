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
    public partial class frm_search_ledger : Form
    {
        public static string search_ledger;
        public frm_search_ledger()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes this form and opens main
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void frm_search_ledger_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed and the dgv background changes to dark
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;
                dgv_search_ledger.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_search_ledger.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_search_ledger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_ledger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_search_ledger.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_ledger.EnableHeadersVisualStyles = false;
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

            if (frm_login.role.Equals("Mitarbeiter"))
            {
                btn_delete_ledger.Visible = false;
            }
            else if (frm_login.role.Equals("Praktikant"))
            {
                btn_delete_ledger.Visible = false;
                dgv_search_ledger.ReadOnly = true;
                ucTopBarDark.Instance.pb_save.Visible = false;
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }

            Serverconnection.Search_ledger(search_ledger, dgv_search_ledger, frm_main.IDC);
        }

        private void btn_delete_ledger_Click(object sender, EventArgs e)
        {
            try 
            { 
                Serverconnection.GetDataCancel(dgv_search_ledger);
                frm_cancel frm_Cancel = new frm_cancel();
                frm_Cancel.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Die Daten für das Stornieren konnten nicht übermittelt werden", "Fehler Stornieren Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
