namespace AccountantAssistant
{
    partial class frm_ledger_overview
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
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.column_referenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ust_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_debit_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            this.SuspendLayout();
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
            this.column_referenceNumber,
            this.column_ust_rate,
            this.column_debit_credit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_transaction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_transaction.Location = new System.Drawing.Point(12, 54);
            this.dgv_transaction.Name = "dgv_transaction";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_transaction.Size = new System.Drawing.Size(502, 415);
            this.dgv_transaction.TabIndex = 50;
            // 
            // column_referenceNumber
            // 
            this.column_referenceNumber.HeaderText = "Kontonummer";
            this.column_referenceNumber.Name = "column_referenceNumber";
            this.column_referenceNumber.Width = 120;
            // 
            // column_ust_rate
            // 
            dataGridViewCellStyle2.Format = "0";
            dataGridViewCellStyle2.NullValue = null;
            this.column_ust_rate.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_ust_rate.HeaderText = "Kontobezeichnung";
            this.column_ust_rate.Name = "column_ust_rate";
            this.column_ust_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_ust_rate.Width = 150;
            // 
            // column_debit_credit
            // 
            this.column_debit_credit.HeaderText = "Typ";
            this.column_debit_credit.Name = "column_debit_credit";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 475);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 51;
            this.btn_back.Tag = "blue";
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_ledger_overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 512);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_transaction);
            this.Name = "frm_ledger_overview";
            this.Load += new System.EventHandler(this.frm_ledger_overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_referenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ust_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_debit_credit;
        private System.Windows.Forms.Button btn_back;
    }
}