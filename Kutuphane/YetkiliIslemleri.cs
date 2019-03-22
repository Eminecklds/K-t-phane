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
    public partial class YetkiliIslemleri : Form
    {
        public YetkiliIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri k = new KullaniciBilgileri();
            k.Show();
            this.Hide();
        }

        private void YetkiliIslemleri_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            KitapSec sec = new KitapSec();
            sec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapEkle ekle = new KitapEkle();
            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapListeleYetkili lit = new KitapListeleYetkili();
            lit.Show();
            this.Hide();
        }
    }
}
