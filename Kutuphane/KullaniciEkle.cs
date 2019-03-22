using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class KullaniciEkle
    {
        private string TC;
        private string Ad;
        private string Soyad;
        private string DogumYeri;
        public DateTime dogumtarihi { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string cinsiyet { get; set; }
        public DateTime uyeliktarihi { get; set; }
        public string adres { get; set; }

        public string sifre { get; set; }



        public string tc
        {
            get { return TC; }
            set
            {

                    TC = value;

            }
        }


        public string ad
        {
            get { return Ad; }
            set { Ad = value.ToUpper(); }
        }

        public string soyad
        {
            get { return Soyad; }
            set { Soyad = value.ToUpper(); }
        }
        public string dogumyeri
        {
            get { return DogumYeri; }
            set { DogumYeri = value.ToUpper(); }
        }
    }
}
