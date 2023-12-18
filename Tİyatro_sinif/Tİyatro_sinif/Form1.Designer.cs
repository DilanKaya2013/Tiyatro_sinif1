namespace Tİyatro_sinif
{
    partial class Form1
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
            this.lblOyunİd = new System.Windows.Forms.Label();
            this.lblOyunAd = new System.Windows.Forms.Label();
            this.lblOyunTarihSaat = new System.Windows.Forms.Label();
            this.lblOyunSure = new System.Windows.Forms.Label();
            this.lblSahne = new System.Windows.Forms.Label();
            this.lblMuzikal = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtOyunİd = new System.Windows.Forms.TextBox();
            this.cmbOyunAd = new System.Windows.Forms.ComboBox();
            this.dtpTarihSaat = new System.Windows.Forms.DateTimePicker();
            this.nudOyunSure = new System.Windows.Forms.NumericUpDown();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.chbMuzikal = new System.Windows.Forms.CheckBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dgvTiyatro = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOyunSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOyunİd
            // 
            this.lblOyunİd.AutoSize = true;
            this.lblOyunİd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunİd.Location = new System.Drawing.Point(12, 17);
            this.lblOyunİd.Name = "lblOyunİd";
            this.lblOyunİd.Size = new System.Drawing.Size(58, 17);
            this.lblOyunİd.TabIndex = 0;
            this.lblOyunİd.Text = "Oyun_İd:";
            // 
            // lblOyunAd
            // 
            this.lblOyunAd.AutoSize = true;
            this.lblOyunAd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunAd.Location = new System.Drawing.Point(9, 50);
            this.lblOyunAd.Name = "lblOyunAd";
            this.lblOyunAd.Size = new System.Drawing.Size(61, 17);
            this.lblOyunAd.TabIndex = 1;
            this.lblOyunAd.Text = "Oyun_ad:";
            // 
            // lblOyunTarihSaat
            // 
            this.lblOyunTarihSaat.AutoSize = true;
            this.lblOyunTarihSaat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunTarihSaat.Location = new System.Drawing.Point(249, 30);
            this.lblOyunTarihSaat.Name = "lblOyunTarihSaat";
            this.lblOyunTarihSaat.Size = new System.Drawing.Size(105, 17);
            this.lblOyunTarihSaat.TabIndex = 2;
            this.lblOyunTarihSaat.Text = "Oyun_Tarih_Saat:";
            // 
            // lblOyunSure
            // 
            this.lblOyunSure.AutoSize = true;
            this.lblOyunSure.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunSure.Location = new System.Drawing.Point(-2, 87);
            this.lblOyunSure.Name = "lblOyunSure";
            this.lblOyunSure.Size = new System.Drawing.Size(72, 17);
            this.lblOyunSure.TabIndex = 5;
            this.lblOyunSure.Text = "Oyun_Süre:";
            // 
            // lblSahne
            // 
            this.lblSahne.AutoSize = true;
            this.lblSahne.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahne.Location = new System.Drawing.Point(24, 123);
            this.lblSahne.Name = "lblSahne";
            this.lblSahne.Size = new System.Drawing.Size(46, 17);
            this.lblSahne.TabIndex = 4;
            this.lblSahne.Text = "Sahne:";
            // 
            // lblMuzikal
            // 
            this.lblMuzikal.AutoSize = true;
            this.lblMuzikal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuzikal.Location = new System.Drawing.Point(14, 154);
            this.lblMuzikal.Name = "lblMuzikal";
            this.lblMuzikal.Size = new System.Drawing.Size(56, 17);
            this.lblMuzikal.TabIndex = 3;
            this.lblMuzikal.Text = "Müzikal:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(33, 190);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(37, 17);
            this.lblFiyat.TabIndex = 6;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtOyunİd
            // 
            this.txtOyunİd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunİd.Location = new System.Drawing.Point(76, 11);
            this.txtOyunİd.Name = "txtOyunİd";
            this.txtOyunİd.Size = new System.Drawing.Size(100, 23);
            this.txtOyunİd.TabIndex = 7;
            // 
            // cmbOyunAd
            // 
            this.cmbOyunAd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOyunAd.FormattingEnabled = true;
            this.cmbOyunAd.Items.AddRange(new object[] {
            "İfigenya",
            "Oscar",
            "Gül\'e Ağıt",
            "Gidiş Dönüş Moskova (Retro)",
            "Cadı Kazanı",
            "Komik Para",
            "Çingene Boksör"});
            this.cmbOyunAd.Location = new System.Drawing.Point(76, 42);
            this.cmbOyunAd.Name = "cmbOyunAd";
            this.cmbOyunAd.Size = new System.Drawing.Size(121, 25);
            this.cmbOyunAd.TabIndex = 8;
            // 
            // dtpTarihSaat
            // 
            this.dtpTarihSaat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarihSaat.Location = new System.Drawing.Point(360, 25);
            this.dtpTarihSaat.Name = "dtpTarihSaat";
            this.dtpTarihSaat.Size = new System.Drawing.Size(200, 23);
            this.dtpTarihSaat.TabIndex = 9;
            // 
            // nudOyunSure
            // 
            this.nudOyunSure.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudOyunSure.Location = new System.Drawing.Point(77, 81);
            this.nudOyunSure.Name = "nudOyunSure";
            this.nudOyunSure.Size = new System.Drawing.Size(120, 23);
            this.nudOyunSure.TabIndex = 10;
            // 
            // cmbSahne
            // 
            this.cmbSahne.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi",
            "Fatih Reşat Nuri Sahnesi",
            "Gaziosmanpaşa Ferih Egemen Çocuk Tiyatrosu Sahnesi",
            "Gaziosmanpaşa Sahnesi",
            "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu",
            "Harbiye Muhsin Ertuğrul Sahnesi",
            "İBB Güngören Erdem Beyazıt Kültür Merkezi",
            "İBB Yenibosna Dr. Enver Ören Kültür Merkezi",
            "Kağıthane Sadabad Sahnesi",
            "Müze Gazhane Meydan Sahne",
            "Müze Gazhane Prof. Dr. Sevda Şener Sahnesi",
            "Ümraniye Sahnesi",
            "Üsküdar Kerem Yılmazer Sahnesi",
            "Üsküdar Musahipzade Celãl Sahnesi"});
            this.cmbSahne.Location = new System.Drawing.Point(77, 115);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(121, 25);
            this.cmbSahne.TabIndex = 11;
            // 
            // chbMuzikal
            // 
            this.chbMuzikal.AutoSize = true;
            this.chbMuzikal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbMuzikal.Location = new System.Drawing.Point(77, 154);
            this.chbMuzikal.Name = "chbMuzikal";
            this.chbMuzikal.Size = new System.Drawing.Size(15, 14);
            this.chbMuzikal.TabIndex = 12;
            this.chbMuzikal.UseVisualStyleBackColor = true;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(77, 184);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtFiyat.TabIndex = 13;
            // 
            // dgvTiyatro
            // 
            this.dgvTiyatro.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvTiyatro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiyatro.Location = new System.Drawing.Point(12, 248);
            this.dgvTiyatro.Name = "dgvTiyatro";
            this.dgvTiyatro.Size = new System.Drawing.Size(776, 190);
            this.dgvTiyatro.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::Tİyatro_sinif.Properties.Resources.Sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(437, 104);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 64);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::Tİyatro_sinif.Properties.Resources.Kaydet;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(338, 104);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 64);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::Tİyatro_sinif.Properties.Resources.güncelle;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(249, 104);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 64);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvTiyatro);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.chbMuzikal);
            this.Controls.Add(this.cmbSahne);
            this.Controls.Add(this.nudOyunSure);
            this.Controls.Add(this.dtpTarihSaat);
            this.Controls.Add(this.cmbOyunAd);
            this.Controls.Add(this.txtOyunİd);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblOyunSure);
            this.Controls.Add(this.lblSahne);
            this.Controls.Add(this.lblMuzikal);
            this.Controls.Add(this.lblOyunTarihSaat);
            this.Controls.Add(this.lblOyunAd);
            this.Controls.Add(this.lblOyunİd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudOyunSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyunİd;
        private System.Windows.Forms.Label lblOyunAd;
        private System.Windows.Forms.Label lblOyunTarihSaat;
        private System.Windows.Forms.Label lblOyunSure;
        private System.Windows.Forms.Label lblSahne;
        private System.Windows.Forms.Label lblMuzikal;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtOyunİd;
        private System.Windows.Forms.ComboBox cmbOyunAd;
        private System.Windows.Forms.DateTimePicker dtpTarihSaat;
        private System.Windows.Forms.NumericUpDown nudOyunSure;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.CheckBox chbMuzikal;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvTiyatro;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}

