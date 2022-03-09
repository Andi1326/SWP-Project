
namespace AccountantAssistant
{
    partial class frm_search_ledger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_search_ledger));
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_search_ledger = new System.Windows.Forms.DataGridView();
            this.btn_save_ledger = new System.Windows.Forms.Button();
            this.btn_delete_ledger = new System.Windows.Forms.Button();
            this.column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_contraLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_ledger)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 505);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 59;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_search_ledger
            // 
            this.dgv_search_ledger.AllowUserToAddRows = false;
            this.dgv_search_ledger.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_search_ledger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_search_ledger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_ledger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_date,
            this.referenceNumber,
            this.column_contraLedger,
            this.column_debit,
            this.column_credit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_search_ledger.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_search_ledger.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_search_ledger.Location = new System.Drawing.Point(12, 105);
            this.dgv_search_ledger.Name = "dgv_search_ledger";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_search_ledger.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_search_ledger.Size = new System.Drawing.Size(504, 391);
            this.dgv_search_ledger.TabIndex = 58;
            // 
            // btn_save_ledger
            // 
            this.btn_save_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_ledger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_ledger.ForeColor = System.Drawing.Color.Black;
            this.btn_save_ledger.Location = new System.Drawing.Point(127, 66);
            this.btn_save_ledger.Name = "btn_save_ledger";
            this.btn_save_ledger.Size = new System.Drawing.Size(109, 33);
            this.btn_save_ledger.TabIndex = 57;
            this.btn_save_ledger.Text = "Speichern";
            this.btn_save_ledger.UseVisualStyleBackColor = true;
            this.btn_save_ledger.Click += new System.EventHandler(this.btn_save_ledger_Click);
            // 
            // btn_delete_ledger
            // 
            this.btn_delete_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_ledger.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_ledger.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_ledger.Location = new System.Drawing.Point(12, 66);
            this.btn_delete_ledger.Name = "btn_delete_ledger";
            this.btn_delete_ledger.Size = new System.Drawing.Size(109, 33);
            this.btn_delete_ledger.TabIndex = 56;
            this.btn_delete_ledger.Text = "stornieren ";
            this.btn_delete_ledger.UseVisualStyleBackColor = true;
            this.btn_delete_ledger.Click += new System.EventHandler(this.btn_delete_ledger_Click);
            // 
            // column_date
            // 
            this.column_date.HeaderText = "Datum";
            this.column_date.Name = "column_date";
            this.column_date.Width = 80;
            // 
            // referenceNumber
            // 
            this.referenceNumber.FillWeight = 120F;
            this.referenceNumber.HeaderText = "Belegnummer";
            this.referenceNumber.Name = "referenceNumber";
            this.referenceNumber.Width = 120;
            // 
            // column_contraLedger
            // 
            dataGridViewCellStyle2.Format = "##";
            dataGridViewCellStyle2.NullValue = null;
            this.column_contraLedger.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_contraLedger.HeaderText = "Gegenkonto";
            this.column_contraLedger.Name = "column_contraLedger";
            // 
            // column_debit
            // 
            this.column_debit.FillWeight = 60F;
            this.column_debit.HeaderText = "Soll";
            this.column_debit.Name = "column_debit";
            this.column_debit.Width = 80;
            // 
            // column_credit
            // 
            this.column_credit.FillWeight = 80F;
            this.column_credit.HeaderText = "Haben";
            this.column_credit.Name = "column_credit";
            this.column_credit.Width = 80;
            // 
            // frm_search_ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_search_ledger);
            this.Controls.Add(this.btn_save_ledger);
            this.Controls.Add(this.btn_delete_ledger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_search_ledger";
            this.Load += new System.EventHandler(this.frm_search_ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_ledger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_search_ledger;
        private System.Windows.Forms.Button btn_save_ledger;
        private System.Windows.Forms.Button btn_delete_ledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_contraLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_credit;
    }
}