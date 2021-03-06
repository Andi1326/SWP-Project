
namespace AccountantAssistant
{
    partial class frm_login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_forgot = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_showHidePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_register
            // 
            this.lbl_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_register.AutoSize = true;
            this.lbl_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_register.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.Location = new System.Drawing.Point(217, 255);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(108, 19);
            this.lbl_register.TabIndex = 15;
            this.lbl_register.Text = "Registrieren";
            this.lbl_register.Click += new System.EventHandler(this.lbl_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(204, 319);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 25);
            this.btn_login.TabIndex = 14;
            this.btn_login.Tag = "blue";
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgot.Location = new System.Drawing.Point(218, 286);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(108, 13);
            this.lbl_forgot.TabIndex = 13;
            this.lbl_forgot.Tag = "";
            this.lbl_forgot.Text = "Passwort vergessen?";
            this.lbl_forgot.Click += new System.EventHandler(this.lbl_forgot_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(281, 214);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(165, 26);
            this.tb_password.TabIndex = 12;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(281, 173);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(165, 26);
            this.tb_user.TabIndex = 11;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(146, 209);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(129, 29);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Passwort:";
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(146, 168);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(129, 29);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "Benutzer:";
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::AccountantAssistant.Properties.Resources.logo_small;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Location = new System.Drawing.Point(20, 31);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(192, 134);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // btn_showHidePassword
            // 
            this.btn_showHidePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_showHidePassword.BackgroundImage = global::AccountantAssistant.Properties.Resources.showPassword_White;
            this.btn_showHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showHidePassword.FlatAppearance.BorderSize = 0;
            this.btn_showHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showHidePassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showHidePassword.ForeColor = System.Drawing.Color.White;
            this.btn_showHidePassword.Location = new System.Drawing.Point(452, 209);
            this.btn_showHidePassword.Name = "btn_showHidePassword";
            this.btn_showHidePassword.Size = new System.Drawing.Size(35, 35);
            this.btn_showHidePassword.TabIndex = 16;
            this.btn_showHidePassword.Tag = "blue";
            this.btn_showHidePassword.UseVisualStyleBackColor = false;
            this.btn_showHidePassword.Click += new System.EventHandler(this.btn_showHidePassword_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btn_showHidePassword);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_forgot);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 379);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Password";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_forgot;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_showHidePassword;
    }
}

