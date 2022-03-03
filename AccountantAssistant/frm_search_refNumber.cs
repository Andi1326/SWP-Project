﻿using System;
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
    public partial class frm_search_refNumber : Form
    {
        public static string search_item;
     

        public frm_search_refNumber()
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
        public static Button btn_ucTopBar_save = new Button();
        private void frm_search_refNumber_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
            }

            ucTopBarWhite.Instance.Controls.Add(btn_ucTopBar_save);
            Serverconnection.Search_refNumber(search_item, dgv_search_refNumber, frm_main.IDC);
        }
        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_main frm_main = new frm_main();
            this.Close();
            frm_main.Show();
        }

        private void btn_delete_ref_Click(object sender, EventArgs e)
        {
            Serverconnection.DeleteData(dgv_search_refNumber);
        }

        private void btn_save_ref_Click(object sender, EventArgs e)
        {
            Serverconnection.SaveData();
        }
    }

}
