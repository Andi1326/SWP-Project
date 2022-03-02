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
    public partial class frm_search_ledger : Form
    {
        public static int search_ledger;
        public frm_search_ledger()
        {
            InitializeComponent();
            #region btn_ucTopBar_save Button
            btn_ucTopBar_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            btn_ucTopBar_save.BackgroundImage = Properties.Resources.SaveButton;
            btn_ucTopBar_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ucTopBar_save.FlatAppearance.BorderSize = 0;
            btn_ucTopBar_save.FlatStyle = FlatStyle.Flat;
            btn_ucTopBar_save.Location = new Point(3, 3);
            btn_ucTopBar_save.Name = "btn_save";
            btn_ucTopBar_save.Size = new Size(30, 19);
            btn_ucTopBar_save.TabIndex = 8;
            btn_ucTopBar_save.UseVisualStyleBackColor = true;
            btn_ucTopBar_save.Click += new System.EventHandler(this.btn_ucTopbar_save_Click);
            #endregion
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_main frm_Main = new frm_main();
            this.Hide();
        }

        private void frm_search_ledger_Load(object sender, EventArgs e)
        {
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();
            ucTopBar.Instance.Controls.Add(btn_ucTopBar_save);
            Serverconnection.Search_ledger(search_ledger, dgv_search_ledger, frm_main.IDC);
        }
        public static Button btn_ucTopBar_save = new Button();

        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_ledger_Click(object sender, EventArgs e)
        {
            Serverconnection.DeleteData(dgv_search_ledger);
        }

        private void btn_save_ledger_Click(object sender, EventArgs e)
        {
            Serverconnection.SaveData();
        }
    }
}
