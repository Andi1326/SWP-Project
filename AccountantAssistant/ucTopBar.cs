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
    public partial class ucTopBar : UserControl
    {
        private static ucTopBar _instance;
        public static ucTopBar Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ucTopBar();
                }
                return _instance;
            }
        }
        public ucTopBar()
        {
            InitializeComponent();
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void pb_maximize_Click(object sender, EventArgs e)
        {
            if(this.ParentForm.WindowState == FormWindowState.Maximized)
            {
                this.ParentForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
