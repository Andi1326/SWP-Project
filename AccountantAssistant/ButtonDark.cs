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
    public partial class ButtonDark : Button
    {
        public static Color fc_button = Color.White;
        public static Color bc_button = Color.Black;

        public ButtonDark()
        {
            InitializeComponent();
            
        }

        public static void ChangeTheme(Control.ControlCollection container, Form f)
        {
            f.BackColor = Color.Gray;
            foreach(Control component in container)
            {
                if(component is Button)
                {
                    component.ForeColor = fc_button;
                    component.BackColor = bc_button;
                }
            }
        }
    }
}
