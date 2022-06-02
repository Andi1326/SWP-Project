
namespace AccountantAssistant
{
    partial class frm_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_register));
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_passwordagain = new System.Windows.Forms.TextBox();
            this.lbl_passwordagain = new System.Windows.Forms.Label();
            this.tb_sq2 = new System.Windows.Forms.TextBox();
            this.cb_sq2 = new System.Windows.Forms.ComboBox();
            this.tb_sq1 = new System.Windows.Forms.TextBox();
            this.cb_sq1 = new System.Windows.Forms.ComboBox();
            this.lbl_sq1 = new System.Windows.Forms.Label();
            this.lbl_sq2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_showHidePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_role
            // 
            this.cb_role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_role.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Mitarbeiter",
            "Praktikant"});
            this.cb_role.Location = new System.Drawing.Point(285, 487);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(215, 23);
            this.cb_role.TabIndex = 39;
            // 
            // lbl_role
            // 
            this.lbl_role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(188, 482);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(72, 25);
            this.lbl_role.TabIndex = 43;
            this.lbl_role.Text = "Rolle:";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(20, 540);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 42;
            this.btn_back.Tag = "blue";
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_passwordagain
            // 
            this.tb_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_passwordagain.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordagain.Location = new System.Drawing.Point(283, 249);
            this.tb_passwordagain.Name = "tb_passwordagain";
            this.tb_passwordagain.Size = new System.Drawing.Size(216, 26);
            this.tb_passwordagain.TabIndex = 31;
            this.tb_passwordagain.UseSystemPasswordChar = true;
            // 
            // lbl_passwordagain
            // 
            this.lbl_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_passwordagain.AutoSize = true;
            this.lbl_passwordagain.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordagain.Location = new System.Drawing.Point(15, 247);
            this.lbl_passwordagain.Name = "lbl_passwordagain";
            this.lbl_passwordagain.Size = new System.Drawing.Size(244, 25);
            this.lbl_passwordagain.TabIndex = 41;
            this.lbl_passwordagain.Text = "Passwort wiederholen:";
            // 
            // tb_sq2
            // 
            this.tb_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq2.Location = new System.Drawing.Point(284, 411);
            this.tb_sq2.Name = "tb_sq2";
            this.tb_sq2.Size = new System.Drawing.Size(215, 26);
            this.tb_sq2.TabIndex = 37;
            // 
            // cb_sq2
            // 
            this.cb_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_sq2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sq2.FormattingEnabled = true;
            this.cb_sq2.Items.AddRange(new object[] {
            "Wie hieß Ihr erstes Haustier?",
            "Wie ist der Mädchennamen Ihrer Mutter?",
            "Was ist Ihr Lieblinsessen?"});
            this.cb_sq2.Location = new System.Drawing.Point(284, 378);
            this.cb_sq2.Name = "cb_sq2";
            this.cb_sq2.Size = new System.Drawing.Size(215, 23);
            this.cb_sq2.TabIndex = 36;
            // 
            // tb_sq1
            // 
            this.tb_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq1.Location = new System.Drawing.Point(284, 332);
            this.tb_sq1.Name = "tb_sq1";
            this.tb_sq1.Size = new System.Drawing.Size(215, 26);
            this.tb_sq1.TabIndex = 34;
            // 
            // cb_sq1
            // 
            this.cb_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_sq1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sq1.FormattingEnabled = true;
            this.cb_sq1.Items.AddRange(new object[] {
            "Wie hieß Ihre erste Schule?",
            "Was ist Ihr Lieblinsclub?",
            "Was ist Ihr Lieblinssport?"});
            this.cb_sq1.Location = new System.Drawing.Point(284, 299);
            this.cb_sq1.Name = "cb_sq1";
            this.cb_sq1.Size = new System.Drawing.Size(215, 23);
            this.cb_sq1.TabIndex = 32;
            // 
            // lbl_sq1
            // 
            this.lbl_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sq1.AutoSize = true;
            this.lbl_sq1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sq1.Location = new System.Drawing.Point(57, 297);
            this.lbl_sq1.Name = "lbl_sq1";
            this.lbl_sq1.Size = new System.Drawing.Size(203, 25);
            this.lbl_sq1.TabIndex = 35;
            this.lbl_sq1.Text = "Sicherheitsfrage 1:";
            // 
            // lbl_sq2
            // 
            this.lbl_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sq2.AutoSize = true;
            this.lbl_sq2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sq2.Location = new System.Drawing.Point(57, 376);
            this.lbl_sq2.Name = "lbl_sq2";
            this.lbl_sq2.Size = new System.Drawing.Size(203, 25);
            this.lbl_sq2.TabIndex = 33;
            this.lbl_sq2.Text = "Sicherheitsfrage 2:";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_login.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(201, 540);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 25);
            this.btn_login.TabIndex = 40;
            this.btn_login.Tag = "blue";
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(283, 214);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(216, 26);
            this.tb_password.TabIndex = 30;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(283, 170);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(216, 26);
            this.tb_user.TabIndex = 29;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(148, 212);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(112, 25);
            this.lbl_password.TabIndex = 28;
            this.lbl_password.Text = "Passwort:";
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(148, 168);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(111, 25);
            this.lbl_user.TabIndex = 27;
            this.lbl_user.Text = "Benutzer:";
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::AccountantAssistant.Properties.Resources.logo_small;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Location = new System.Drawing.Point(20, 20);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(192, 134);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 44;
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
            this.btn_showHidePassword.Location = new System.Drawing.Point(505, 246);
            this.btn_showHidePassword.Name = "btn_showHidePassword";
            this.btn_showHidePassword.Size = new System.Drawing.Size(35, 35);
            this.btn_showHidePassword.TabIndex = 45;
            this.btn_showHidePassword.Tag = "blue";
            this.btn_showHidePassword.UseVisualStyleBackColor = false;
            this.btn_showHidePassword.Click += new System.EventHandler(this.btn_showHidePassword_Click);
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 617);
            this.ControlBox = false;
            this.Controls.Add(this.btn_showHidePassword);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_passwordagain);
            this.Controls.Add(this.lbl_passwordagain);
            this.Controls.Add(this.tb_sq2);
            this.Controls.Add(this.cb_sq2);
            this.Controls.Add(this.tb_sq1);
            this.Controls.Add(this.cb_sq1);
            this.Controls.Add(this.lbl_sq1);
            this.Controls.Add(this.lbl_sq2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 617);
            this.Name = "frm_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_register_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_passwordagain;
        private System.Windows.Forms.Label lbl_passwordagain;
        private System.Windows.Forms.TextBox tb_sq2;
        private System.Windows.Forms.ComboBox cb_sq2;
        private System.Windows.Forms.TextBox tb_sq1;
        private System.Windows.Forms.ComboBox cb_sq1;
        private System.Windows.Forms.Label lbl_sq1;
        private System.Windows.Forms.Label lbl_sq2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_showHidePassword;
    }
}