using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Bilgiler:GirisKontrol
    {
        public string k1 = "kullanici1";
        public string k1p = "123";
        public string y1 = "yetkili1";
        public string y1p = "123";

        public string[] kitap = {"Sineklerin Tanrısı","Willian Golding","İş Bankası","2001","Roman","S-W50","Rafta","İntibah","Namık Kemal","Say Yayınlar","2003","Roman","A-N320","10 Gün"};
        public string[] kullanici = { "11111111111", "Ali", "Asd","İstanbul","5555555555", "kullanici1@gmail.com","İstanbul","Erkek","123" };
        public DateTime dt = DateTime.Now.AddYears(-25);   
        public DateTime ut = DateTime.Now.AddYears(-1);

            }
}
