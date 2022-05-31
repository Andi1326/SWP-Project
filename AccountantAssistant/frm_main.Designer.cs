
namespace AccountantAssistant
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.lbl_client = new System.Windows.Forms.Label();
            this.cb_clients = new System.Windows.Forms.ComboBox();
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_referenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ledger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_contraLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ust_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_debit_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_contraLedger = new System.Windows.Forms.Label();
            this.lbl_netto = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_referenceNumber = new System.Windows.Forms.Label();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.cb_salesTaxRate = new System.Windows.Forms.ComboBox();
            this.tb_netto = new System.Windows.Forms.TextBox();
            this.tb_referenceNumber = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_save_main = new System.Windows.Forms.Button();
            this.printPre = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.cb_contraLedger = new System.Windows.Forms.ComboBox();
            this.printDia = new System.Windows.Forms.PrintDialog();
            this.rbtn_s = new System.Windows.Forms.RadioButton();
            this.rbtn_h = new System.Windows.Forms.RadioButton();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.datePicker = new AccountantAssistant.RJDatePicker();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 596);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 43;
            this.btn_back.Tag = "blue";
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.pnl_1.Controls.Add(this.btn_newClient);
            this.pnl_1.Controls.Add(this.btn_print);
            this.pnl_1.Controls.Add(this.btn_new);
            this.pnl_1.Controls.Add(this.btn_save);
            this.pnl_1.Controls.Add(this.pb_back);
            this.pnl_1.Location = new System.Drawing.Point(1003, 60);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(115, 232);
            this.pnl_1.TabIndex = 44;
            this.pnl_1.Visible = false;
            // 
            // btn_newClient
            // 
            this.btn_newClient.FlatAppearance.BorderSize = 0;
            this.btn_newClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newClient.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newClient.ForeColor = System.Drawing.Color.White;
            this.btn_newClient.Location = new System.Drawing.Point(0, 175);
            this.btn_newClient.Name = "btn_newClient";
            this.btn_newClient.Size = new System.Drawing.Size(122, 36);
            this.btn_newClient.TabIndex = 48;
            this.btn_newClient.Tag = "normal";
            this.btn_newClient.Text = " Neuer Klient";
            this.btn_newClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newClient.UseVisualStyleBackColor = true;
            this.btn_newClient.Click += new System.EventHandler(this.btn_newClient_Click);
            // 
            // btn_print
            // 
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(2, 135);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(109, 34);
            this.btn_print.TabIndex = 47;
            this.btn_print.Tag = "normal";
            this.btn_print.Text = "Drucken";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(3, 95);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(109, 34);
            this.btn_new.TabIndex = 46;
            this.btn_new.Tag = "normal";
            this.btn_new.Text = "Neu";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(3, 55);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 34);
            this.btn_save.TabIndex = 45;
            this.btn_save.Tag = "normal";
            this.btn_save.Text = "Speichern";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pb_back
            // 
            this.pb_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_back.Image = global::AccountantAssistant.Properties.Resources.arrow_Back;
            this.pb_back.Location = new System.Drawing.Point(30, 16);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(39, 33);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_back.TabIndex = 45;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // lbl_client
            // 
            this.lbl_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(773, 32);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(57, 18);
            this.lbl_client.TabIndex = 47;
            this.lbl_client.Text = "Klient:";
            // 
            // cb_clients
            // 
            this.cb_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.Location = new System.Drawing.Point(836, 33);
            this.cb_clients.Name = "cb_clients";
            this.cb_clients.Size = new System.Drawing.Size(232, 21);
            this.cb_clients.TabIndex = 48;
            this.cb_clients.SelectedIndexChanged += new System.EventHandler(this.cb_clients_SelectedIndexChanged);
            // 
            // dgv_transaction
            // 
            this.dgv_transaction.AllowUserToAddRows = false;
            this.dgv_transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_transaction.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_date,
            this.column_referenceNumber,
            this.column_ledger,
            this.column_contraLedger,
            this.column_netto,
            this.column_brutto,
            this.column_ust,
            this.column_ust_rate,
            this.column_debit_credit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transaction.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_transaction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_transaction.Location = new System.Drawing.Point(5, 144);
            this.dgv_transaction.Name = "dgv_transaction";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_transaction.Size = new System.Drawing.Size(927, 389);
            this.dgv_transaction.TabIndex = 49;
            // 
            // column_date
            // 
            this.column_date.HeaderText = "Datum";
            this.column_date.Name = "column_date";
            this.column_date.Width = 80;
            // 
            // column_referenceNumber
            // 
            this.column_referenceNumber.HeaderText = "Belegnummer";
            this.column_referenceNumber.Name = "column_referenceNumber";
            this.column_referenceNumber.Width = 120;
            // 
            // column_ledger
            // 
            this.column_ledger.HeaderText = "Konto";
            this.column_ledger.Name = "column_ledger";
            this.column_ledger.Width = 80;
            // 
            // column_contraLedger
            // 
            this.column_contraLedger.HeaderText = "Gegenkonto";
            this.column_contraLedger.Name = "column_contraLedger";
            // 
            // column_netto
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.column_netto.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_netto.HeaderText = "Nettobetrag";
            this.column_netto.Name = "column_netto";
            this.column_netto.Width = 120;
            // 
            // column_brutto
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.column_brutto.DefaultCellStyle = dataGridViewCellStyle3;
            this.column_brutto.HeaderText = "Bruttobetrag";
            this.column_brutto.Name = "column_brutto";
            this.column_brutto.Width = 120;
            // 
            // column_ust
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.column_ust.DefaultCellStyle = dataGridViewCellStyle4;
            this.column_ust.HeaderText = "Ust";
            this.column_ust.Name = "column_ust";
            this.column_ust.Width = 60;
            // 
            // column_ust_rate
            // 
            dataGridViewCellStyle5.Format = "0 \"%\"";
            dataGridViewCellStyle5.NullValue = null;
            this.column_ust_rate.DefaultCellStyle = dataGridViewCellStyle5;
            this.column_ust_rate.HeaderText = "Ust-Satz";
            this.column_ust_rate.Name = "column_ust_rate";
            this.column_ust_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_ust_rate.Width = 80;
            // 
            // column_debit_credit
            // 
            this.column_debit_credit.HeaderText = "Soll/Haben";
            this.column_debit_credit.Name = "column_debit_credit";
            // 
            // lbl_contraLedger
            // 
            this.lbl_contraLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_contraLedger.AutoSize = true;
            this.lbl_contraLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraLedger.Location = new System.Drawing.Point(333, 536);
            this.lbl_contraLedger.Name = "lbl_contraLedger";
            this.lbl_contraLedger.Size = new System.Drawing.Size(86, 18);
            this.lbl_contraLedger.TabIndex = 50;
            this.lbl_contraLedger.Text = "Gegenkonto";
            // 
            // lbl_netto
            // 
            this.lbl_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_netto.AutoSize = true;
            this.lbl_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netto.Location = new System.Drawing.Point(490, 536);
            this.lbl_netto.Name = "lbl_netto";
            this.lbl_netto.Size = new System.Drawing.Size(86, 18);
            this.lbl_netto.TabIndex = 51;
            this.lbl_netto.Text = "Nettobetrag";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(42, 536);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 18);
            this.lbl_date.TabIndex = 52;
            this.lbl_date.Text = "Datum";
            // 
            // lbl_referenceNumber
            // 
            this.lbl_referenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_referenceNumber.AutoSize = true;
            this.lbl_referenceNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referenceNumber.Location = new System.Drawing.Point(163, 536);
            this.lbl_referenceNumber.Name = "lbl_referenceNumber";
            this.lbl_referenceNumber.Size = new System.Drawing.Size(98, 18);
            this.lbl_referenceNumber.TabIndex = 53;
            this.lbl_referenceNumber.Text = "Belegnummer";
            // 
            // lbl_ust
            // 
            this.lbl_ust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ust.Location = new System.Drawing.Point(669, 536);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(63, 18);
            this.lbl_ust.TabIndex = 54;
            this.lbl_ust.Text = "Ust-Satz";
            // 
            // cb_salesTaxRate
            // 
            this.cb_salesTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_salesTaxRate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_salesTaxRate.FormattingEnabled = true;
            this.cb_salesTaxRate.Items.AddRange(new object[] {
            "0",
            "10",
            "13",
            "20"});
            this.cb_salesTaxRate.Location = new System.Drawing.Point(615, 557);
            this.cb_salesTaxRate.Name = "cb_salesTaxRate";
            this.cb_salesTaxRate.Size = new System.Drawing.Size(155, 26);
            this.cb_salesTaxRate.TabIndex = 5;
            // 
            // tb_netto
            // 
            this.tb_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_netto.Location = new System.Drawing.Point(454, 557);
            this.tb_netto.Name = "tb_netto";
            this.tb_netto.Size = new System.Drawing.Size(155, 26);
            this.tb_netto.TabIndex = 4;
            // 
            // tb_referenceNumber
            // 
            this.tb_referenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_referenceNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_referenceNumber.Location = new System.Drawing.Point(144, 557);
            this.tb_referenceNumber.Name = "tb_referenceNumber";
            this.tb_referenceNumber.Size = new System.Drawing.Size(143, 26);
            this.tb_referenceNumber.TabIndex = 2;
            // 
            // btn_enter
            // 
            this.btn_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(820, 557);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(96, 26);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Tag = "normal";
            this.btn_enter.Text = "Buchen";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_save_main
            // 
            this.btn_save_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_main.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_main.ForeColor = System.Drawing.Color.Black;
            this.btn_save_main.Location = new System.Drawing.Point(938, 500);
            this.btn_save_main.Name = "btn_save_main";
            this.btn_save_main.Size = new System.Drawing.Size(109, 33);
            this.btn_save_main.TabIndex = 7;
            this.btn_save_main.Tag = "normal";
            this.btn_save_main.Text = "Speichern";
            this.btn_save_main.UseVisualStyleBackColor = true;
            this.btn_save_main.Click += new System.EventHandler(this.btn_save_main_Click);
            // 
            // printPre
            // 
            this.printPre.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPre.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPre.ClientSize = new System.Drawing.Size(400, 300);
            this.printPre.Document = this.printDoc;
            this.printPre.Enabled = true;
            this.printPre.Icon = ((System.Drawing.Icon)(resources.GetObject("printPre.Icon")));
            this.printPre.Name = "printPre";
            this.printPre.ShowIcon = false;
            this.printPre.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // cb_contraLedger
            // 
            this.cb_contraLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_contraLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_contraLedger.FormattingEnabled = true;
            this.cb_contraLedger.Location = new System.Drawing.Point(293, 557);
            this.cb_contraLedger.Name = "cb_contraLedger";
            this.cb_contraLedger.Size = new System.Drawing.Size(155, 26);
            this.cb_contraLedger.Sorted = true;
            this.cb_contraLedger.TabIndex = 3;
            // 
            // printDia
            // 
            this.printDia.UseEXDialog = true;
            // 
            // rbtn_s
            // 
            this.rbtn_s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_s.AutoSize = true;
            this.rbtn_s.Checked = true;
            this.rbtn_s.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_s.Location = new System.Drawing.Point(779, 548);
            this.rbtn_s.Name = "rbtn_s";
            this.rbtn_s.Size = new System.Drawing.Size(33, 20);
            this.rbtn_s.TabIndex = 55;
            this.rbtn_s.TabStop = true;
            this.rbtn_s.Text = "S";
            this.rbtn_s.UseVisualStyleBackColor = true;
            // 
            // rbtn_h
            // 
            this.rbtn_h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_h.AutoSize = true;
            this.rbtn_h.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_h.Location = new System.Drawing.Point(779, 567);
            this.rbtn_h.Name = "rbtn_h";
            this.rbtn_h.Size = new System.Drawing.Size(33, 20);
            this.rbtn_h.TabIndex = 56;
            this.rbtn_h.Text = "H";
            this.rbtn_h.UseVisualStyleBackColor = true;
            // 
            // pb_settings
            // 
            this.pb_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_settings.BackColor = System.Drawing.Color.Transparent;
            this.pb_settings.BackgroundImage = global::AccountantAssistant.Properties.Resources.gear;
            this.pb_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_settings.Location = new System.Drawing.Point(1087, 33);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(32, 21);
            this.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_settings.TabIndex = 46;
            this.pb_settings.TabStop = false;
            this.pb_settings.Tag = "settings";
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePicker.BorderColor = System.Drawing.Color.DimGray;
            this.datePicker.BorderSize = 1;
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(12, 557);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 26);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 26);
            this.datePicker.SkinColor = System.Drawing.Color.White;
            this.datePicker.TabIndex = 57;
            this.datePicker.TextColor = System.Drawing.Color.Black;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 633);
            this.ControlBox = false;
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.cb_clients);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.rbtn_h);
            this.Controls.Add(this.rbtn_s);
            this.Controls.Add(this.cb_contraLedger);
            this.Controls.Add(this.btn_save_main);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_referenceNumber);
            this.Controls.Add(this.tb_netto);
            this.Controls.Add(this.cb_salesTaxRate);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.lbl_referenceNumber);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_netto);
            this.Controls.Add(this.lbl_contraLedger);
            this.Controls.Add(this.dgv_transaction);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1146, 633);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            this.pnl_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.Label lbl_contraLedger;
        private System.Windows.Forms.Label lbl_netto;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_referenceNumber;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.ComboBox cb_salesTaxRate;
        private System.Windows.Forms.TextBox tb_netto;
        private System.Windows.Forms.TextBox tb_referenceNumber;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_save_main;
        private System.Windows.Forms.PrintPreviewDialog printPre;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.ComboBox cb_contraLedger;
        private System.Windows.Forms.PrintDialog printDia;
        private System.Windows.Forms.RadioButton rbtn_s;
        private System.Windows.Forms.RadioButton rbtn_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_referenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_contraLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ust;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ust_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_debit_credit;
        private RJDatePicker datePicker;
        public System.Windows.Forms.ComboBox cb_clients;
    }
}