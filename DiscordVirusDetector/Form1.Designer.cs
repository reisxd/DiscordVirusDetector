
namespace DiscordVirusDetector
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
            this.discordWH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usingC = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.select = new System.Windows.Forms.Button();
            this.fileDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // discordWH
            // 
            this.discordWH.Location = new System.Drawing.Point(12, 214);
            this.discordWH.MaxLength = 32767999;
            this.discordWH.Name = "discordWH";
            this.discordWH.Size = new System.Drawing.Size(477, 20);
            this.discordWH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discord Webhook link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Using";
            // 
            // usingC
            // 
            this.usingC.Location = new System.Drawing.Point(12, 175);
            this.usingC.Name = "usingC";
            this.usingC.ReadOnly = true;
            this.usingC.Size = new System.Drawing.Size(477, 20);
            this.usingC.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(12, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(48, 23);
            this.select.TabIndex = 4;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // fileDir
            // 
            this.fileDir.Location = new System.Drawing.Point(66, 15);
            this.fileDir.Name = "fileDir";
            this.fileDir.ReadOnly = true;
            this.fileDir.Size = new System.Drawing.Size(423, 20);
            this.fileDir.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 246);
            this.Controls.Add(this.fileDir);
            this.Controls.Add(this.select);
            this.Controls.Add(this.usingC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discordWH);
            this.Name = "Form1";
            this.Text = "DiscordVirusDetector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discordWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usingC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox fileDir;
    }
}

