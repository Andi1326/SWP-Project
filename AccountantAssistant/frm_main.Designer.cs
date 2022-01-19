
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tabCon1 = new System.Windows.Forms.TabControl();
            this.tabPage_file = new System.Windows.Forms.TabPage();
            this.lbl_select_ledger = new System.Windows.Forms.Label();
            this.tabPage_start = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_search = new System.Windows.Forms.TabPage();
            this.tabPage_ledger = new System.Windows.Forms.TabPage();
            this.btn_newLedger = new System.Windows.Forms.Button();
            this.tabPage_help = new System.Windows.Forms.TabPage();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.lbl_client = new System.Windows.Forms.Label();
            this.cb_clients = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabCon1.SuspendLayout();
            this.tabPage_file.SuspendLayout();
            this.tabPage_start.SuspendLayout();
            this.tabPage_ledger.SuspendLayout();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabCon1.Size = new System.Drawing.Size(907, 109);
            this.tabCon1.TabIndex = 0;
            this.tabCon1.SelectedIndexChanged += new System.EventHandler(this.tabCon1_SelectedIndexChanged);
            // 
            // tabPage_file
            // 
            this.tabPage_file.BackColor = System.Drawing.Color.White;
            this.tabPage_file.Controls.Add(this.comboBox1);
            this.tabPage_file.Controls.Add(this.lbl_select_ledger);
            this.tabPage_file.Location = new System.Drawing.Point(4, 27);
            this.tabPage_file.Name = "tabPage_file";
            this.tabPage_file.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_file.Size = new System.Drawing.Size(899, 78);
            this.tabPage_file.TabIndex = 0;
            this.tabPage_file.Text = "Datei";
            this.tabPage_file.Click += new System.EventHandler(this.tabPage_file_Click);
            // 
            // lbl_select_ledger
            // 
            this.lbl_select_ledger.AutoSize = true;
            this.lbl_select_ledger.Location = new System.Drawing.Point(7, 24);
            this.lbl_select_ledger.Name = "lbl_select_ledger";
            this.lbl_select_ledger.Size = new System.Drawing.Size(118, 18);
            this.lbl_select_ledger.TabIndex = 0;
            this.lbl_select_ledger.Text = "Konto auswählen";
            // 
            // tabPage_start
            // 
            this.tabPage_start.Controls.Add(this.label2);
            this.tabPage_start.Location = new System.Drawing.Point(4, 27);
            this.tabPage_start.Name = "tabPage_start";
            this.tabPage_start.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_start.Size = new System.Drawing.Size(899, 78);
            this.tabPage_start.TabIndex = 1;
            this.tabPage_start.Text = "Start";
            this.tabPage_start.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "start";
            // 
            // tabPage_search
            // 
            this.tabPage_search.Location = new System.Drawing.Point(4, 27);
            this.tabPage_search.Name = "tabPage_search";
            this.tabPage_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_search.Size = new System.Drawing.Size(899, 78);
            this.tabPage_search.TabIndex = 2;
            this.tabPage_search.Text = "Suche";
            this.tabPage_search.UseVisualStyleBackColor = true;
            // 
            // tabPage_ledger
            // 
            this.tabPage_ledger.Controls.Add(this.btn_newLedger);
            this.tabPage_ledger.Location = new System.Drawing.Point(4, 27);
            this.tabPage_ledger.Name = "tabPage_ledger";
            this.tabPage_ledger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ledger.Size = new System.Drawing.Size(899, 78);
            this.tabPage_ledger.TabIndex = 3;
            this.tabPage_ledger.Text = "Konto";
            this.tabPage_ledger.UseVisualStyleBackColor = true;
            // 
            // btn_newLedger
            // 
            this.btn_newLedger.FlatAppearance.BorderSize = 0;
            this.btn_newLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newLedger.ForeColor = System.Drawing.Color.Black;
            this.btn_newLedger.Location = new System.Drawing.Point(18, 21);
            this.btn_newLedger.Name = "btn_newLedger";
            this.btn_newLedger.Size = new System.Drawing.Size(147, 34);
            this.btn_newLedger.TabIndex = 47;
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
            this.tabPage_help.Size = new System.Drawing.Size(899, 78);
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
            this.pnl_1.Location = new System.Drawing.Point(10, 112);
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
            this.btn_print.Text = "Drucken";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseVisualStyleBackColor = true;
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
            this.btn_new.Text = "Neu";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = true;
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
            this.btn_save.Text = "Speichern";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
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
            this.lbl_client.Location = new System.Drawing.Point(757, 32);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(57, 18);
            this.lbl_client.TabIndex = 47;
            this.lbl_client.Text = "Client:";
            this.lbl_client.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // cb_clients
            // 
            this.cb_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.Location = new System.Drawing.Point(820, 33);
            this.cb_clients.Name = "cb_clients";
            this.cb_clients.Size = new System.Drawing.Size(232, 21);
            this.cb_clients.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AccountantAssistant.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(1071, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.ControlBox = false;
            this.Controls.Add(this.cb_clients);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.pictureBox1);
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
            this.tabPage_file.ResumeLayout(false);
            this.tabPage_file.PerformLayout();
            this.tabPage_start.ResumeLayout(false);
            this.tabPage_start.PerformLayout();
            this.tabPage_ledger.ResumeLayout(false);
            this.pnl_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lbl_select_ledger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.ComboBox cb_clients;
        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.Button btn_newLedger;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}