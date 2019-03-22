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
    public partial class KullaniciIslemleri : Form
    {

        public KullaniciIslemleri() {

            InitializeComponent();
            
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
           

          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Giris grs = new Giris();
                grs.Show();
                this.Hide(); 
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapListele kitap = new KitapListele();
            kitap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlinanKitaplar kisi = new AlinanKitaplar();
            kisi.Show();
            this.Hide();
        }
    }
}
