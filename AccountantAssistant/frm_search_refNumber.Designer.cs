
namespace AccountantAssistant
{
    partial class frm_search_refNumber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_search_refNumber));
            this.btn_delete_ref = new System.Windows.Forms.Button();
            this.dgv_search_refNumber = new System.Windows.Forms.DataGridView();
            this.column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ledger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_contraLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_refNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_ref
            // 
            this.btn_delete_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_ref.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_ref.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_ref.Location = new System.Drawing.Point(12, 55);
            this.btn_delete_ref.Name = "btn_delete_ref";
            this.btn_delete_ref.Size = new System.Drawing.Size(109, 33);
            this.btn_delete_ref.TabIndex = 8;
            this.btn_delete_ref.Text = "Stonieren";
            this.btn_delete_ref.UseVisualStyleBackColor = true;
            this.btn_delete_ref.Click += new System.EventHandler(this.btn_delete_ref_Click);
            // 
            // dgv_search_refNumber
            // 
            this.dgv_search_refNumber.AllowUserToAddRows = false;
            this.dgv_search_refNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_search_refNumber.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_search_refNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_search_refNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_refNumber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_date,
            this.referenceNumber,
            this.column_ledger,
            this.column_contraLedger,
            this.column_debit,
            this.column_credit,
            this.columnSTR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_search_refNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_search_refNumber.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_search_refNumber.Location = new System.Drawing.Point(12, 94);
            this.dgv_search_refNumber.Name = "dgv_search_refNumber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_search_refNumber.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_search_refNumber.Size = new System.Drawing.Size(686, 383);
            this.dgv_search_refNumber.TabIndex = 50;
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
            // column_ledger
            // 
            dataGridViewCellStyle2.Format = "##";
            dataGridViewCellStyle2.NullValue = null;
            this.column_ledger.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_ledger.HeaderText = "Konto";
            this.column_ledger.Name = "column_ledger";
            this.column_ledger.Width = 80;
            // 
            // column_contraLedger
            // 
            dataGridViewCellStyle3.Format = "##";
            dataGridViewCellStyle3.NullValue = null;
            this.column_contraLedger.DefaultCellStyle = dataGridViewCellStyle3;
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
            // columnSTR
            // 
            dataGridViewCellStyle4.Format = "0";
            this.columnSTR.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnSTR.HeaderText = "Steuersatz";
            this.columnSTR.Name = "columnSTR";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 483);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 51;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_search_refNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_search_refNumber);
            this.Controls.Add(this.btn_delete_ref);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(718, 520);
            this.Name = "frm_search_refNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_search_refNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_refNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_ref;
        private System.Windows.Forms.DataGridView dgv_search_refNumber;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_contraLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTR;
    }
}