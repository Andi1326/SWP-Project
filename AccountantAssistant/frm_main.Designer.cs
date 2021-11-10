
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
            this.tabPage_start = new System.Windows.Forms.TabPage();
            this.tabPage_search = new System.Windows.Forms.TabPage();
            this.tabPage_ledger = new System.Windows.Forms.TabPage();
            this.tabPage_help = new System.Windows.Forms.TabPage();
            this.btn_back = new System.Windows.Forms.Button();
            this.tabCon1.SuspendLayout();
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
            this.tabCon1.Location = new System.Drawing.Point(1, 1);
            this.tabCon1.Name = "tabCon1";
            this.tabCon1.SelectedIndex = 0;
            this.tabCon1.Size = new System.Drawing.Size(1131, 151);
            this.tabCon1.TabIndex = 0;
            // 
            // tabPage_file
            // 
            this.tabPage_file.BackColor = System.Drawing.Color.White;
            this.tabPage_file.Location = new System.Drawing.Point(4, 27);
            this.tabPage_file.Name = "tabPage_file";
            this.tabPage_file.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_file.Size = new System.Drawing.Size(1123, 120);
            this.tabPage_file.TabIndex = 0;
            this.tabPage_file.Text = "Datei";
            // 
            // tabPage_start
            // 
            this.tabPage_start.Location = new System.Drawing.Point(4, 27);
            this.tabPage_start.Name = "tabPage_start";
            this.tabPage_start.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_start.Size = new System.Drawing.Size(1123, 120);
            this.tabPage_start.TabIndex = 1;
            this.tabPage_start.Text = "Start";
            this.tabPage_start.UseVisualStyleBackColor = true;
            // 
            // tabPage_search
            // 
            this.tabPage_search.Location = new System.Drawing.Point(4, 27);
            this.tabPage_search.Name = "tabPage_search";
            this.tabPage_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_search.Size = new System.Drawing.Size(1123, 120);
            this.tabPage_search.TabIndex = 2;
            this.tabPage_search.Text = "Suche";
            this.tabPage_search.UseVisualStyleBackColor = true;
            // 
            // tabPage_ledger
            // 
            this.tabPage_ledger.Location = new System.Drawing.Point(4, 27);
            this.tabPage_ledger.Name = "tabPage_ledger";
            this.tabPage_ledger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ledger.Size = new System.Drawing.Size(1123, 120);
            this.tabPage_ledger.TabIndex = 3;
            this.tabPage_ledger.Text = "Konto";
            this.tabPage_ledger.UseVisualStyleBackColor = true;
            // 
            // tabPage_help
            // 
            this.tabPage_help.Location = new System.Drawing.Point(4, 27);
            this.tabPage_help.Name = "tabPage_help";
            this.tabPage_help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_help.Size = new System.Drawing.Size(1123, 120);
            this.tabPage_help.TabIndex = 4;
            this.tabPage_help.Text = "Hilfe";
            this.tabPage_help.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(12, 580);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 43;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.Controls.Add(this.tabCon1);
            this.Controls.Add(this.btn_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tabCon1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCon1;
        private System.Windows.Forms.TabPage tabPage_file;
        private System.Windows.Forms.TabPage tabPage_start;
        private System.Windows.Forms.TabPage tabPage_search;
        private System.Windows.Forms.TabPage tabPage_ledger;
        private System.Windows.Forms.TabPage tabPage_help;
        private System.Windows.Forms.Button btn_back;
    }
}