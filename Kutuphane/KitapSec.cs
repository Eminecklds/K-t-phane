using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kutuphane.Enums;

namespace Kutuphane
{
    public partial class KitapSec : Form
    {
        public KitapSec()
        {
            InitializeComponent();
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
        int a ;
        private void KitapSec_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(YazarAdi));
            comboBox2.DataSource = Enum.GetValues(typeof(KitapAdi));
            DateTime teslimt = new DateTime();
            teslimt = DateTime.Now.AddMonths(+1);
            dateTimePicker2.Value = teslimt;
            a = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmanetKitap ek = new EmanetKitap();
            Bilgiler k = new Bilgiler();
            ek.YazarAdi = comboBox1.Text;
            ek.KitapAdi = comboBox2.Text;
            ek.alim = dateTimePicker1.Value;
            ek.teslim = dateTimePicker2.Value;
            ek.tc = textBox1.Text;
            if(Array.IndexOf(k.kullanici,ek.tc)==-1)
            {
                DialogResult result = MessageBox.Show("Kullanıcı üre değil önce üyelik işlemlerini yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DialogResult result = MessageBox.Show("Kitap Emanet verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listBox1.Items.Add(ek.YazarAdi + "-" + ek.KitapAdi );
                listBox1.Items.Add("Alım Tarihi="+ ek.alim.ToShortDateString()+" Teslim Tarihi="+ ek.teslim.ToShortDateString());
                listBox1.Items.Add("Alan Kişi Tc="+ek.tc);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliIslemleri yt = new YetkiliIslemleri();
            yt.Show();
            this.Hide();
        }
        void Temizle()
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.Text = "";

                }

                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if(item is TextBox)
                {
                    TextBox tx = (TextBox)item;
                    tx.Clear();
                }

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Temizle();
                listBox1.Items.Clear();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deger = comboBox2.SelectedIndex;
            if (deger != null)
                comboBox1.SelectedIndex = deger;
            a = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deger = comboBox1.SelectedIndex;
            if (a!=0 && comboBox1.SelectedIndex!=comboBox2.SelectedIndex)
                comboBox2.SelectedIndex = deger;
            a = 1;
        }
    }
}
