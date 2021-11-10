
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cb_role.Location = new System.Drawing.Point(287, 468);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(215, 23);
            this.cb_role.TabIndex = 39;
            this.cb_role.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_role_KeyDown);
            // 
            // lbl_role
            // 
            this.lbl_role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(190, 463);
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
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(22, 541);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 25);
            this.btn_back.TabIndex = 42;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_passwordagain
            // 
            this.tb_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_passwordagain.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordagain.Location = new System.Drawing.Point(285, 230);
            this.tb_passwordagain.Name = "tb_passwordagain";
            this.tb_passwordagain.Size = new System.Drawing.Size(216, 26);
            this.tb_passwordagain.TabIndex = 31;
            // 
            // lbl_passwordagain
            // 
            this.lbl_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_passwordagain.AutoSize = true;
            this.lbl_passwordagain.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordagain.Location = new System.Drawing.Point(17, 228);
            this.lbl_passwordagain.Name = "lbl_passwordagain";
            this.lbl_passwordagain.Size = new System.Drawing.Size(244, 25);
            this.lbl_passwordagain.TabIndex = 41;
            this.lbl_passwordagain.Text = "Passwort wiederholen:";
            // 
            // tb_sq2
            // 
            this.tb_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq2.Location = new System.Drawing.Point(286, 392);
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
            this.cb_sq2.Location = new System.Drawing.Point(286, 359);
            this.cb_sq2.Name = "cb_sq2";
            this.cb_sq2.Size = new System.Drawing.Size(215, 23);
            this.cb_sq2.TabIndex = 36;
            this.cb_sq2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_sq2_KeyDown);
            // 
            // tb_sq1
            // 
            this.tb_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq1.Location = new System.Drawing.Point(286, 313);
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
            this.cb_sq1.Location = new System.Drawing.Point(286, 280);
            this.cb_sq1.Name = "cb_sq1";
            this.cb_sq1.Size = new System.Drawing.Size(215, 23);
            this.cb_sq1.TabIndex = 32;
            this.cb_sq1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_sq1_KeyDown);
            // 
            // lbl_sq1
            // 
            this.lbl_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sq1.AutoSize = true;
            this.lbl_sq1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sq1.Location = new System.Drawing.Point(59, 278);
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
            this.lbl_sq2.Location = new System.Drawing.Point(59, 357);
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
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(203, 541);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 25);
            this.btn_login.TabIndex = 40;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(285, 195);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(216, 26);
            this.tb_password.TabIndex = 30;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(285, 151);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(216, 26);
            this.tb_user.TabIndex = 29;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(150, 193);
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
            this.lbl_user.Location = new System.Drawing.Point(150, 149);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(111, 25);
            this.lbl_user.TabIndex = 27;
            this.lbl_user.Text = "Benutzer:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AccountantAssistant.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 578);
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
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(549, 617);
            this.Name = "frm_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_register";
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_register_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}