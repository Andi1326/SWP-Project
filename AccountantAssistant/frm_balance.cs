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
    public partial class frm_balance : Form
    {
        public frm_balance()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes the form and opens frm_main
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }
     
        private void frm_balance_Load(object sender, EventArgs e)
        {
            //darkmode on every form 
            if (frm_settings.darkmode)
            {
                //if darkmode is activated the Theme changes to dark, ucTopBarDark gets diplayed and the dgv background changes to dark
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                ucTopBarDark.Instance.pb_save.Visible = false;
                dgv_balance.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_balance.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_balance.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_balance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_balance.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_balance.EnableHeadersVisualStyles = false;
            }
            else
            {
                //else the Theme changes to white, ucTopBarWhite gets displayed
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }
            //the dgv gets the data of balance
            Serverconnection.Balance(dgv_balance);

        }

        #region Print
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            //creates a Bitmap of the dgv_balance and then prints the document
            int height = dgv_balance.Height;
            dgv_balance.Height = dgv_balance.RowCount * dgv_balance.RowTemplate.Height * 2;
            bmp = new Bitmap(dgv_balance.Width, dgv_balance.Height);
            dgv_balance.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_balance.Width, dgv_balance.Height));
            dgv_balance.Height = height;

            print_Dialog.AllowSomePages = true;
            if (print_Dialog.ShowDialog() == DialogResult.OK)
            {
                print_Document.Print();
            }
        }
        #endregion

    }
}
