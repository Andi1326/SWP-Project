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
    public partial class frm_search_date : Form
    {
        public static string search_date;
        public frm_search_date()
        {
            InitializeComponent();
        }

        private void frm_search_date_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
            }

            Serverconnection.Search_Date(search_date, dgv_search_refNumber, frm_main.IDC);
        }


        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
            this.Hide();
            
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
