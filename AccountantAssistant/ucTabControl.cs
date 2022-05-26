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
        private static ucTabControl _instance;

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

        public ucTabControl()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            pageStart.Visible = true;
            pageSearch.Visible = false;
            pageLedger.Visible = false;
            pageHelp.Visible = false;
            pb_line.Location = new Point(76, 25);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pageStart.Visible = false;
            pageSearch.Visible = true;
            pageLedger.Visible = false;
            pageHelp.Visible = false;
            pb_line.Location = new Point(147, 25);
        }

        private void btn_ledger_Click(object sender, EventArgs e)
        {
            pageStart.Visible = false;
            pageSearch.Visible = false;
            pageLedger.Visible = true;
            pageHelp.Visible = false;
            pb_line.Location = new Point(217, 25);
        }

        private void btn_help_Click(object sender, EventArgs e)
        { 
            pageStart.Visible = false;
            pageSearch.Visible = false;
            pageLedger.Visible = false;
            pageHelp.Visible = true;
            pb_line.Location = new Point(281, 25);
        }

        private void ucTabControl_Load(object sender, EventArgs e)
        {
            
        }

        public static void ChangeThemeUcTabControl(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is TextBox || component is ComboBox)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = Theme_Dark.DarkBackColor;
                }
                else if (component is Label)
                {
                    component.ForeColor = Color.White;
                }
            }
        }

    }
}
