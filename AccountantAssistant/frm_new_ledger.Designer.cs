
namespace AccountantAssistant
{
    partial class frm_new_ledger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_new_ledger));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lbl_ledger_name = new System.Windows.Forms.Label();
            this.lbl_ledger_number = new System.Windows.Forms.Label();
            this.lbl_ledger_type = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 261);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 5;
            this.btn_back.Tag = "blue";
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_create.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(193, 261);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(122, 25);
            this.btn_create.TabIndex = 4;
            this.btn_create.Tag = "blue";
            this.btn_create.Text = "ERSTELLEN";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(273, 183);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(216, 26);
            this.tb_name.TabIndex = 2;
            // 
            // tb_number
            // 
            this.tb_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_number.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.Location = new System.Drawing.Point(273, 151);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(216, 26);
            this.tb_number.TabIndex = 1;
            // 
            // lbl_ledger_name
            // 
            this.lbl_ledger_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ledger_name.AutoSize = true;
            this.lbl_ledger_name.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ledger_name.Location = new System.Drawing.Point(112, 181);
            this.lbl_ledger_name.Name = "lbl_ledger_name";
            this.lbl_ledger_name.Size = new System.Drawing.Size(137, 25);
            this.lbl_ledger_name.TabIndex = 46;
            this.lbl_ledger_name.Text = "Kontoname:";
            // 
            // lbl_ledger_number
            // 
            this.lbl_ledger_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ledger_number.AutoSize = true;
            this.lbl_ledger_number.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ledger_number.Location = new System.Drawing.Point(81, 149);
            this.lbl_ledger_number.Name = "lbl_ledger_number";
            this.lbl_ledger_number.Size = new System.Drawing.Size(168, 25);
            this.lbl_ledger_number.TabIndex = 45;
            this.lbl_ledger_number.Text = "Kontonummer:";
            // 
            // lbl_ledger_type
            // 
            this.lbl_ledger_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ledger_type.AutoSize = true;
            this.lbl_ledger_type.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ledger_type.Location = new System.Drawing.Point(142, 213);
            this.lbl_ledger_type.Name = "lbl_ledger_type";
            this.lbl_ledger_type.Size = new System.Drawing.Size(107, 25);
            this.lbl_ledger_type.TabIndex = 60;
            this.lbl_ledger_type.Text = "Kontoart:";
            // 
            // cb_type
            // 
            this.cb_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "AB",
            "PB",
            "AK",
            "EK"});
            this.cb_type.Location = new System.Drawing.Point(273, 219);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(216, 21);
            this.cb_type.TabIndex = 3;
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::AccountantAssistant.Properties.Resources.logo_small;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Location = new System.Drawing.Point(11, 9);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(192, 134);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 61;
            this.pb_logo.TabStop = false;
            // 
            // frm_new_ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 298);
            this.ControlBox = false;
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lbl_ledger_type);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lbl_ledger_name);
            this.Controls.Add(this.lbl_ledger_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 314);
            this.Name = "frm_new_ledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_new_ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lbl_ledger_name;
        private System.Windows.Forms.Label lbl_ledger_number;
        private System.Windows.Forms.Label lbl_ledger_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}