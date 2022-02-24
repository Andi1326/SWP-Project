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
                else if(component is TabPage || component is DataGridView || component is DateTimePicker)
                {
                    component.ForeColor = Color.White;
                    component.BackColor = DarkBackColor;
                }
                else if(component is PictureBox && component.Name.ToString() == "pb_logo")
                {
                    component.BackgroundImage = Properties.Resources.logo_blue;
                }
                else if (component is PictureBox && component.Name.ToString() == "pb_settings")
                {
                    component.BackgroundImage = Properties.Resources.gearWhite;
                }
                //else if(component is UserControl)
                //{
                //    ucTopBar.Instance.ucTopBar_Load(null, null);
                //}
            }
        }
    }
}
