
namespace AccountantAssistant
{
    partial class frm_balance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_balance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_balance = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.print_Dialog = new System.Windows.Forms.PrintDialog();
            this.print_Document = new System.Drawing.Printing.PrintDocument();
            this.printPreview_Dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_balance
            // 
            this.dgv_balance.AllowUserToAddRows = false;
            this.dgv_balance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_balance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_balance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_date,
            this.column_debit,
            this.column_credit,
            this.Saldo1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_balance.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_balance.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_balance.Location = new System.Drawing.Point(24, 76);
            this.dgv_balance.Name = "dgv_balance";
            this.dgv_balance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_balance.Size = new System.Drawing.Size(444, 391);
            this.dgv_balance.TabIndex = 59;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(24, 473);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 60;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_print
            // 
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(24, 37);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(109, 33);
            this.btn_print.TabIndex = 61;
            this.btn_print.Text = "Drucken";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // print_Dialog
            // 
            this.print_Dialog.UseEXDialog = true;
            // 
            // printPreview_Dialog
            // 
            this.printPreview_Dialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview_Dialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview_Dialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview_Dialog.Enabled = true;
            this.printPreview_Dialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview_Dialog.Icon")));
            this.printPreview_Dialog.Name = "printPreview_Dialog";
            this.printPreview_Dialog.Visible = false;
            // 
            // column_date
            // 
            this.column_date.HeaderText = "Konten-nr";
            this.column_date.Name = "column_date";
            // 
            // column_debit
            // 
            this.column_debit.HeaderText = "Soll";
            this.column_debit.Name = "column_debit";
            // 
            // column_credit
            // 
            this.column_credit.HeaderText = "Haben";
            this.column_credit.Name = "column_credit";
            // 
            // Saldo1
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Saldo1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Saldo1.HeaderText = "Saldo";
            this.Saldo1.Name = "Saldo1";
            // 
            // frm_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_balance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_balance;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PrintDialog print_Dialog;
        private System.Drawing.Printing.PrintDocument print_Document;
        private System.Windows.Forms.PrintPreviewDialog printPreview_Dialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo1;
    }
}