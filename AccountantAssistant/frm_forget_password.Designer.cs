
namespace AccountantAssistant
{
    partial class frm_forget_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_forget_password));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_passwordagain = new System.Windows.Forms.TextBox();
            this.lbl_passwordagain = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_sq1_question = new System.Windows.Forms.TextBox();
            this.tb_sq2_question = new System.Windows.Forms.TextBox();
            this.tb_sq2 = new System.Windows.Forms.TextBox();
            this.tb_sq1 = new System.Windows.Forms.TextBox();
            this.lbl_sq1 = new System.Windows.Forms.Label();
            this.lbl_sq2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 308);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 25);
            this.btn_back.TabIndex = 36;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.btn_save.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(236, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 25);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "SPEICHERN";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_passwordagain
            // 
            this.tb_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_passwordagain.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordagain.Location = new System.Drawing.Point(281, 247);
            this.tb_passwordagain.Name = "tb_passwordagain";
            this.tb_passwordagain.Size = new System.Drawing.Size(216, 26);
            this.tb_passwordagain.TabIndex = 34;
            // 
            // lbl_passwordagain
            // 
            this.lbl_passwordagain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_passwordagain.AutoSize = true;
            this.lbl_passwordagain.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordagain.Location = new System.Drawing.Point(13, 245);
            this.lbl_passwordagain.Name = "lbl_passwordagain";
            this.lbl_passwordagain.Size = new System.Drawing.Size(244, 25);
            this.lbl_passwordagain.TabIndex = 42;
            this.lbl_passwordagain.Text = "Passwort wiederholen:";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(281, 212);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(216, 26);
            this.tb_password.TabIndex = 33;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(75, 210);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(182, 25);
            this.lbl_password.TabIndex = 41;
            this.lbl_password.Text = "Neues Passwort:";
            // 
            // tb_sq1_question
            // 
            this.tb_sq1_question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq1_question.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq1_question.Location = new System.Drawing.Point(281, 34);
            this.tb_sq1_question.Name = "tb_sq1_question";
            this.tb_sq1_question.Size = new System.Drawing.Size(215, 26);
            this.tb_sq1_question.TabIndex = 37;
            // 
            // tb_sq2_question
            // 
            this.tb_sq2_question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq2_question.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq2_question.Location = new System.Drawing.Point(281, 113);
            this.tb_sq2_question.Name = "tb_sq2_question";
            this.tb_sq2_question.Size = new System.Drawing.Size(215, 26);
            this.tb_sq2_question.TabIndex = 38;
            // 
            // tb_sq2
            // 
            this.tb_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq2.Location = new System.Drawing.Point(281, 146);
            this.tb_sq2.Name = "tb_sq2";
            this.tb_sq2.Size = new System.Drawing.Size(215, 26);
            this.tb_sq2.TabIndex = 32;
            // 
            // tb_sq1
            // 
            this.tb_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sq1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sq1.Location = new System.Drawing.Point(281, 67);
            this.tb_sq1.Name = "tb_sq1";
            this.tb_sq1.Size = new System.Drawing.Size(215, 26);
            this.tb_sq1.TabIndex = 31;
            // 
            // lbl_sq1
            // 
            this.lbl_sq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sq1.AutoSize = true;
            this.lbl_sq1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sq1.Location = new System.Drawing.Point(54, 32);
            this.lbl_sq1.Name = "lbl_sq1";
            this.lbl_sq1.Size = new System.Drawing.Size(203, 25);
            this.lbl_sq1.TabIndex = 40;
            this.lbl_sq1.Text = "Sicherheitsfrage 1:";
            // 
            // lbl_sq2
            // 
            this.lbl_sq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sq2.AutoSize = true;
            this.lbl_sq2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sq2.Location = new System.Drawing.Point(54, 111);
            this.lbl_sq2.Name = "lbl_sq2";
            this.lbl_sq2.Size = new System.Drawing.Size(203, 25);
            this.lbl_sq2.TabIndex = 39;
            this.lbl_sq2.Text = "Sicherheitsfrage 2:";
            // 
            // frm_forget_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 345);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_passwordagain);
            this.Controls.Add(this.lbl_passwordagain);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_sq1_question);
            this.Controls.Add(this.tb_sq2_question);
            this.Controls.Add(this.tb_sq2);
            this.Controls.Add(this.tb_sq1);
            this.Controls.Add(this.lbl_sq1);
            this.Controls.Add(this.lbl_sq2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 361);
            this.Name = "frm_forget_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_forget_password_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_forget_password_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_passwordagain;
        private System.Windows.Forms.Label lbl_passwordagain;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_sq1_question;
        private System.Windows.Forms.TextBox tb_sq2_question;
        private System.Windows.Forms.TextBox tb_sq2;
        private System.Windows.Forms.TextBox tb_sq1;
        private System.Windows.Forms.Label lbl_sq1;
        private System.Windows.Forms.Label lbl_sq2;
    }
}