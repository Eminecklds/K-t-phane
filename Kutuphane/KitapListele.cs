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
    public partial class KitapListele : Form
    {
        public KitapListele()
        {
            InitializeComponent();
        }

        private void KitapListele_Load(object sender, EventArgs e)
        {
            Bilgiler kitap = new Bilgiler();
            string[] kitaplar = new string[14];
            for (int i = 0; i < 14; i++)
            {

                kitaplar[0] = kitap.kitap[i];
                kitaplar[1] = kitap.kitap[i + 1];
                kitaplar[2] = kitap.kitap[i + 2];
                kitaplar[3] = kitap.kitap[i + 3];
                kitaplar[4] = kitap.kitap[i + 4];
                kitaplar[5] = kitap.kitap[i + 5];
                kitaplar[6] = kitap.kitap[i + 6];
                i += 6;
                listView1.Items.Add(new ListViewItem(kitaplar));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kul = new KullaniciIslemleri();
            kul.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitapAdi = textBox1.Text;
            Bilgiler ara = new Bilgiler();
            string[] snc = new string[7];
            for (int i = 0; i < ara.kitap.Length; i++)
            {

                if (ara.kitap[i].ToUpper() == kitapAdi.ToUpper())
                {
                    int b = 0;
                    for (int a = i; a < i+7; a++)
                    {
                        snc[b] = ara.kitap[a];
                        b++;
                    }
                    break;
                }
            }
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem(snc));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kul = new KullaniciIslemleri();
            kul.Show();
            this.Hide();
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
    }
}
