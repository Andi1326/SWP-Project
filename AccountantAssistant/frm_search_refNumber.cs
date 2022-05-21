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
    public partial class frm_search_refNumber : Form
    {
        public static string search_item;
     

        public frm_search_refNumber()
        {
            InitializeComponent();
        }
        private void frm_search_refNumber_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                dgv_search_refNumber.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_search_refNumber.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_search_refNumber.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_refNumber.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_search_refNumber.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_refNumber.EnableHeadersVisualStyles = false;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
            }

            Serverconnection.Search_refNumber(search_item, dgv_search_refNumber, frm_main.IDC);
        }
        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frm_main = new frm_main();
            frm_main.Show();
        }

        private void btn_delete_ref_Click(object sender, EventArgs e)
        {
            Serverconnection.DeleteData(dgv_search_refNumber);
        }

        private void btn_save_ref_Click(object sender, EventArgs e)
        {
            Serverconnection.SaveData();
        }
    }

}
