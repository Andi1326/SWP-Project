using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantAssistant
{
    internal class Theme_Dark
    {
        public static Color DarkBackColor = ColorTranslator.FromHtml("#212121");

        public static void ChangeThemeDark(Control.ControlCollection container, Form f)
        {
            f.BackColor = DarkBackColor;
            foreach (Control component in container)
            {
                if (component is Button)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = Color.Black;
                }
                else if(component is TextBox || component is ComboBox)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = DarkBackColor;
                }
                else if(component is Label)
                {
                    component.ForeColor = Color.White;
                }
                else if(component is DataGridView)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = Color.Black;
                }
                else if(component is PictureBox && component.Name.ToString() == "pb_logo")
                {
                    component.BackgroundImage = Properties.Resources.logo_blue;
                }
                else if (component is PictureBox && component.Name.ToString() == "pb_settings")
                {
                    component.BackgroundImage = Properties.Resources.gearWhite;
                }
            }

            foreach (Control component in ucTabControl.Instance.Controls)
            {
                if (component is TextBox || component is ComboBox)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = DarkBackColor;
                }
                else if (component is Label)
                {
                    component.ForeColor = Color.White;
                }
            }

            ucTabControl.Instance.lbl_TP_balance.ForeColor = Color.White;
            ucTabControl.Instance.lbl_select_ledger.ForeColor = Color.White;
            ucTabControl.Instance.lbl_eMail1.ForeColor = Color.White;
            ucTabControl.Instance.lbl_eMail2.ForeColor = Color.White;
            ucTabControl.Instance.lbl_eMailHeading.ForeColor = Color.White;
            ucTabControl.Instance.lbl_TP_date.ForeColor = Color.White;
            ucTabControl.Instance.lbl_TP_ledger.ForeColor = Color.White;
            ucTabControl.Instance.lbl_TP_referenceNumber.ForeColor = Color.White;

            ucTabControl.Instance.btn_file.ForeColor = Color.White;
            ucTabControl.Instance.btn_start.ForeColor = Color.White;
            ucTabControl.Instance.btn_search.ForeColor = Color.White;
            ucTabControl.Instance.btn_ledger.ForeColor = Color.White;
            ucTabControl.Instance.btn_help.ForeColor = Color.White;

            ucTabControl.Instance.btn_balance.ForeColor = Color.White;
            ucTabControl.Instance.btn_chooseLedger.ForeColor = Color.White;
            ucTabControl.Instance.btn_email.ForeColor = Color.White;
            ucTabControl.Instance.btn_newLedger.ForeColor = Color.White;
            ucTabControl.Instance.btn_searchDate.ForeColor = Color.White;
            ucTabControl.Instance.btn_search_ledger.ForeColor = Color.White;
            ucTabControl.Instance.btn_search_ref.ForeColor = Color.White;

            ucTabControl.Instance.tb_ledger.ForeColor = Color.White;
            ucTabControl.Instance.tb_searchDate.ForeColor = Color.White;
            ucTabControl.Instance.tb_search_ref.ForeColor = Color.White;
            ucTabControl.Instance.tb_ledger.BackColor = DarkBackColor;
            ucTabControl.Instance.tb_searchDate.BackColor = DarkBackColor;
            ucTabControl.Instance.tb_search_ref.BackColor = DarkBackColor;

            ucTabControl.Instance.cb_search_ledger.ForeColor = Color.White;
            ucTabControl.Instance.cb_search_ledger.BackColor = DarkBackColor;

            ucTabControl.Instance.linklable_email.LinkColor = Color.White;
            //ucTabControl.ChangeThemeUcTabControl(ucTabControl.Instance.Controls);
        }
    }
}
