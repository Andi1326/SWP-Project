
namespace AccountantAssistant
{
    partial class ucTopBar
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.pb_maximize = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
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
            // pb_maximize
            // 
            this.pb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximize.Image = global::AccountantAssistant.Properties.Resources.MaximizeBox;
            this.pb_maximize.Location = new System.Drawing.Point(721, 3);
            this.pb_maximize.Name = "pb_maximize";
            this.pb_maximize.Size = new System.Drawing.Size(15, 15);
            this.pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_maximize.TabIndex = 2;
            this.pb_maximize.TabStop = false;
            this.pb_maximize.Click += new System.EventHandler(this.pb_maximize_Click);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Image = global::AccountantAssistant.Properties.Resources.Minimize_Box2;
            this.pb_minimize.Location = new System.Drawing.Point(696, 3);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(20, 15);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 1;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AccountantAssistant.Properties.Resources.MaximizeBox;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_maximize);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.lbl_header);
            this.Name = "ucTopBar";
            this.Size = new System.Drawing.Size(776, 29);
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_maximize;
        private System.Windows.Forms.Button button1;
    }
}
