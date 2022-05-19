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
    public partial class frm_balance : Form
    {
        public frm_balance()
        {
            InitializeComponent();
        }
       

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }
     
        private void frm_balance_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;
                dgv_balance.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_balance.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_balance.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_balance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_balance.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_balance.EnableHeadersVisualStyles = false;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }
            Serverconnection.Balance(dgv_balance);

        }
    }
}
