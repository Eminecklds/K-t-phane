using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class GirisKontrol
    {
        private string kullaniciAdi;
        private string kullaniciParola;
        private string yetkiliAdi;
        private string yetkiliParola;
        public string KullaniciAdi { get { return kullaniciAdi; } set { kullaniciAdi = value; } }
        public string KullaniciParola { get { return kullaniciParola; } set { kullaniciParola = value; } }
        public string YetkiliAdi { get { return yetkiliAdi; } set { yetkiliAdi = value; } }
        public string YetkiliParola { get { return yetkiliParola; } set { yetkiliParola = value; } }


    }
}
