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
    public partial class frm_new_ledger : Form
    {
        public frm_new_ledger()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //closes frm_new_ledger
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //checks if the ledger already exists
            //checks if the textboxes are empty
            if (Serverconnection.ProofLedger(tb_number, frm_main.IDC))
            {
                MessageBox.Show("Dieses Konto existiert bereits", "Konto existiert bereits");
            }
            else if(tb_number.Text == "")
            {
                MessageBox.Show("Sie müssen eine Kontonummer eingeben", "Keine Kontonummer");
            }
            else if(tb_name.Text == "")
            {
                MessageBox.Show("Sie müssen einen Kontonamen eingeben", "Kein Kontoname");
            }
            else
            {
                //Saves the new Ledger into the table AllLedgers
                AllLedgers newAllLedgers = new AllLedgers(frm_main.IDC, Convert.ToInt32(tb_number.Text), tb_name.Text, cb_type.SelectedItem.ToString());
                Serverconnection.InsertDataAllLedgers(newAllLedgers);
            }
            this.Close();
        }

        private void frm_new_ledger_Load(object sender, EventArgs e)
        {
            //Adds the User Control to the form
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();
        }
    }
}
