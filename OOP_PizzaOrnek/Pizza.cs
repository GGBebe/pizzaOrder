using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PizzaOrnek
{
    class Pizza
    {
        private string _ad;
        private ArrayList _malzeme;
        private decimal _fiyat;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public ArrayList Malzeme
        {
            get { return _malzeme; }
            set { _malzeme = value; }
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public override string ToString()
        {
            return Ad;
        }
    }
}
