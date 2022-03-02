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
        //creates the ucTopBar instance
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

        #region pb_minimize

        private void pb_minimize_MouseHover(object sender, EventArgs e)
        {
            //if the minimize Box gets hovered the backcolor changes to LightGray
            pb_minimize.BackColor = Color.LightGray;
        }

        private void pb_minimize_MouseLeave(object sender, EventArgs e)
        {
            //if the minimize Box gets hovered the backcolor changes to White
            pb_minimize.BackColor = Color.Transparent;
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            //sets the Windowstate to minimized
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region pb_maximize
        private void pb_maximize_MouseHover(object sender, EventArgs e)
        {
            //if the maximize Box gets hovered the backcolor changes to LightGray
            pb_maximize.BackColor = Color.LightGray;
        }

        private void pb_maximize_MouseLeave(object sender, EventArgs e)
        {
            //if the maximize Box gets hovered the backcolor changes to White

            pb_maximize.BackColor = Color.Transparent;

        }

        private void pb_maximize_Click(object sender, EventArgs e)
        {
            //if the Windowstate is already Maximized it sets to normal
            if (this.ParentForm.WindowState == FormWindowState.Maximized)
            {
                this.ParentForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                //if it's not maximized it sets the Windowstate to maximized
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        #region pb_close
        private void pb_close_Click(object sender, EventArgs e)
        {
            //if the parentForm ist frm_login it ends the program
            if (this.ParentForm.Name.Equals("frm_login"))
            {
                Application.Exit();
            }
            else if (this.ParentForm.Name.Equals("frm_register") || this.ParentForm.Name.Equals("frm_forget_password"))
            {
                //if the ParentForm is frm_register or frm_forget_password it hides the actual form and opens frm_login
                this.ParentForm.Hide();
                frm_login frm_login = new frm_login();
                frm_login.ShowDialog();
            }
            else if (this.ParentForm.Name.Equals("frm_main"))
            {
                //if the ParentForm is frm_main it hides the actual form and opens frm_login and removes the saveButton
                Controls.Remove(frm_main.btn_ucTopBar_save);
                this.ParentForm.Hide();
                frm_login frm_login = new frm_login();
                frm_login.ShowDialog();
            }
            else
            {
                //if it's another Form it closes the ParentForm
                this.ParentForm.Close();
            }
        }

        private void pb_close_MouseHover(object sender, EventArgs e)
        {
            //if the close Box gets hovered the backcolor changes to Red
            pb_close.BackColor = Color.Red;
        }

        private void pb_close_MouseLeave(object sender, EventArgs e)
        {
            //if the close Box gets hovered the backcolor changes to White
            pb_close.BackColor = Color.Transparent;
        }

        #endregion

        private void ucTopBar_Load(object sender, EventArgs e)
        {

            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this.ParentForm);
                pb_close.Image = Properties.Resources.crossWhite;
                pb_maximize.Image = Properties.Resources.MaximizeBoxWhite;
                pb_minimize.Image = Properties.Resources.MinimizeBoxWhite;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this.ParentForm);
                pb_close.Image = Properties.Resources.cross;
                pb_maximize.Image = Properties.Resources.MaximizeBox;
                pb_minimize.Image = Properties.Resources.Minimize_Box2;
            }
        }

        public static void ChangeImages()
        {
            
        }
    }
}
