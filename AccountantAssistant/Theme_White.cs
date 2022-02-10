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
        public static Color fc_button = Color.White;
        public static Color bc_button = Color.Black;
        public static Color ButtonBgColor = ColorTranslator.FromHtml("#047dda");

        public static void ChangeThemeWhite(Control.ControlCollection container, Form f)
        {
            f.BackColor = Color.White;
            foreach (Control component in container)
            {
                if (component is Button && component.Tag != "blue")
                {
                    component.ForeColor = Color.Black;
                    component.BackColor = Color.White;
                }
                else if(component is Button && component.Tag == "blue")
                {
                    component.ForeColor = Color.White;
                    component.BackColor = ButtonBgColor;
                }
                else if(component is TextBox || component is ComboBox)
                {
                    component.ForeColor = Color.Black;
                    component.BackColor = Color.White;
                }
                else if(component is Label && component.Tag != "blue")
                {
                    component.ForeColor = Color.Black;
                }
                else if (component is Label && component.Tag == "blue")
                {
                    component.ForeColor = ButtonBgColor;
                }
            }
        }
    }
}
