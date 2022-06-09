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
                ucTopBarDark.Instance.pb_save.Visible = false;

                dgv_search_date.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_search_date.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_search_date.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_date.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_search_date.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_date.EnableHeadersVisualStyles = false;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }

            if (frm_login.role.Equals("Mitarbeiter"))
            {
                btn_delete_date.Visible = false;
            }
            else if (frm_login.role.Equals("Praktikant"))
            {
                btn_delete_date.Visible = false;
                dgv_search_date.ReadOnly = true;
                ucTopBarDark.Instance.pb_save.Visible = false;
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }

            Serverconnection.Search_Date(search_date, dgv_search_date, frm_main.IDC);
        }


        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void btn_delete_ref_Click(object sender, EventArgs e)
        {
            try 
            { 
                Serverconnection.GetDataCancel(dgv_search_date);
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
