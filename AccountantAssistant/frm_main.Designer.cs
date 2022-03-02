
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tabCon1 = new System.Windows.Forms.TabControl();
            this.tabPage_file = new System.Windows.Forms.TabPage();
            this.tabPage_start = new System.Windows.Forms.TabPage();
            this.cb_ledger = new System.Windows.Forms.ComboBox();
            this.lbl_select_ledger = new System.Windows.Forms.Label();
            this.tabPage_search = new System.Windows.Forms.TabPage();
            this.btn_searchDate = new System.Windows.Forms.Button();
            this.tb_searchDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search_ref = new System.Windows.Forms.Button();
            this.tb_search_ref = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_ledger = new System.Windows.Forms.TabPage();
            this.btn_search_ledger = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_search_ledger = new System.Windows.Forms.ComboBox();
            this.btn_newLedger = new System.Windows.Forms.Button();
            this.tabPage_help = new System.Windows.Forms.TabPage();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
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
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.printPre = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.cb_contraLedger = new System.Windows.Forms.ComboBox();
            this.printDia = new System.Windows.Forms.PrintDialog();
            this.rbtn_s = new System.Windows.Forms.RadioButton();
            this.rbtn_h = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.tabCon1.SuspendLayout();
            this.tabPage_start.SuspendLayout();
            this.tabPage_search.SuspendLayout();
            this.tabPage_ledger.SuspendLayout();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCon1
            // 
            this.tabCon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCon1.Controls.Add(this.tabPage_file);
            this.tabCon1.Controls.Add(this.tabPage_start);
            this.tabCon1.Controls.Add(this.tabPage_search);
            this.tabCon1.Controls.Add(this.tabPage_ledger);
            this.tabCon1.Controls.Add(this.tabPage_help);
            this.tabCon1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCon1.Location = new System.Drawing.Point(1, 29);
            this.tabCon1.Name = "tabCon1";
            this.tabCon1.SelectedIndex = 0;
            this.tabCon1.Size = new System.Drawing.Size(915, 109);
            this.tabCon1.TabIndex = 0;
            this.tabCon1.SelectedIndexChanged += new System.EventHandler(this.tabCon1_SelectedIndexChanged);
            // 
            // tabPage_file
            // 
            this.tabPage_file.BackColor = System.Drawing.Color.White;
            this.tabPage_file.Location = new System.Drawing.Point(4, 27);
            this.tabPage_file.Name = "tabPage_file";
            this.tabPage_file.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_file.Size = new System.Drawing.Size(907, 78);
            this.tabPage_file.TabIndex = 0;
            this.tabPage_file.Text = "Datei";
            // 
            // tabPage_start
            // 
            this.tabPage_start.BackColor = System.Drawing.Color.White;
            this.tabPage_start.Controls.Add(this.button1);
            this.tabPage_start.Controls.Add(this.label4);
            this.tabPage_start.Controls.Add(this.cb_ledger);
            this.tabPage_start.Controls.Add(this.lbl_select_ledger);
            this.tabPage_start.Location = new System.Drawing.Point(4, 27);
            this.tabPage_start.Name = "tabPage_start";
            this.tabPage_start.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_start.Size = new System.Drawing.Size(907, 78);
            this.tabPage_start.TabIndex = 1;
            this.tabPage_start.Text = "Start";
            // 
            // cb_ledger
            // 
            this.cb_ledger.FormattingEnabled = true;
            this.cb_ledger.Location = new System.Drawing.Point(133, 21);
            this.cb_ledger.Name = "cb_ledger";
            this.cb_ledger.Size = new System.Drawing.Size(188, 26);
            this.cb_ledger.Sorted = true;
            this.cb_ledger.TabIndex = 3;
            this.cb_ledger.SelectedIndexChanged += new System.EventHandler(this.cb_ledger_SelectedIndexChanged);
            // 
            // lbl_select_ledger
            // 
            this.lbl_select_ledger.AutoSize = true;
            this.lbl_select_ledger.Location = new System.Drawing.Point(9, 24);
            this.lbl_select_ledger.Name = "lbl_select_ledger";
            this.lbl_select_ledger.Size = new System.Drawing.Size(118, 18);
            this.lbl_select_ledger.TabIndex = 2;
            this.lbl_select_ledger.Text = "Konto auswählen";
            // 
            // tabPage_search
            // 
            this.tabPage_search.Controls.Add(this.btn_searchDate);
            this.tabPage_search.Controls.Add(this.tb_searchDate);
            this.tabPage_search.Controls.Add(this.label2);
            this.tabPage_search.Controls.Add(this.btn_search_ref);
            this.tabPage_search.Controls.Add(this.tb_search_ref);
            this.tabPage_search.Controls.Add(this.label1);
            this.tabPage_search.Location = new System.Drawing.Point(4, 27);
            this.tabPage_search.Name = "tabPage_search";
            this.tabPage_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_search.Size = new System.Drawing.Size(907, 78);
            this.tabPage_search.TabIndex = 2;
            this.tabPage_search.Text = "Suche";
            this.tabPage_search.UseVisualStyleBackColor = true;
            // 
            // btn_searchDate
            // 
            this.btn_searchDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_searchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDate.ForeColor = System.Drawing.Color.Black;
            this.btn_searchDate.Location = new System.Drawing.Point(781, 9);
            this.btn_searchDate.Name = "btn_searchDate";
            this.btn_searchDate.Size = new System.Drawing.Size(83, 23);
            this.btn_searchDate.TabIndex = 60;
            this.btn_searchDate.Tag = "normal";
            this.btn_searchDate.Text = "Suchen";
            this.btn_searchDate.UseVisualStyleBackColor = true;
            this.btn_searchDate.Click += new System.EventHandler(this.btn_searchDate_Click);
            // 
            // tb_searchDate
            // 
            this.tb_searchDate.Location = new System.Drawing.Point(577, 12);
            this.tb_searchDate.Multiline = true;
            this.tb_searchDate.Name = "tb_searchDate";
            this.tb_searchDate.Size = new System.Drawing.Size(198, 20);
            this.tb_searchDate.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Datum:";
            // 
            // btn_search_ref
            // 
            this.btn_search_ref.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ref.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ref.ForeColor = System.Drawing.Color.Black;
            this.btn_search_ref.Location = new System.Drawing.Point(331, 14);
            this.btn_search_ref.Name = "btn_search_ref";
            this.btn_search_ref.Size = new System.Drawing.Size(83, 23);
            this.btn_search_ref.TabIndex = 57;
            this.btn_search_ref.Tag = "normal";
            this.btn_search_ref.Text = "Suchen";
            this.btn_search_ref.UseVisualStyleBackColor = true;
            this.btn_search_ref.Click += new System.EventHandler(this.btn_search_ref_Click_1);
            // 
            // tb_search_ref
            // 
            this.tb_search_ref.Location = new System.Drawing.Point(127, 17);
            this.tb_search_ref.Multiline = true;
            this.tb_search_ref.Name = "tb_search_ref";
            this.tb_search_ref.Size = new System.Drawing.Size(198, 20);
            this.tb_search_ref.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Belegnummer:";
            // 
            // tabPage_ledger
            // 
            this.tabPage_ledger.Controls.Add(this.btn_search_ledger);
            this.tabPage_ledger.Controls.Add(this.label3);
            this.tabPage_ledger.Controls.Add(this.cb_search_ledger);
            this.tabPage_ledger.Controls.Add(this.btn_newLedger);
            this.tabPage_ledger.Location = new System.Drawing.Point(4, 27);
            this.tabPage_ledger.Name = "tabPage_ledger";
            this.tabPage_ledger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ledger.Size = new System.Drawing.Size(907, 78);
            this.tabPage_ledger.TabIndex = 3;
            this.tabPage_ledger.Text = "Konto";
            this.tabPage_ledger.UseVisualStyleBackColor = true;
            // 
            // btn_search_ledger
            // 
            this.btn_search_ledger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ledger.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ledger.ForeColor = System.Drawing.Color.Black;
            this.btn_search_ledger.Location = new System.Drawing.Point(537, 28);
            this.btn_search_ledger.Name = "btn_search_ledger";
            this.btn_search_ledger.Size = new System.Drawing.Size(83, 23);
            this.btn_search_ledger.TabIndex = 61;
            this.btn_search_ledger.Tag = "normal";
            this.btn_search_ledger.Text = "Suchen";
            this.btn_search_ledger.UseVisualStyleBackColor = true;
            this.btn_search_ledger.Click += new System.EventHandler(this.btn_search_ledger_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Konto:";
            // 
            // cb_search_ledger
            // 
            this.cb_search_ledger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_search_ledger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search_ledger.FormattingEnabled = true;
            this.cb_search_ledger.Location = new System.Drawing.Point(376, 26);
            this.cb_search_ledger.Name = "cb_search_ledger";
            this.cb_search_ledger.Size = new System.Drawing.Size(155, 26);
            this.cb_search_ledger.Sorted = true;
            this.cb_search_ledger.TabIndex = 48;
            // 
            // btn_newLedger
            // 
            this.btn_newLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newLedger.ForeColor = System.Drawing.Color.Black;
            this.btn_newLedger.Location = new System.Drawing.Point(18, 21);
            this.btn_newLedger.Name = "btn_newLedger";
            this.btn_newLedger.Size = new System.Drawing.Size(147, 34);
            this.btn_newLedger.TabIndex = 47;
            this.btn_newLedger.Tag = "normal";
            this.btn_newLedger.Text = "Konto hinzufügen";
            this.btn_newLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newLedger.UseVisualStyleBackColor = true;
            this.btn_newLedger.Click += new System.EventHandler(this.btn_newLedger_Click);
            // 
            // tabPage_help
            // 
            this.tabPage_help.Location = new System.Drawing.Point(4, 27);
            this.tabPage_help.Name = "tabPage_help";
            this.tabPage_help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_help.Size = new System.Drawing.Size(907, 78);
            this.tabPage_help.TabIndex = 4;
            this.tabPage_help.Text = "Hilfe";
            this.tabPage_help.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 580);
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
            this.btn_newClient.Text = " Neuer Client";
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
            // lbl_client
            // 
            this.lbl_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(757, 32);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(57, 18);
            this.lbl_client.TabIndex = 47;
            this.lbl_client.Text = "Client:";
            // 
            // cb_clients
            // 
            this.cb_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.Location = new System.Drawing.Point(820, 33);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transaction.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_transaction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_transaction.Location = new System.Drawing.Point(5, 144);
            this.dgv_transaction.Name = "dgv_transaction";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_transaction.Size = new System.Drawing.Size(911, 373);
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
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.column_netto.DefaultCellStyle = dataGridViewCellStyle9;
            this.column_netto.HeaderText = "Nettobetrag";
            this.column_netto.Name = "column_netto";
            this.column_netto.Width = 120;
            // 
            // column_brutto
            // 
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.column_brutto.DefaultCellStyle = dataGridViewCellStyle10;
            this.column_brutto.HeaderText = "Bruttobetrag";
            this.column_brutto.Name = "column_brutto";
            this.column_brutto.Width = 120;
            // 
            // column_ust
            // 
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.column_ust.DefaultCellStyle = dataGridViewCellStyle11;
            this.column_ust.HeaderText = "Ust";
            this.column_ust.Name = "column_ust";
            this.column_ust.Width = 60;
            // 
            // column_ust_rate
            // 
            dataGridViewCellStyle12.Format = "0 \"%\"";
            dataGridViewCellStyle12.NullValue = null;
            this.column_ust_rate.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.lbl_contraLedger.Location = new System.Drawing.Point(333, 520);
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
            this.lbl_netto.Location = new System.Drawing.Point(490, 520);
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
            this.lbl_date.Location = new System.Drawing.Point(42, 520);
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
            this.lbl_referenceNumber.Location = new System.Drawing.Point(163, 520);
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
            this.lbl_ust.Location = new System.Drawing.Point(669, 520);
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
            this.cb_salesTaxRate.Location = new System.Drawing.Point(615, 541);
            this.cb_salesTaxRate.Name = "cb_salesTaxRate";
            this.cb_salesTaxRate.Size = new System.Drawing.Size(155, 26);
            this.cb_salesTaxRate.TabIndex = 5;
            this.cb_salesTaxRate.SelectedIndexChanged += new System.EventHandler(this.cb_salesTaxRate_SelectedIndexChanged);
            // 
            // tb_netto
            // 
            this.tb_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_netto.Location = new System.Drawing.Point(454, 541);
            this.tb_netto.Name = "tb_netto";
            this.tb_netto.Size = new System.Drawing.Size(155, 26);
            this.tb_netto.TabIndex = 4;
            // 
            // tb_referenceNumber
            // 
            this.tb_referenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_referenceNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_referenceNumber.Location = new System.Drawing.Point(132, 541);
            this.tb_referenceNumber.Name = "tb_referenceNumber";
            this.tb_referenceNumber.Size = new System.Drawing.Size(155, 26);
            this.tb_referenceNumber.TabIndex = 2;
            // 
            // btn_enter
            // 
            this.btn_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(820, 541);
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
            this.btn_save_main.Location = new System.Drawing.Point(922, 484);
            this.btn_save_main.Name = "btn_save_main";
            this.btn_save_main.Size = new System.Drawing.Size(109, 33);
            this.btn_save_main.TabIndex = 7;
            this.btn_save_main.Tag = "normal";
            this.btn_save_main.Text = "Speichern";
            this.btn_save_main.UseVisualStyleBackColor = true;
            this.btn_save_main.Click += new System.EventHandler(this.btn_save_main_Click);
            // 
            // date_picker
            // 
            this.date_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date_picker.CustomFormat = "dd.MM.yyyy";
            this.date_picker.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(12, 541);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(114, 26);
            this.date_picker.TabIndex = 1;
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
            this.cb_contraLedger.Location = new System.Drawing.Point(293, 541);
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
            this.rbtn_s.Location = new System.Drawing.Point(779, 532);
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
            this.rbtn_h.Location = new System.Drawing.Point(779, 551);
            this.rbtn_h.Name = "rbtn_h";
            this.rbtn_h.Size = new System.Drawing.Size(33, 20);
            this.rbtn_h.TabIndex = 56;
            this.rbtn_h.Text = "H";
            this.rbtn_h.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Summen- Saldenbilanz";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(519, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_settings
            // 
            this.pb_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_settings.BackColor = System.Drawing.Color.Transparent;
            this.pb_settings.BackgroundImage = global::AccountantAssistant.Properties.Resources.gear;
            this.pb_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_settings.Location = new System.Drawing.Point(1071, 33);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(32, 21);
            this.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_settings.TabIndex = 46;
            this.pb_settings.TabStop = false;
            this.pb_settings.Tag = "settings";
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
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
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.ControlBox = false;
            this.Controls.Add(this.rbtn_h);
            this.Controls.Add(this.rbtn_s);
            this.Controls.Add(this.cb_contraLedger);
            this.Controls.Add(this.date_picker);
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
            this.Controls.Add(this.cb_clients);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.tabCon1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1146, 633);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            this.tabCon1.ResumeLayout(false);
            this.tabPage_start.ResumeLayout(false);
            this.tabPage_start.PerformLayout();
            this.tabPage_search.ResumeLayout(false);
            this.tabPage_search.PerformLayout();
            this.tabPage_ledger.ResumeLayout(false);
            this.tabPage_ledger.PerformLayout();
            this.pnl_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCon1;
        private System.Windows.Forms.TabPage tabPage_file;
        private System.Windows.Forms.TabPage tabPage_start;
        private System.Windows.Forms.TabPage tabPage_search;
        private System.Windows.Forms.TabPage tabPage_ledger;
        private System.Windows.Forms.TabPage tabPage_help;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.ComboBox cb_clients;
        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.Button btn_newLedger;
        private System.Windows.Forms.ComboBox cb_ledger;
        private System.Windows.Forms.Label lbl_select_ledger;
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
        private System.Windows.Forms.DateTimePicker date_picker;
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
        private System.Windows.Forms.Button btn_search_ref;
        private System.Windows.Forms.TextBox tb_search_ref;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_searchDate;
        private System.Windows.Forms.TextBox tb_searchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search_ledger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_search_ledger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}