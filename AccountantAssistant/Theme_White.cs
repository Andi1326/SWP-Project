using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantAssistant
{
    internal class Theme_White
    {
        //button color of the white theme
        public static Color ButtonBgColor = ColorTranslator.FromHtml("#047dda");

        //changes the color of the ucTabControl on every form
        public static void ChangeThemeWhite(Control.ControlCollection container, Form f)
        {
            ucTabControl.Instance.lbl_TP_balance.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_select_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_eMail1.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_eMail2.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_eMailHeading.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_TP_date.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_TP_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.lbl_TP_referenceNumber.ForeColor = Color.Black;

            ucTabControl.Instance.btn_file.ForeColor = Color.Black;
            ucTabControl.Instance.btn_start.ForeColor = Color.Black;
            ucTabControl.Instance.btn_search.ForeColor = Color.Black;
            ucTabControl.Instance.btn_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.btn_help.ForeColor = Color.Black;

            ucTabControl.Instance.btn_file.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_start.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_search.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_ledger.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_help.FlatAppearance.MouseOverBackColor = Color.LightGray;

            ucTabControl.Instance.btn_balance.ForeColor = Color.Black;
            ucTabControl.Instance.btn_chooseLedger.ForeColor = Color.Black;
            ucTabControl.Instance.btn_email.ForeColor = Color.Black;
            ucTabControl.Instance.btn_newLedger.ForeColor = Color.Black;
            ucTabControl.Instance.btn_searchDate.ForeColor = Color.Black;
            ucTabControl.Instance.btn_search_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.btn_search_ref.ForeColor = Color.Black;

            ucTabControl.Instance.btn_balance.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_chooseLedger.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_email.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_newLedger.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_searchDate.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_search_ledger.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ucTabControl.Instance.btn_search_ref.FlatAppearance.MouseOverBackColor = Color.LightGray;

            ucTabControl.Instance.tb_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.tb_searchDate.ForeColor = Color.Black;
            ucTabControl.Instance.tb_search_ref.ForeColor = Color.Black;
            ucTabControl.Instance.tb_ledger.BackColor = Color.White;
            ucTabControl.Instance.tb_searchDate.BackColor = Color.White;
            ucTabControl.Instance.tb_search_ref.BackColor = Color.White;

            ucTabControl.Instance.cb_search_ledger.ForeColor = Color.Black;
            ucTabControl.Instance.cb_search_ledger.BackColor = Color.White;

            ucTabControl.Instance.linklable_email.LinkColor = Color.Black;

            ucTabControl.Instance.pb_line.BackColor = Color.Black;
        }
    }
}
