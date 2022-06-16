using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PizzaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMalzemeler.Items.Add("Mısır");
            cmbMalzemeler.Items.Add("Sucuk");
            cmbMalzemeler.Items.Add("Zeytin");
            cmbMalzemeler.Items.Add("Mantar");
            cmbMalzemeler.Items.Add("Domates");
            cmbMalzemeler.Items.Add("Biber");
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = txtMusteriAd.Text;
            m.Soyad = txtMusteriSoyad.Text;
            m.Telefon = txtTelefon.Text;
            m.Adres = txtAdres.Text;
            lstMusteriler.Items.Add(m);
            cmbMusteri.Items.Add(m);
            MusteriTemizleme();
        }

        void MusteriTemizleme()
        {
            foreach (var item in grpMusteri.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        void PizzaTemizleme()
        {
            foreach (var item in grpPizza.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                lstMalzemeler.Items.Clear();
            }
        }

        void SiparisTemizleme()
        {
            foreach (var item in grpSiparis.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        void PizzaListboxDoldur()
        {
            lstPizzalar.Items.Clear();
            foreach (var item in pizzaDetay)
            {
                lstPizzalar.Items.Add(item);
            }
        }

        void PizzaTuruComboboxDoldur()
        {
            cmbPizzaTuru.Items.Clear();
            foreach (var item in pizzaDetay)
            {
                cmbPizzaTuru.Items.Add(item);
            }
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            string seciliMalzeme = cmbMalzemeler.SelectedItem.ToString();
            lstMalzemeler.Items.Add(seciliMalzeme);
        }

        private void btnMalzemeCikar_Click(object sender, EventArgs e)
        {
            string seciliMalzeme = lstMalzemeler.SelectedItem.ToString();
            lstMalzemeler.Items.Remove(seciliMalzeme);
        }

        ArrayList pizzaDetay = new ArrayList();

        bool pizzaGuncellemeMi = false;
        private void btnPizzaKaydet_Click(object sender, EventArgs e)
        {
            ArrayList pizzaMalzeme = new ArrayList();
            Pizza p = new Pizza();

            if (pizzaGuncellemeMi)
            {
                p.Ad = txtPizzaAd.Text;
                foreach (var item in lstMalzemeler.Items)
                {
                    pizzaMalzeme.Add(item);
                }
                p.Malzeme = pizzaMalzeme;
                p.Fiyat = nmudFiyat.Value;
                pizzaDetay[lstPizzalar.SelectedIndex] = p;
                pizzaGuncellemeMi = false;
            }

            else
            {
                p.Ad = txtPizzaAd.Text;
                foreach (var item in lstMalzemeler.Items)
                {
                    pizzaMalzeme.Add(item);
                }
                p.Malzeme = pizzaMalzeme;
                p.Fiyat = nmudFiyat.Value;
                pizzaDetay.Add(p);

            }
            PizzaTemizleme();
            PizzaListboxDoldur();
            PizzaTuruComboboxDoldur();
        }

        private void btnPizzaGuncelle_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex == -1)
            {
                MessageBox.Show("Güncellenecek pizzayı seçiniz.");
            }
            else
            {
                pizzaGuncellemeMi = true;
                Pizza p = (Pizza)lstPizzalar.SelectedItem;
                txtPizzaAd.Text = p.Ad;
                foreach (var item in p.Malzeme)
                {
                    lstMalzemeler.Items.Add(item);
                }
                nmudFiyat.Value = p.Fiyat;

            }
        }

        private void btnPizzaSil_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek filmi seçiniz.");
            }
            else
            {
                DialogResult res = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int seciliIndex = lstPizzalar.SelectedIndex;
                    pizzaDetay.RemoveAt(seciliIndex);
                    PizzaListboxDoldur();
                    PizzaTuruComboboxDoldur();
                }
                else if (res == DialogResult.No)
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }

            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.Musteri = (Musteri)cmbMusteri.SelectedItem;
            s.Pizza = (Pizza)cmbPizzaTuru.SelectedItem;
            s.Adet = nmupAdet.Value;

            string detayliSiparis = "";
            Pizza p = (Pizza)cmbPizzaTuru.SelectedItem;
            MalzemeCikar();
            foreach (var item in p.Malzeme)
            {
                detayliSiparis += item.ToString() + ", ";
            }
            lstSepet.Items.Add(s + ", " + detayliSiparis.Substring(0, detayliSiparis.Length - 2));
            SiparisTemizleme();
        }

        private void cmbPizzaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMalzemeler.Controls.Clear();
            Pizza p = (Pizza)cmbPizzaTuru.SelectedItem;

            foreach (var item in p.Malzeme)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.ToString();
                flpMalzemeler.Controls.Add(checkBox);
            }
        }

        void MalzemeCikar()
        {
            Pizza p = (Pizza)cmbPizzaTuru.SelectedItem;
            foreach (CheckBox item in flpMalzemeler.Controls)
            {
                if (((CheckBox)item).Checked == true)
                {
                    p.Malzeme.Remove(item.Text);
                }
            }
        }
    }
}
