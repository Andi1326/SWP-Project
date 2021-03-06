
namespace AccountantAssistant
{
    partial class ucTopBarWhite
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTopBarWhite));
            this.lbl_header = new System.Windows.Forms.Label();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_maximize = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_save = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(280, 3);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(216, 19);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "ACAS - Accountant Assistant";
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(738, 0);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(35, 29);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_close.TabIndex = 10;
            this.pb_close.TabStop = false;
            this.pb_close.Tag = "normal";
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave);
            this.pb_close.MouseHover += new System.EventHandler(this.pb_close_MouseHover);
            // 
            // pb_maximize
            // 
            this.pb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximize.Image = ((System.Drawing.Image)(resources.GetObject("pb_maximize.Image")));
            this.pb_maximize.Location = new System.Drawing.Point(707, 0);
            this.pb_maximize.Name = "pb_maximize";
            this.pb_maximize.Size = new System.Drawing.Size(35, 29);
            this.pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_maximize.TabIndex = 9;
            this.pb_maximize.TabStop = false;
            this.pb_maximize.Tag = "normal";
            this.pb_maximize.Click += new System.EventHandler(this.pb_maximize_Click);
            this.pb_maximize.MouseLeave += new System.EventHandler(this.pb_maximize_MouseLeave);
            this.pb_maximize.MouseHover += new System.EventHandler(this.pb_maximize_MouseHover);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(676, 0);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(35, 29);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_minimize.TabIndex = 8;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Tag = "normal";
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            this.pb_minimize.MouseLeave += new System.EventHandler(this.pb_minimize_MouseLeave);
            this.pb_minimize.MouseHover += new System.EventHandler(this.pb_minimize_MouseHover);
            // 
            // pb_save
            // 
            this.pb_save.Image = global::AccountantAssistant.Properties.Resources.SaveButton;
            this.pb_save.Location = new System.Drawing.Point(3, 3);
            this.pb_save.Name = "pb_save";
            this.pb_save.Size = new System.Drawing.Size(30, 22);
            this.pb_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_save.TabIndex = 11;
            this.pb_save.TabStop = false;
            this.pb_save.Tag = "normal";
            this.pb_save.Visible = false;
            // 
            // ucTopBarWhite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_save);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_maximize);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.lbl_header);
            this.Name = "ucTopBarWhite";
            this.Size = new System.Drawing.Size(776, 29);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucTopBarWhite_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucTopBarWhite_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ucTopBarWhite_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        public System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pb_maximize;
        private System.Windows.Forms.PictureBox pb_close;
        public System.Windows.Forms.PictureBox pb_minimize;
        public System.Windows.Forms.PictureBox pb_save;
    }
}
