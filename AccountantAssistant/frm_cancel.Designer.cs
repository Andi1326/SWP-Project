
namespace AccountantAssistant
{
    partial class frm_cancel
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
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_referenceNumber = new System.Windows.Forms.TextBox();
            this.tb_netto = new System.Windows.Forms.TextBox();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.lbl_referenceNumber = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_netto = new System.Windows.Forms.Label();
            this.lbl_contraLedger = new System.Windows.Forms.Label();
            this.tb_contraledger = new System.Windows.Forms.TextBox();
            this.tb_ledger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_salestaxrate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date_picker
            // 
            this.date_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date_picker.CustomFormat = "dd.MM.yyyy";
            this.date_picker.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(7, 68);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(114, 26);
            this.date_picker.TabIndex = 57;
            // 
            // btn_enter
            // 
            this.btn_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(932, 68);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(96, 26);
            this.btn_enter.TabIndex = 62;
            this.btn_enter.Tag = "normal";
            this.btn_enter.Text = "Stonieren";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // tb_referenceNumber
            // 
            this.tb_referenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_referenceNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_referenceNumber.Location = new System.Drawing.Point(127, 68);
            this.tb_referenceNumber.Name = "tb_referenceNumber";
            this.tb_referenceNumber.Size = new System.Drawing.Size(155, 26);
            this.tb_referenceNumber.TabIndex = 58;
            // 
            // tb_netto
            // 
            this.tb_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_netto.Location = new System.Drawing.Point(607, 68);
            this.tb_netto.Name = "tb_netto";
            this.tb_netto.Size = new System.Drawing.Size(155, 26);
            this.tb_netto.TabIndex = 60;
            // 
            // lbl_ust
            // 
            this.lbl_ust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ust.Location = new System.Drawing.Point(822, 47);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(63, 18);
            this.lbl_ust.TabIndex = 67;
            this.lbl_ust.Text = "Ust-Satz";
            // 
            // lbl_referenceNumber
            // 
            this.lbl_referenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_referenceNumber.AutoSize = true;
            this.lbl_referenceNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referenceNumber.Location = new System.Drawing.Point(158, 47);
            this.lbl_referenceNumber.Name = "lbl_referenceNumber";
            this.lbl_referenceNumber.Size = new System.Drawing.Size(98, 18);
            this.lbl_referenceNumber.TabIndex = 66;
            this.lbl_referenceNumber.Text = "Belegnummer";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(37, 47);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 18);
            this.lbl_date.TabIndex = 65;
            this.lbl_date.Text = "Datum";
            // 
            // lbl_netto
            // 
            this.lbl_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_netto.AutoSize = true;
            this.lbl_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netto.Location = new System.Drawing.Point(643, 47);
            this.lbl_netto.Name = "lbl_netto";
            this.lbl_netto.Size = new System.Drawing.Size(86, 18);
            this.lbl_netto.TabIndex = 64;
            this.lbl_netto.Text = "Nettobetrag";
            // 
            // lbl_contraLedger
            // 
            this.lbl_contraLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_contraLedger.AutoSize = true;
            this.lbl_contraLedger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraLedger.Location = new System.Drawing.Point(486, 47);
            this.lbl_contraLedger.Name = "lbl_contraLedger";
            this.lbl_contraLedger.Size = new System.Drawing.Size(86, 18);
            this.lbl_contraLedger.TabIndex = 63;
            this.lbl_contraLedger.Text = "Gegenkonto";
            // 
            // tb_contraledger
            // 
            this.tb_contraledger.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.tb_contraledger.Location = new System.Drawing.Point(447, 68);
            this.tb_contraledger.Multiline = true;
            this.tb_contraledger.Name = "tb_contraledger";
            this.tb_contraledger.Size = new System.Drawing.Size(154, 26);
            this.tb_contraledger.TabIndex = 70;
            // 
            // tb_ledger
            // 
            this.tb_ledger.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.tb_ledger.Location = new System.Drawing.Point(287, 68);
            this.tb_ledger.Multiline = true;
            this.tb_ledger.Name = "tb_ledger";
            this.tb_ledger.Size = new System.Drawing.Size(154, 26);
            this.tb_ledger.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Konto";
            // 
            // tb_salestaxrate
            // 
            this.tb_salestaxrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_salestaxrate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salestaxrate.Location = new System.Drawing.Point(768, 68);
            this.tb_salestaxrate.Multiline = true;
            this.tb_salestaxrate.Name = "tb_salestaxrate";
            this.tb_salestaxrate.Size = new System.Drawing.Size(158, 26);
            this.tb_salestaxrate.TabIndex = 73;
            // 
            // frm_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 179);
            this.ControlBox = false;
            this.Controls.Add(this.tb_salestaxrate);
            this.Controls.Add(this.tb_ledger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_contraledger);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_referenceNumber);
            this.Controls.Add(this.tb_netto);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.lbl_referenceNumber);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_netto);
            this.Controls.Add(this.lbl_contraLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_cancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox tb_referenceNumber;
        private System.Windows.Forms.TextBox tb_netto;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.Label lbl_referenceNumber;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_netto;
        private System.Windows.Forms.Label lbl_contraLedger;
        private System.Windows.Forms.TextBox tb_contraledger;
        private System.Windows.Forms.TextBox tb_ledger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_salestaxrate;
    }
}