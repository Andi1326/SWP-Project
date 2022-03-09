
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
            this.rbtn_h = new System.Windows.Forms.RadioButton();
            this.rbtn_s = new System.Windows.Forms.RadioButton();
            this.cb_contraLedger = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_referenceNumber = new System.Windows.Forms.TextBox();
            this.tb_netto = new System.Windows.Forms.TextBox();
            this.cb_salesTaxRate = new System.Windows.Forms.ComboBox();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.lbl_referenceNumber = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_netto = new System.Windows.Forms.Label();
            this.lbl_contraLedger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_h
            // 
            this.rbtn_h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_h.AutoSize = true;
            this.rbtn_h.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_h.Location = new System.Drawing.Point(808, 113);
            this.rbtn_h.Name = "rbtn_h";
            this.rbtn_h.Size = new System.Drawing.Size(34, 20);
            this.rbtn_h.TabIndex = 69;
            this.rbtn_h.Text = "H";
            this.rbtn_h.UseVisualStyleBackColor = true;
            // 
            // rbtn_s
            // 
            this.rbtn_s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_s.AutoSize = true;
            this.rbtn_s.Checked = true;
            this.rbtn_s.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_s.Location = new System.Drawing.Point(808, 94);
            this.rbtn_s.Name = "rbtn_s";
            this.rbtn_s.Size = new System.Drawing.Size(34, 20);
            this.rbtn_s.TabIndex = 68;
            this.rbtn_s.TabStop = true;
            this.rbtn_s.Text = "S";
            this.rbtn_s.UseVisualStyleBackColor = true;
            // 
            // cb_contraLedger
            // 
            this.cb_contraLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_contraLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_contraLedger.FormattingEnabled = true;
            this.cb_contraLedger.Location = new System.Drawing.Point(322, 103);
            this.cb_contraLedger.Name = "cb_contraLedger";
            this.cb_contraLedger.Size = new System.Drawing.Size(155, 26);
            this.cb_contraLedger.Sorted = true;
            this.cb_contraLedger.TabIndex = 59;
            // 
            // date_picker
            // 
            this.date_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date_picker.CustomFormat = "dd.MM.yyyy";
            this.date_picker.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(41, 103);
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
            this.btn_enter.Location = new System.Drawing.Point(849, 103);
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
            this.tb_referenceNumber.Location = new System.Drawing.Point(161, 103);
            this.tb_referenceNumber.Name = "tb_referenceNumber";
            this.tb_referenceNumber.Size = new System.Drawing.Size(155, 26);
            this.tb_referenceNumber.TabIndex = 58;
            // 
            // tb_netto
            // 
            this.tb_netto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_netto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_netto.Location = new System.Drawing.Point(483, 103);
            this.tb_netto.Name = "tb_netto";
            this.tb_netto.Size = new System.Drawing.Size(155, 26);
            this.tb_netto.TabIndex = 60;
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
            this.cb_salesTaxRate.Location = new System.Drawing.Point(644, 103);
            this.cb_salesTaxRate.Name = "cb_salesTaxRate";
            this.cb_salesTaxRate.Size = new System.Drawing.Size(155, 26);
            this.cb_salesTaxRate.TabIndex = 61;
            // 
            // lbl_ust
            // 
            this.lbl_ust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ust.Location = new System.Drawing.Point(698, 82);
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
            this.lbl_referenceNumber.Location = new System.Drawing.Point(192, 82);
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
            this.lbl_date.Location = new System.Drawing.Point(71, 82);
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
            this.lbl_netto.Location = new System.Drawing.Point(519, 82);
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
            this.lbl_contraLedger.Location = new System.Drawing.Point(362, 82);
            this.lbl_contraLedger.Name = "lbl_contraLedger";
            this.lbl_contraLedger.Size = new System.Drawing.Size(86, 18);
            this.lbl_contraLedger.TabIndex = 63;
            this.lbl_contraLedger.Text = "Gegenkonto";
            // 
            // frm_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 179);
            this.ControlBox = false;
            this.Controls.Add(this.rbtn_h);
            this.Controls.Add(this.rbtn_s);
            this.Controls.Add(this.cb_contraLedger);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_referenceNumber);
            this.Controls.Add(this.tb_netto);
            this.Controls.Add(this.cb_salesTaxRate);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_h;
        private System.Windows.Forms.RadioButton rbtn_s;
        private System.Windows.Forms.ComboBox cb_contraLedger;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox tb_referenceNumber;
        private System.Windows.Forms.TextBox tb_netto;
        private System.Windows.Forms.ComboBox cb_salesTaxRate;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.Label lbl_referenceNumber;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_netto;
        private System.Windows.Forms.Label lbl_contraLedger;
    }
}