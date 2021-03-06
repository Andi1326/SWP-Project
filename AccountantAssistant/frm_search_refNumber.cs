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
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed and the dgv background changes to dark
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;

                dgv_search_refNumber.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_search_refNumber.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_search_refNumber.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_refNumber.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_search_refNumber.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_refNumber.EnableHeadersVisualStyles = false;
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

            //if the role is 'Mitarbeiter' btn_delete gets invisible, else if the role is 'Praktikant' btn_delete and the pictureBoxes gets invisible and the dgv.Readonly gets activated
            if (frm_login.role.Equals("Mitarbeiter"))
            {
                btn_delete_ref.Visible = false;
            }
            else if (frm_login.role.Equals("Praktikant"))
            {
                btn_delete_ref.Visible = false;
                dgv_search_refNumber.ReadOnly = true;
                ucTopBarDark.Instance.pb_save.Visible = false;
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }

            //executes the function Search_refNumber
            Serverconnection.Search_refNumber(search_item, dgv_search_refNumber, frm_main.IDC);
        }
   

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes this form and opens main
            this.Hide();
            frm_main frm_main = new frm_main();
            frm_main.Show();
        }

        private void btn_delete_ref_Click(object sender, EventArgs e)
        {
            //gets the data of the accouting record to be cancelled and opens frm_cancel
            try
            { 
                Serverconnection.GetDataCancel(dgv_search_refNumber);
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
