using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PizzaOrnek
{
    class Musteri
    {
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _adres;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
