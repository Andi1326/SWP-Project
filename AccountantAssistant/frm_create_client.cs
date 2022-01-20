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
    public partial class frm_create_client : Form
    {
        public frm_create_client()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Client client = new Client (tb_firstname.Text, tb_lastname.Text, tb_telephone.Text, tb_email.Text, tb_uidnumber.Text, tb_address.Text, tb_plz.Text, tb_place.Text, tb_country.Text);
            Serverconnection.InsertDataClient(client);
            
            this.Close();
        }

        private void frm_create_client_Load(object sender, EventArgs e)
        {
            Controls.Add(ucTopBar.Instance);
            ucTopBar.Instance.Dock = DockStyle.Top;
            ucTopBar.Instance.BringToFront();
        }
    }
}
