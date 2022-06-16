namespace OOP_PizzaOrnek
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
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPizza = new System.Windows.Forms.GroupBox();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.btnPizzaGuncelle = new System.Windows.Forms.Button();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.btnPizzaKaydet = new System.Windows.Forms.Button();
            this.nmudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.btnMalzemeCikar = new System.Windows.Forms.Button();
            this.cmbMalzemeler = new System.Windows.Forms.ComboBox();
            this.txtPizzaAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSiparis = new System.Windows.Forms.GroupBox();
            this.flpMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.nmupAdet = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPizzaTuru = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpMusteri.SuspendLayout();
            this.grpPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFiyat)).BeginInit();
            this.grpSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.lstMusteriler);
            this.grpMusteri.Controls.Add(this.btnMusteriKaydet);
            this.grpMusteri.Controls.Add(this.txtAdres);
            this.grpMusteri.Controls.Add(this.txtTelefon);
            this.grpMusteri.Controls.Add(this.txtMusteriSoyad);
            this.grpMusteri.Controls.Add(this.txtMusteriAd);
            this.grpMusteri.Controls.Add(this.label4);
            this.grpMusteri.Controls.Add(this.label3);
            this.grpMusteri.Controls.Add(this.label2);
            this.grpMusteri.Controls.Add(this.label1);
            this.grpMusteri.Location = new System.Drawing.Point(28, 23);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(427, 257);
            this.grpMusteri.TabIndex = 0;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteriler";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.Location = new System.Drawing.Point(7, 145);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(411, 95);
            this.lstMusteriler.TabIndex = 9;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(343, 100);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriKaydet.TabIndex = 8;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(259, 27);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(159, 60);
            this.txtAdres.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(74, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(74, 67);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyad.TabIndex = 5;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(74, 27);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // grpPizza
            // 
            this.grpPizza.Controls.Add(this.btnPizzaSil);
            this.grpPizza.Controls.Add(this.btnPizzaGuncelle);
            this.grpPizza.Controls.Add(this.lstPizzalar);
            this.grpPizza.Controls.Add(this.btnPizzaKaydet);
            this.grpPizza.Controls.Add(this.nmudFiyat);
            this.grpPizza.Controls.Add(this.label7);
            this.grpPizza.Controls.Add(this.lstMalzemeler);
            this.grpPizza.Controls.Add(this.btnMalzemeEkle);
            this.grpPizza.Controls.Add(this.btnMalzemeCikar);
            this.grpPizza.Controls.Add(this.cmbMalzemeler);
            this.grpPizza.Controls.Add(this.txtPizzaAd);
            this.grpPizza.Controls.Add(this.label6);
            this.grpPizza.Controls.Add(this.label5);
            this.grpPizza.Location = new System.Drawing.Point(517, 23);
            this.grpPizza.Name = "grpPizza";
            this.grpPizza.Size = new System.Drawing.Size(554, 257);
            this.grpPizza.TabIndex = 1;
            this.grpPizza.TabStop = false;
            this.grpPizza.Text = "Pizzalar";
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.Location = new System.Drawing.Point(392, 78);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(75, 23);
            this.btnPizzaSil.TabIndex = 12;
            this.btnPizzaSil.Text = "Sil";
            this.btnPizzaSil.UseVisualStyleBackColor = true;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // btnPizzaGuncelle
            // 
            this.btnPizzaGuncelle.Location = new System.Drawing.Point(473, 78);
            this.btnPizzaGuncelle.Name = "btnPizzaGuncelle";
            this.btnPizzaGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnPizzaGuncelle.TabIndex = 11;
            this.btnPizzaGuncelle.Text = "Güncelle";
            this.btnPizzaGuncelle.UseVisualStyleBackColor = true;
            this.btnPizzaGuncelle.Click += new System.EventHandler(this.btnPizzaGuncelle_Click);
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.Location = new System.Drawing.Point(265, 107);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(283, 134);
            this.lstPizzalar.TabIndex = 10;
            // 
            // btnPizzaKaydet
            // 
            this.btnPizzaKaydet.Location = new System.Drawing.Point(142, 221);
            this.btnPizzaKaydet.Name = "btnPizzaKaydet";
            this.btnPizzaKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnPizzaKaydet.TabIndex = 9;
            this.btnPizzaKaydet.Text = "Kaydet";
            this.btnPizzaKaydet.UseVisualStyleBackColor = true;
            this.btnPizzaKaydet.Click += new System.EventHandler(this.btnPizzaKaydet_Click);
            // 
            // nmudFiyat
            // 
            this.nmudFiyat.Location = new System.Drawing.Point(98, 192);
            this.nmudFiyat.Name = "nmudFiyat";
            this.nmudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmudFiyat.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fiyat:";
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.Location = new System.Drawing.Point(33, 126);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(185, 56);
            this.lstMalzemeler.TabIndex = 6;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(194, 94);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(25, 25);
            this.btnMalzemeEkle.TabIndex = 5;
            this.btnMalzemeEkle.Text = "+";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // btnMalzemeCikar
            // 
            this.btnMalzemeCikar.Location = new System.Drawing.Point(153, 94);
            this.btnMalzemeCikar.Name = "btnMalzemeCikar";
            this.btnMalzemeCikar.Size = new System.Drawing.Size(25, 25);
            this.btnMalzemeCikar.TabIndex = 4;
            this.btnMalzemeCikar.Text = "-";
            this.btnMalzemeCikar.UseVisualStyleBackColor = true;
            this.btnMalzemeCikar.Click += new System.EventHandler(this.btnMalzemeCikar_Click);
            // 
            // cmbMalzemeler
            // 
            this.cmbMalzemeler.FormattingEnabled = true;
            this.cmbMalzemeler.Location = new System.Drawing.Point(98, 67);
            this.cmbMalzemeler.Name = "cmbMalzemeler";
            this.cmbMalzemeler.Size = new System.Drawing.Size(121, 21);
            this.cmbMalzemeler.TabIndex = 3;
            // 
            // txtPizzaAd
            // 
            this.txtPizzaAd.Location = new System.Drawing.Point(98, 27);
            this.txtPizzaAd.Name = "txtPizzaAd";
            this.txtPizzaAd.Size = new System.Drawing.Size(121, 20);
            this.txtPizzaAd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Malzemeler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad:";
            // 
            // grpSiparis
            // 
            this.grpSiparis.Controls.Add(this.flpMalzemeler);
            this.grpSiparis.Controls.Add(this.lstSepet);
            this.grpSiparis.Controls.Add(this.btnSepeteEkle);
            this.grpSiparis.Controls.Add(this.nmupAdet);
            this.grpSiparis.Controls.Add(this.label11);
            this.grpSiparis.Controls.Add(this.label10);
            this.grpSiparis.Controls.Add(this.cmbPizzaTuru);
            this.grpSiparis.Controls.Add(this.cmbMusteri);
            this.grpSiparis.Controls.Add(this.label9);
            this.grpSiparis.Controls.Add(this.label8);
            this.grpSiparis.Location = new System.Drawing.Point(28, 310);
            this.grpSiparis.Name = "grpSiparis";
            this.grpSiparis.Size = new System.Drawing.Size(1043, 258);
            this.grpSiparis.TabIndex = 2;
            this.grpSiparis.TabStop = false;
            this.grpSiparis.Text = "Sipariş";
            // 
            // flpMalzemeler
            // 
            this.flpMalzemeler.Location = new System.Drawing.Point(9, 122);
            this.flpMalzemeler.Name = "flpMalzemeler";
            this.flpMalzemeler.Size = new System.Drawing.Size(439, 84);
            this.flpMalzemeler.TabIndex = 9;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(489, 26);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(518, 212);
            this.lstSepet.TabIndex = 8;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(193, 225);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(91, 27);
            this.btnSepeteEkle.TabIndex = 7;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // nmupAdet
            // 
            this.nmupAdet.Location = new System.Drawing.Point(74, 223);
            this.nmupAdet.Name = "nmupAdet";
            this.nmupAdet.Size = new System.Drawing.Size(70, 20);
            this.nmupAdet.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Adet:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Çıkarmak istediğiniz malzemeleri seçiniz";
            // 
            // cmbPizzaTuru
            // 
            this.cmbPizzaTuru.FormattingEnabled = true;
            this.cmbPizzaTuru.Location = new System.Drawing.Point(104, 66);
            this.cmbPizzaTuru.Name = "cmbPizzaTuru";
            this.cmbPizzaTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbPizzaTuru.TabIndex = 3;
            this.cmbPizzaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbPizzaTuru_SelectedIndexChanged);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(104, 26);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pizza Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müşteri:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 646);
            this.Controls.Add(this.grpSiparis);
            this.Controls.Add(this.grpPizza);
            this.Controls.Add(this.grpMusteri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpPizza.ResumeLayout(false);
            this.grpPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFiyat)).EndInit();
            this.grpSiparis.ResumeLayout(false);
            this.grpSiparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPizza;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.Button btnPizzaGuncelle;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.Button btnPizzaKaydet;
        private System.Windows.Forms.NumericUpDown nmudFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Button btnMalzemeCikar;
        private System.Windows.Forms.ComboBox cmbMalzemeler;
        private System.Windows.Forms.TextBox txtPizzaAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSiparis;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown nmupAdet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPizzaTuru;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeler;
    }
}

