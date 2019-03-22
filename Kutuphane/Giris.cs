using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        GirisKontrol ilk = new GirisKontrol();
        List<GirisKontrol> KullaniciListesi = new List<GirisKontrol>();
        List<GirisKontrol> YetkiliListesi = new List<GirisKontrol>();
        int ilkgiris = 0;
        bool kdurum = false;
        private void Form1_Load(object sender, EventArgs e)
        {
        
            GirisKontrol k = new GirisKontrol();
            GirisKontrol y = new GirisKontrol();
            Bilgiler b = new Bilgiler();
            if (ilkgiris == 0)
            {

                k.KullaniciAdi = b.k1;
                k.KullaniciParola = b.k1p;
                y.YetkiliAdi = b.y1;
                y.YetkiliParola = b.y1p;
                KullaniciListesi.Add(k);
                YetkiliListesi.Add(y);
                ilkgiris = 1;
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisKontrol kullanici = new GirisKontrol();
            kullanici.KullaniciAdi = textBox1.Text;
            kullanici.KullaniciParola = textBox2.Text;
            int sayi = 0;
            foreach (GirisKontrol item in KullaniciListesi)
            {

                
                if ((item.KullaniciAdi == kullanici.KullaniciAdi) && (item.KullaniciParola == kullanici.KullaniciParola))
                {
                    kdurum = true;
                    KullaniciIslemleri kul = new KullaniciIslemleri();
                    kul.Show();
                    this.Hide();
         
                }
                sayi += 2;

            }
            if (kdurum == false)
            {
                MessageBox.Show("Kullanıcı Adınızı ve Parolanızı kontrol ediniz?", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisKontrol yetkili = new GirisKontrol();
            yetkili.YetkiliAdi = textBox3.Text;
            yetkili.YetkiliParola = textBox4.Text;
            foreach (GirisKontrol item in YetkiliListesi)
            {

               
                if ((item.YetkiliAdi == yetkili.YetkiliAdi) && (item.YetkiliParola == yetkili.YetkiliParola))
                {
                   
                    YetkiliIslemleri yet = new YetkiliIslemleri();
                    yet.Show();
                    kdurum = true;
                     this.Hide();
                }

            }
            if (kdurum == false)
            {
                MessageBox.Show("Kullanıcı Adınızı ve Parolanızı kontrol ediniz?", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
