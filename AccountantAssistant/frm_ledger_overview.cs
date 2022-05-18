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
    public partial class frm_ledger_overview : Form
    {
        public static string ledger_number;

        public frm_ledger_overview()
        {
            InitializeComponent();
        }

        private void frm_ledger_overview_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                dgv_ledger.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_ledger.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_ledger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_ledger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_ledger.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_ledger.EnableHeadersVisualStyles = false;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
            }

            Serverconnection.ShowLedgers(dgv_ledger, frm_main.IDC);
            dgv_ledger.Sort(this.dgv_ledger.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ledger_number = "";
            this.Hide();
        }


        private void dgv_ledger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ledger_number = dgv_ledger.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
        }
    }
}
