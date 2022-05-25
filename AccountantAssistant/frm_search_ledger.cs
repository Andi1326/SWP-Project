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
    public partial class frm_search_ledger : Form
    {
        public static int search_ledger;
        public frm_search_ledger()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frm_m = new frm_main();
            frm_m.ShowDialog();
        }

        private void frm_search_ledger_Load(object sender, EventArgs e)
        {
            if (frm_settings.darkmode)
            {
                Theme_Dark.ChangeThemeDark(Controls, this);
                Controls.Add(ucTopBarDark.Instance);
                ucTopBarDark.Instance.Dock = DockStyle.Top;
                ucTopBarDark.Instance.BringToFront();
                dgv_search_ledger.RowsDefaultCellStyle.BackColor = Theme_Dark.DarkBackColor;
                dgv_search_ledger.BackgroundColor = Theme_Dark.DarkBackColor;
                dgv_search_ledger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_ledger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_search_ledger.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv_search_ledger.EnableHeadersVisualStyles = false;
            }
            else
            {
                Theme_White.ChangeThemeWhite(Controls, this);
                Controls.Add(ucTopBarWhite.Instance);
                ucTopBarWhite.Instance.Dock = DockStyle.Top;
                ucTopBarWhite.Instance.BringToFront();
            }

            if (frm_login.role.Equals("Mitarbeiter"))
            {
                btn_delete_ledger.Visible = false;
            }
            else if (frm_login.role.Equals("Praktikant"))
            {
                btn_delete_ledger.Visible = false;
                btn_save_ledger.Visible = false;
                dgv_search_ledger.ReadOnly = true;
                ucTopBarDark.Instance.pb_save.Visible = false;
                ucTopBarWhite.Instance.pb_save.Visible = false;
            }

            Serverconnection.Search_ledger(search_ledger, dgv_search_ledger, frm_main.IDC);
        }

        private void btn_ucTopbar_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_ledger_Click(object sender, EventArgs e)
        {
            Serverconnection.CancelTransaction(dgv_search_ledger);
            frm_cancel frm_Cancel = new frm_cancel();
            frm_Cancel.ShowDialog();
        }

        private void btn_save_ledger_Click(object sender, EventArgs e)
        {
            Serverconnection.SaveData();
        }
    }
}
