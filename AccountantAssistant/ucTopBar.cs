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

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(this.ParentForm.Name == "frm_login")
            {
                Application.Exit();
            }
            else if (this.ParentForm.Name == "frm_register" || this.ParentForm.Name == "frm_forget_password")
            {
                this.ParentForm.Hide();
                frm_login frm_login = new frm_login();
                frm_login.ShowDialog();
            }
            else if(this.ParentForm.Name == "frm_main")
            {
                this.ParentForm.Hide();
                frm_login frm_Login = new frm_login();
                frm_Login.ShowDialog();
            }
            else
            {
                this.ParentForm.Close();
            }
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Maximized)
            {
                this.ParentForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void ucTopBar_Load(object sender, EventArgs e)
        {

        }
    }
}
