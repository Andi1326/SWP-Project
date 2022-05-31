namespace AccountantAssistant
{
    partial class ucTabControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabCon = new System.Windows.Forms.Panel();
            this.pb_line = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_ledger = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.pageLedger = new System.Windows.Forms.Panel();
            this.btn_search_ledger = new System.Windows.Forms.Button();
            this.lbl_TP_ledger = new System.Windows.Forms.Label();
            this.cb_search_ledger = new System.Windows.Forms.ComboBox();
            this.btn_newLedger = new System.Windows.Forms.Button();
            this.pageSearch = new System.Windows.Forms.Panel();
            this.btn_searchDate = new System.Windows.Forms.Button();
            this.tb_searchDate = new System.Windows.Forms.TextBox();
            this.lbl_TP_date = new System.Windows.Forms.Label();
            this.btn_search_ref = new System.Windows.Forms.Button();
            this.tb_search_ref = new System.Windows.Forms.TextBox();
            this.lbl_TP_referenceNumber = new System.Windows.Forms.Label();
            this.pageStart = new System.Windows.Forms.Panel();
            this.btn_chooseLedger = new System.Windows.Forms.Button();
            this.tb_ledger = new System.Windows.Forms.TextBox();
            this.btn_balance = new System.Windows.Forms.Button();
            this.lbl_TP_balance = new System.Windows.Forms.Label();
            this.lbl_select_ledger = new System.Windows.Forms.Label();
            this.pageHelp = new System.Windows.Forms.Panel();
            this.lbl_eMail2 = new System.Windows.Forms.Label();
            this.lbl_eMail1 = new System.Windows.Forms.Label();
            this.linklable_email = new System.Windows.Forms.LinkLabel();
            this.lbl_eMailHeading = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Button();
            this.TabCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_line)).BeginInit();
            this.pageLedger.SuspendLayout();
            this.pageSearch.SuspendLayout();
            this.pageStart.SuspendLayout();
            this.pageHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCon
            // 
            this.TabCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCon.BackColor = System.Drawing.Color.Transparent;
            this.TabCon.Controls.Add(this.pb_line);
            this.TabCon.Controls.Add(this.btn_help);
            this.TabCon.Controls.Add(this.btn_start);
            this.TabCon.Controls.Add(this.btn_search);
            this.TabCon.Controls.Add(this.btn_ledger);
            this.TabCon.Controls.Add(this.btn_file);
            this.TabCon.Controls.Add(this.pageStart);
            this.TabCon.Controls.Add(this.pageHelp);
            this.TabCon.Controls.Add(this.pageLedger);
            this.TabCon.Controls.Add(this.pageSearch);
            this.TabCon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCon.Location = new System.Drawing.Point(3, 3);
            this.TabCon.Name = "TabCon";
            this.TabCon.Size = new System.Drawing.Size(791, 107);
            this.TabCon.TabIndex = 0;
            // 
            // pb_line
            // 
            this.pb_line.BackColor = System.Drawing.Color.Black;
            this.pb_line.Location = new System.Drawing.Point(76, 25);
            this.pb_line.Name = "pb_line";
            this.pb_line.Size = new System.Drawing.Size(50, 2);
            this.pb_line.TabIndex = 1;
            this.pb_line.TabStop = false;
            // 
            // btn_help
            // 
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(279, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(56, 24);
            this.btn_help.TabIndex = 4;
            this.btn_help.Text = "Hilfe";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_start
            // 
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(70, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(64, 24);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(140, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(66, 24);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Suche";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_ledger
            // 
            this.btn_ledger.FlatAppearance.BorderSize = 0;
            this.btn_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ledger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ledger.Location = new System.Drawing.Point(212, 3);
            this.btn_ledger.Name = "btn_ledger";
            this.btn_ledger.Size = new System.Drawing.Size(61, 24);
            this.btn_ledger.TabIndex = 1;
            this.btn_ledger.Text = "Konto";
            this.btn_ledger.UseVisualStyleBackColor = true;
            this.btn_ledger.Click += new System.EventHandler(this.btn_ledger_Click);
            // 
            // btn_file
            // 
            this.btn_file.FlatAppearance.BorderSize = 0;
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(3, 3);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(61, 24);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "Datei";
            this.btn_file.UseVisualStyleBackColor = true;
            // 
            // pageLedger
            // 
            this.pageLedger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageLedger.BackColor = System.Drawing.Color.Transparent;
            this.pageLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageLedger.Controls.Add(this.btn_search_ledger);
            this.pageLedger.Controls.Add(this.lbl_TP_ledger);
            this.pageLedger.Controls.Add(this.cb_search_ledger);
            this.pageLedger.Controls.Add(this.btn_newLedger);
            this.pageLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLedger.Location = new System.Drawing.Point(3, 31);
            this.pageLedger.Name = "pageLedger";
            this.pageLedger.Size = new System.Drawing.Size(785, 75);
            this.pageLedger.TabIndex = 7;
            // 
            // btn_search_ledger
            // 
            this.btn_search_ledger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ledger.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ledger.ForeColor = System.Drawing.Color.Black;
            this.btn_search_ledger.Location = new System.Drawing.Point(535, 21);
            this.btn_search_ledger.Name = "btn_search_ledger";
            this.btn_search_ledger.Size = new System.Drawing.Size(83, 26);
            this.btn_search_ledger.TabIndex = 65;
            this.btn_search_ledger.Tag = "normal";
            this.btn_search_ledger.Text = "Suchen";
            this.btn_search_ledger.UseVisualStyleBackColor = true;
            this.btn_search_ledger.Click += new System.EventHandler(this.btn_search_ledger_Click);
            // 
            // lbl_TP_ledger
            // 
            this.lbl_TP_ledger.AutoSize = true;
            this.lbl_TP_ledger.Location = new System.Drawing.Point(317, 25);
            this.lbl_TP_ledger.Name = "lbl_TP_ledger";
            this.lbl_TP_ledger.Size = new System.Drawing.Size(51, 18);
            this.lbl_TP_ledger.TabIndex = 64;
            this.lbl_TP_ledger.Text = "Konto:";
            // 
            // cb_search_ledger
            // 
            this.cb_search_ledger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_search_ledger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search_ledger.FormattingEnabled = true;
            this.cb_search_ledger.Location = new System.Drawing.Point(374, 21);
            this.cb_search_ledger.Name = "cb_search_ledger";
            this.cb_search_ledger.Size = new System.Drawing.Size(155, 26);
            this.cb_search_ledger.Sorted = true;
            this.cb_search_ledger.TabIndex = 63;
            // 
            // btn_newLedger
            // 
            this.btn_newLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newLedger.ForeColor = System.Drawing.Color.Black;
            this.btn_newLedger.Location = new System.Drawing.Point(16, 16);
            this.btn_newLedger.Name = "btn_newLedger";
            this.btn_newLedger.Size = new System.Drawing.Size(147, 34);
            this.btn_newLedger.TabIndex = 62;
            this.btn_newLedger.Tag = "normal";
            this.btn_newLedger.Text = "Konto hinzufügen";
            this.btn_newLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newLedger.UseVisualStyleBackColor = true;
            this.btn_newLedger.Click += new System.EventHandler(this.btn_newLedger_Click);
            // 
            // pageSearch
            // 
            this.pageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageSearch.BackColor = System.Drawing.Color.Transparent;
            this.pageSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSearch.Controls.Add(this.btn_searchDate);
            this.pageSearch.Controls.Add(this.tb_searchDate);
            this.pageSearch.Controls.Add(this.lbl_TP_date);
            this.pageSearch.Controls.Add(this.btn_search_ref);
            this.pageSearch.Controls.Add(this.tb_search_ref);
            this.pageSearch.Controls.Add(this.lbl_TP_referenceNumber);
            this.pageSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSearch.Location = new System.Drawing.Point(3, 31);
            this.pageSearch.Name = "pageSearch";
            this.pageSearch.Size = new System.Drawing.Size(785, 75);
            this.pageSearch.TabIndex = 6;
            // 
            // btn_searchDate
            // 
            this.btn_searchDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_searchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDate.ForeColor = System.Drawing.Color.Black;
            this.btn_searchDate.Location = new System.Drawing.Point(712, 18);
            this.btn_searchDate.Name = "btn_searchDate";
            this.btn_searchDate.Size = new System.Drawing.Size(83, 26);
            this.btn_searchDate.TabIndex = 66;
            this.btn_searchDate.Tag = "normal";
            this.btn_searchDate.Text = "Suchen";
            this.btn_searchDate.UseVisualStyleBackColor = true;
            this.btn_searchDate.Click += new System.EventHandler(this.btn_searchDate_Click);
            // 
            // tb_searchDate
            // 
            this.tb_searchDate.Location = new System.Drawing.Point(508, 18);
            this.tb_searchDate.Multiline = true;
            this.tb_searchDate.Name = "tb_searchDate";
            this.tb_searchDate.Size = new System.Drawing.Size(198, 26);
            this.tb_searchDate.TabIndex = 65;
            // 
            // lbl_TP_date
            // 
            this.lbl_TP_date.AutoSize = true;
            this.lbl_TP_date.Location = new System.Drawing.Point(445, 25);
            this.lbl_TP_date.Name = "lbl_TP_date";
            this.lbl_TP_date.Size = new System.Drawing.Size(57, 18);
            this.lbl_TP_date.TabIndex = 64;
            this.lbl_TP_date.Text = "Datum:";
            // 
            // btn_search_ref
            // 
            this.btn_search_ref.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ref.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ref.ForeColor = System.Drawing.Color.Black;
            this.btn_search_ref.Location = new System.Drawing.Point(326, 20);
            this.btn_search_ref.Name = "btn_search_ref";
            this.btn_search_ref.Size = new System.Drawing.Size(83, 26);
            this.btn_search_ref.TabIndex = 63;
            this.btn_search_ref.Tag = "normal";
            this.btn_search_ref.Text = "Suchen";
            this.btn_search_ref.UseVisualStyleBackColor = true;
            this.btn_search_ref.Click += new System.EventHandler(this.btn_search_ref_Click);
            // 
            // tb_search_ref
            // 
            this.tb_search_ref.Location = new System.Drawing.Point(122, 20);
            this.tb_search_ref.Multiline = true;
            this.tb_search_ref.Name = "tb_search_ref";
            this.tb_search_ref.Size = new System.Drawing.Size(198, 26);
            this.tb_search_ref.TabIndex = 62;
            // 
            // lbl_TP_referenceNumber
            // 
            this.lbl_TP_referenceNumber.AutoSize = true;
            this.lbl_TP_referenceNumber.Location = new System.Drawing.Point(13, 23);
            this.lbl_TP_referenceNumber.Name = "lbl_TP_referenceNumber";
            this.lbl_TP_referenceNumber.Size = new System.Drawing.Size(103, 18);
            this.lbl_TP_referenceNumber.TabIndex = 61;
            this.lbl_TP_referenceNumber.Text = "Belegnummer:";
            // 
            // pageStart
            // 
            this.pageStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageStart.Controls.Add(this.btn_chooseLedger);
            this.pageStart.Controls.Add(this.tb_ledger);
            this.pageStart.Controls.Add(this.btn_balance);
            this.pageStart.Controls.Add(this.lbl_TP_balance);
            this.pageStart.Controls.Add(this.lbl_select_ledger);
            this.pageStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageStart.Location = new System.Drawing.Point(3, 31);
            this.pageStart.Name = "pageStart";
            this.pageStart.Size = new System.Drawing.Size(785, 75);
            this.pageStart.TabIndex = 5;
            // 
            // btn_chooseLedger
            // 
            this.btn_chooseLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chooseLedger.BackColor = System.Drawing.Color.Transparent;
            this.btn_chooseLedger.BackgroundImage = global::AccountantAssistant.Properties.Resources.magnifyingGlass;
            this.btn_chooseLedger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_chooseLedger.FlatAppearance.BorderSize = 0;
            this.btn_chooseLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chooseLedger.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chooseLedger.ForeColor = System.Drawing.Color.Black;
            this.btn_chooseLedger.Location = new System.Drawing.Point(300, 32);
            this.btn_chooseLedger.Name = "btn_chooseLedger";
            this.btn_chooseLedger.Size = new System.Drawing.Size(33, 21);
            this.btn_chooseLedger.TabIndex = 64;
            this.btn_chooseLedger.UseVisualStyleBackColor = false;
            this.btn_chooseLedger.Click += new System.EventHandler(this.btn_chooseLedger_Click);
            // 
            // tb_ledger
            // 
            this.tb_ledger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_ledger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ledger.Location = new System.Drawing.Point(147, 29);
            this.tb_ledger.Name = "tb_ledger";
            this.tb_ledger.Size = new System.Drawing.Size(188, 26);
            this.tb_ledger.TabIndex = 62;
            // 
            // btn_balance
            // 
            this.btn_balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_balance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_balance.ForeColor = System.Drawing.Color.Black;
            this.btn_balance.Location = new System.Drawing.Point(539, 31);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(117, 23);
            this.btn_balance.TabIndex = 63;
            this.btn_balance.Text = "Berechnen";
            this.btn_balance.UseVisualStyleBackColor = true;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // lbl_TP_balance
            // 
            this.lbl_TP_balance.AutoSize = true;
            this.lbl_TP_balance.Location = new System.Drawing.Point(377, 32);
            this.lbl_TP_balance.Name = "lbl_TP_balance";
            this.lbl_TP_balance.Size = new System.Drawing.Size(153, 18);
            this.lbl_TP_balance.TabIndex = 61;
            this.lbl_TP_balance.Text = "Summen- Saldenbilanz";
            // 
            // lbl_select_ledger
            // 
            this.lbl_select_ledger.AutoSize = true;
            this.lbl_select_ledger.Location = new System.Drawing.Point(26, 32);
            this.lbl_select_ledger.Name = "lbl_select_ledger";
            this.lbl_select_ledger.Size = new System.Drawing.Size(118, 18);
            this.lbl_select_ledger.TabIndex = 60;
            this.lbl_select_ledger.Text = "Konto auswählen";
            // 
            // pageHelp
            // 
            this.pageHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageHelp.BackColor = System.Drawing.Color.Transparent;
            this.pageHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageHelp.Controls.Add(this.lbl_eMail2);
            this.pageHelp.Controls.Add(this.lbl_eMail1);
            this.pageHelp.Controls.Add(this.linklable_email);
            this.pageHelp.Controls.Add(this.lbl_eMailHeading);
            this.pageHelp.Controls.Add(this.btn_email);
            this.pageHelp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHelp.Location = new System.Drawing.Point(3, 31);
            this.pageHelp.Name = "pageHelp";
            this.pageHelp.Size = new System.Drawing.Size(785, 75);
            this.pageHelp.TabIndex = 8;
            // 
            // lbl_eMail2
            // 
            this.lbl_eMail2.AutoSize = true;
            this.lbl_eMail2.Location = new System.Drawing.Point(122, 45);
            this.lbl_eMail2.Name = "lbl_eMail2";
            this.lbl_eMail2.Size = new System.Drawing.Size(246, 18);
            this.lbl_eMail2.TabIndex = 12;
            this.lbl_eMail2.Text = "Täglich von 8:00 bis 15:00 für sie da";
            // 
            // lbl_eMail1
            // 
            this.lbl_eMail1.AutoSize = true;
            this.lbl_eMail1.Location = new System.Drawing.Point(6, 45);
            this.lbl_eMail1.Name = "lbl_eMail1";
            this.lbl_eMail1.Size = new System.Drawing.Size(106, 18);
            this.lbl_eMail1.TabIndex = 11;
            this.lbl_eMail1.Text = "0664 345 8254";
            // 
            // linklable_email
            // 
            this.linklable_email.AutoSize = true;
            this.linklable_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklable_email.LinkColor = System.Drawing.Color.Black;
            this.linklable_email.Location = new System.Drawing.Point(147, 19);
            this.linklable_email.Name = "linklable_email";
            this.linklable_email.Size = new System.Drawing.Size(111, 13);
            this.linklable_email.TabIndex = 10;
            this.linklable_email.TabStop = true;
            this.linklable_email.Text = "acas.help@gmail.com";
            this.linklable_email.VisitedLinkColor = System.Drawing.Color.Gray;
            // 
            // lbl_eMailHeading
            // 
            this.lbl_eMailHeading.AutoSize = true;
            this.lbl_eMailHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eMailHeading.Location = new System.Drawing.Point(5, 11);
            this.lbl_eMailHeading.Name = "lbl_eMailHeading";
            this.lbl_eMailHeading.Size = new System.Drawing.Size(136, 24);
            this.lbl_eMailHeading.TabIndex = 9;
            this.lbl_eMailHeading.Text = "Kontaktdaten:";
            // 
            // btn_email
            // 
            this.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_email.Location = new System.Drawing.Point(720, 21);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(123, 29);
            this.btn_email.TabIndex = 8;
            this.btn_email.Text = "E-MAIL";
            this.btn_email.UseVisualStyleBackColor = true;
            // 
            // ucTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabCon);
            this.Name = "ucTabControl";
            this.Size = new System.Drawing.Size(1002, 112);
            this.TabCon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_line)).EndInit();
            this.pageLedger.ResumeLayout(false);
            this.pageLedger.PerformLayout();
            this.pageSearch.ResumeLayout(false);
            this.pageSearch.PerformLayout();
            this.pageStart.ResumeLayout(false);
            this.pageStart.PerformLayout();
            this.pageHelp.ResumeLayout(false);
            this.pageHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TabCon;
        public System.Windows.Forms.TextBox tb_ledger;
        public System.Windows.Forms.Button btn_chooseLedger;
        public System.Windows.Forms.Button btn_balance;
        public System.Windows.Forms.Label lbl_TP_balance;
        public System.Windows.Forms.Label lbl_select_ledger;
        public System.Windows.Forms.Button btn_searchDate;
        public System.Windows.Forms.TextBox tb_searchDate;
        public System.Windows.Forms.Label lbl_TP_date;
        public System.Windows.Forms.Button btn_search_ref;
        public System.Windows.Forms.TextBox tb_search_ref;
        public System.Windows.Forms.Label lbl_TP_referenceNumber;
        public System.Windows.Forms.Button btn_search_ledger;
        public System.Windows.Forms.Label lbl_TP_ledger;
        public System.Windows.Forms.ComboBox cb_search_ledger;
        public System.Windows.Forms.Button btn_newLedger;
        public System.Windows.Forms.Label lbl_eMail2;
        public System.Windows.Forms.Label lbl_eMail1;
        public System.Windows.Forms.LinkLabel linklable_email;
        public System.Windows.Forms.Label lbl_eMailHeading;
        public System.Windows.Forms.Button btn_email;
        public System.Windows.Forms.Button btn_file;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.Button btn_ledger;
        public System.Windows.Forms.Panel pageStart;
        public System.Windows.Forms.Button btn_help;
        public System.Windows.Forms.Panel pageSearch;
        public System.Windows.Forms.Panel pageLedger;
        public System.Windows.Forms.Panel pageHelp;
        public System.Windows.Forms.PictureBox pb_line;
    }
}
