namespace DENİZ_SAVAŞ_OYUNU
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.savasAlanıPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.süreLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.gemiPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bilgiPanel.SuspendLayout();
            this.gemiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // savasAlanıPanel
            // 
            this.savasAlanıPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.savasAlanıPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savasAlanıPanel.Location = new System.Drawing.Point(0, 200);
            this.savasAlanıPanel.Name = "savasAlanıPanel";
            this.savasAlanıPanel.Size = new System.Drawing.Size(658, 250);
            this.savasAlanıPanel.TabIndex = 0;
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bilgiPanel.Controls.Add(this.süreLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(658, 96);
            this.bilgiPanel.TabIndex = 1;
            // 
            // süreLabel
            // 
            this.süreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.süreLabel.AutoSize = true;
            this.süreLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.süreLabel.Location = new System.Drawing.Point(463, 12);
            this.süreLabel.Name = "süreLabel";
            this.süreLabel.Size = new System.Drawing.Size(131, 59);
            this.süreLabel.TabIndex = 1;
            this.süreLabel.Text = "0:00";
            this.süreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bilgiLabel.Location = new System.Drawing.Point(28, 31);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(345, 40);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "1- Oyunu başlatmak için ENTER tuşuna basınız.\r\n\r\n";
            // 
            // gemiPanel
            // 
            this.gemiPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gemiPanel.Controls.Add(this.pictureBox1);
            this.gemiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gemiPanel.Location = new System.Drawing.Point(0, 96);
            this.gemiPanel.Name = "gemiPanel";
            this.gemiPanel.Size = new System.Drawing.Size(658, 104);
            this.gemiPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.gemiPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.savasAlanıPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Deniz Savaş Oyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.gemiPanel.ResumeLayout(false);
            this.gemiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel savasAlanıPanel;
        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel gemiPanel;
        private System.Windows.Forms.Label süreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

