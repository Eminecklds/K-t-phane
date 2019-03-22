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
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();
        }
        int sayac = 1;
        int ilk = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliIslemleri y = new YetkiliIslemleri();
            y.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Giris grs = new Giris();
                grs.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkle yenikayit = new KullaniciEkle();
            yenikayit.tc = txtTc.Text;
            if (yenikayit.tc.ToString().Length == 11)
            {
                KullaniciOlustur(yenikayit);

                ListViewItem lvi = ListViewOlustur(yenikayit);

                listView1.Items.Add(lvi);
                if(ilk!=0)
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti.");
                temizle();
                sayac++;
                label13.Text = sayac + ".Kayıt";
            }
            else
            {
                MessageBox.Show("Hatalı Tc Girişi");
            }
        }
        private KullaniciEkle KullaniciOlustur(KullaniciEkle k)
        {
            k.tc = txtTc.Text;
            k.ad = txtAd.Text;
            k.soyad = txtSoyad.Text;
            k.dogumyeri = comboBox1.Text;
            k.dogumtarihi = txtDogumT.Value;
            k.telefon = txtTelefon.Text;
            k.email = txtMail.Text;
            k.uyeliktarihi = txtUyelikT.Value;
            k.adres = txtAdres.Text;
            k.sifre = txtSifre.Text;
                 if (radioButton1.Checked)
                {
                    k.cinsiyet = "Erkek";
                }
                else if (radioButton2.Checked)
                {
                    k.cinsiyet = "Kadın";
                }
            return k;
        }
        private ListViewItem ListViewOlustur(KullaniciEkle k)
        {
            string[] bilgiler = { k.tc, k.ad, k.soyad, k.dogumyeri, k.dogumtarihi.ToShortDateString(), k.telefon, k.email + comboBox2.Text, k.cinsiyet, k.uyeliktarihi.ToShortDateString(), k.adres, k.sifre };

            ListViewItem lvi = new ListViewItem(bilgiler);
            lvi.Tag = k;
            return lvi;
        }
        void temizle()
        {

            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if (item is ComboBox)

                {
                    ComboBox cm = (ComboBox)item;
                    cm.Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mst = (MaskedTextBox)item;
                    mst.Clear();

                }

                else if (item is RichTextBox)
                {
                    RichTextBox rct = (RichTextBox)item;
                    rct.Clear();
                }


            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    secili = KullaniciOlustur(secili);
                    int index = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(index, ListViewOlustur(secili));


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayac--;
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    listView1.SelectedItems[0].Remove();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            temizle();
        }
        KullaniciEkle secili;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                secili = (KullaniciEkle)listView1.SelectedItems[0].Tag;
                txtTc.Text = secili.tc;
                txtAd.Text = secili.ad;
                txtSoyad.Text = secili.soyad;
                comboBox1.Text = secili.dogumyeri;
                txtDogumT.Value = secili.dogumtarihi;
                txtTelefon.Text = secili.telefon;
                txtMail.Text = secili.email;
                radioButton1.Text = secili.cinsiyet;
                radioButton2.Text = secili.cinsiyet;
                txtUyelikT.Value = secili.uyeliktarihi;
                txtAdres.Text = secili.adres;


            }
        }
        
        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            KullaniciEkle yenikayit = new KullaniciEkle();
            Bilgiler blg = new Bilgiler();
            yenikayit.tc = blg.kullanici[0];
            yenikayit.ad = blg.kullanici[1];
            yenikayit.soyad = blg.kullanici[2];
            yenikayit.dogumyeri = blg.kullanici[3];
            yenikayit.dogumtarihi = blg.dt; ;
            yenikayit.telefon = blg.kullanici[4];
            yenikayit.email = blg.kullanici[5];
            yenikayit.uyeliktarihi = blg.ut;
            yenikayit.adres = blg.kullanici[6];
            yenikayit.sifre = blg.kullanici[8];
            yenikayit.cinsiyet = blg.kullanici[7];     
            ListViewItem lvi = ListViewOlustur(yenikayit);
            listView1.Items.Add(lvi);
            temizle();
            sayac++;
            label13.Text = sayac + ".Kayıt";
            ilk++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
