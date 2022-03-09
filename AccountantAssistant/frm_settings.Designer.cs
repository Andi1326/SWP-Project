
namespace AccountantAssistant
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_head = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.lbl_design = new System.Windows.Forms.Label();
            this.cb_design = new System.Windows.Forms.ComboBox();
            this.btn_changeDesign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 474);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 44;
            this.btn_back.Tag = "blue";
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_head.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.lbl_head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_head.Location = new System.Drawing.Point(11, 44);
            this.lbl_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(164, 29);
            this.lbl_head.TabIndex = 45;
            this.lbl_head.Tag = "blue";
            this.lbl_head.Text = "Konto-Daten:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(90, 85);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(195, 26);
            this.tb_password.TabIndex = 46;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(13, 88);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 18);
            this.lbl_password.TabIndex = 52;
            this.lbl_password.Text = "Passwort:";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.ForeColor = System.Drawing.Color.Black;
            this.btn_changePassword.Location = new System.Drawing.Point(291, 84);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(96, 26);
            this.btn_changePassword.TabIndex = 53;
            this.btn_changePassword.Tag = "normal";
            this.btn_changePassword.Text = "Ändern";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lbl_design
            // 
            this.lbl_design.AutoSize = true;
            this.lbl_design.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_design.Location = new System.Drawing.Point(28, 135);
            this.lbl_design.Name = "lbl_design";
            this.lbl_design.Size = new System.Drawing.Size(56, 18);
            this.lbl_design.TabIndex = 54;
            this.lbl_design.Text = "Design:";
            // 
            // cb_design
            // 
            this.cb_design.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_design.FormattingEnabled = true;
            this.cb_design.Items.AddRange(new object[] {
            "Darkmode",
            "Whitemode"});
            this.cb_design.Location = new System.Drawing.Point(90, 131);
            this.cb_design.Name = "cb_design";
            this.cb_design.Size = new System.Drawing.Size(195, 26);
            this.cb_design.Sorted = true;
            this.cb_design.TabIndex = 55;
            // 
            // btn_changeDesign
            // 
            this.btn_changeDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeDesign.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeDesign.ForeColor = System.Drawing.Color.Black;
            this.btn_changeDesign.Location = new System.Drawing.Point(291, 131);
            this.btn_changeDesign.Name = "btn_changeDesign";
            this.btn_changeDesign.Size = new System.Drawing.Size(96, 26);
            this.btn_changeDesign.TabIndex = 56;
            this.btn_changeDesign.Tag = "normal";
            this.btn_changeDesign.Text = "Ändern";
            this.btn_changeDesign.UseVisualStyleBackColor = true;
            this.btn_changeDesign.Click += new System.EventHandler(this.btn_changeDesign_Click);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btn_changeDesign);
            this.Controls.Add(this.cb_design);
            this.Controls.Add(this.lbl_design);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(948, 527);
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Label lbl_design;
        private System.Windows.Forms.ComboBox cb_design;
        private System.Windows.Forms.Button btn_changeDesign;
    }
}