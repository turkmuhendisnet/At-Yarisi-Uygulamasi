namespace AtYarışı
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pcbAt1 = new System.Windows.Forms.PictureBox();
            this.pcbAt2 = new System.Windows.Forms.PictureBox();
            this.pcbAt3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYarisDurumu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrAtYarisi = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrYarisSuresi = new System.Windows.Forms.Timer(this.components);
            this.lblSaniye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(329, 430);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.Location = new System.Drawing.Point(569, 430);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(162, 34);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pcbAt1
            // 
            this.pcbAt1.Location = new System.Drawing.Point(-136, 71);
            this.pcbAt1.Name = "pcbAt1";
            this.pcbAt1.Size = new System.Drawing.Size(157, 88);
            this.pcbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt1.TabIndex = 2;
            this.pcbAt1.TabStop = false;
            this.pcbAt1.Tag = "1 Numaralı At";
            // 
            // pcbAt2
            // 
            this.pcbAt2.Location = new System.Drawing.Point(-136, 187);
            this.pcbAt2.Name = "pcbAt2";
            this.pcbAt2.Size = new System.Drawing.Size(157, 88);
            this.pcbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt2.TabIndex = 3;
            this.pcbAt2.TabStop = false;
            this.pcbAt2.Tag = "2 Numaralı At";
            // 
            // pcbAt3
            // 
            this.pcbAt3.Location = new System.Drawing.Point(-136, 304);
            this.pcbAt3.Name = "pcbAt3";
            this.pcbAt3.Size = new System.Drawing.Size(157, 88);
            this.pcbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt3.TabIndex = 4;
            this.pcbAt3.TabStop = false;
            this.pcbAt3.Tag = "3 Numaralı At";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtYarışı.Properties.Resources.Finish;
            this.pictureBox1.Location = new System.Drawing.Point(977, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblYarisDurumu
            // 
            this.lblYarisDurumu.AutoSize = true;
            this.lblYarisDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYarisDurumu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblYarisDurumu.Location = new System.Drawing.Point(468, 28);
            this.lblYarisDurumu.Name = "lblYarisDurumu";
            this.lblYarisDurumu.Size = new System.Drawing.Size(0, 17);
            this.lblYarisDurumu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "_________________________________________________________________________________" +
    "______________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(961, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(961, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_________________________________________________________________________________" +
    "______________________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(961, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "_________________________________________________________________________________" +
    "______________________________________________________________________________";
            // 
            // tmrAtYarisi
            // 
            this.tmrAtYarisi.Tick += new System.EventHandler(this.tmrAtYarisi_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.ForeColor = System.Drawing.Color.Red;
            this.lblZaman.Location = new System.Drawing.Point(12, 430);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(99, 17);
            this.lblZaman.TabIndex = 11;
            this.lblZaman.Text = "Geçen Süre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(446, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yarış Durumu";
            // 
            // tmrYarisSuresi
            // 
            this.tmrYarisSuresi.Interval = 1000;
            this.tmrYarisSuresi.Tick += new System.EventHandler(this.tmrYarisSuresi_Tick);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Red;
            this.lblSaniye.Location = new System.Drawing.Point(117, 430);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(0, 17);
            this.lblSaniye.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1062, 476);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYarisDurumu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbAt3);
            this.Controls.Add(this.pcbAt2);
            this.Controls.Add(this.pcbAt1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "TJK TV";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pcbAt1;
        private System.Windows.Forms.PictureBox pcbAt2;
        private System.Windows.Forms.PictureBox pcbAt3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYarisDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrAtYarisi;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrYarisSuresi;
        private System.Windows.Forms.Label lblSaniye;
    }
}

