namespace Proje
{
    partial class Form1
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
            this.dönüştür = new System.Windows.Forms.Button();
            this.kaydetword = new System.Windows.Forms.Button();
            this.exceldosyası = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dönüştür
            // 
            this.dönüştür.BackColor = System.Drawing.Color.Silver;
            this.dönüştür.Enabled = false;
            this.dönüştür.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dönüştür.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dönüştür.Location = new System.Drawing.Point(168, 148);
            this.dönüştür.Name = "dönüştür";
            this.dönüştür.Size = new System.Drawing.Size(172, 49);
            this.dönüştür.TabIndex = 5;
            this.dönüştür.Text = "Dönüştür";
            this.dönüştür.UseVisualStyleBackColor = false;
            this.dönüştür.Click += new System.EventHandler(this.dönüştür_Click);
            // 
            // kaydetword
            // 
            this.kaydetword.BackColor = System.Drawing.Color.Silver;
            this.kaydetword.Enabled = false;
            this.kaydetword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.kaydetword.Location = new System.Drawing.Point(42, 74);
            this.kaydetword.Name = "kaydetword";
            this.kaydetword.Size = new System.Drawing.Size(445, 35);
            this.kaydetword.TabIndex = 4;
            this.kaydetword.Text = "Kaydedilecek word konumunu seçiniz...";
            this.kaydetword.UseVisualStyleBackColor = false;
            this.kaydetword.Click += new System.EventHandler(this.kaydetword_Click);
            // 
            // exceldosyası
            // 
            this.exceldosyası.BackColor = System.Drawing.Color.Silver;
            this.exceldosyası.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exceldosyası.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exceldosyası.Location = new System.Drawing.Point(136, 21);
            this.exceldosyası.Name = "exceldosyası";
            this.exceldosyası.Size = new System.Drawing.Size(237, 30);
            this.exceldosyası.TabIndex = 3;
            this.exceldosyası.Text = " Excel dosyasını seçiniz...";
            this.exceldosyası.UseVisualStyleBackColor = false;
            this.exceldosyası.Click += new System.EventHandler(this.exceldosyası_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(526, 252);
            this.Controls.Add(this.dönüştür);
            this.Controls.Add(this.kaydetword);
            this.Controls.Add(this.exceldosyası);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dönüştür;
        private System.Windows.Forms.Button kaydetword;
        private System.Windows.Forms.Button exceldosyası;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

