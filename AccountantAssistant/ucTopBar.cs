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
        public static Button btn_save = new Button();
        
       
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
            btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            btn_save.BackgroundImage = Properties.Resources.SaveButton;
            btn_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(3, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(30, 19);
            btn_save.TabIndex = 8;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Visible = false;
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
            if (this.ParentForm.Name == "frm_main")
            {
                btn_save.Visible = true;
            }
            else
            {
                btn_save.Visible = false;
            }
        }
    }
}
