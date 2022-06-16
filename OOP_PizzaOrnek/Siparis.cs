using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PizzaOrnek
{
    class Siparis
    {
        private decimal _adet;
        private Musteri _musteri;
        private Pizza _pizza;

        public decimal Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public Musteri Musteri //class olcak
        {
            get { return _musteri; }
            set { _musteri = value; }
        }

        public Pizza Pizza //class olcak
        {
            get { return _pizza; }
            set { _pizza = value; }
        }

        public override string ToString()
        {
            return "Müşteri: " + Musteri.Ad + " " + Musteri.Soyad + " " + Pizza.Ad + " Pizza " + Adet + " Adet " + Pizza.Fiyat * Adet + " TL";
        }
    }
}
