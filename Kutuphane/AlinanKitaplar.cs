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
    public partial class AlinanKitaplar : Form
    {
        public AlinanKitaplar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kul = new KullaniciIslemleri();
            kul.Show();
            this.Hide();
        }

        private void AlinanKitaplar_Load(object sender, EventArgs e)
        {
            Bilgiler kkitap = new Bilgiler();
            DateTime teslimtarrihi = DateTime.Now.AddDays(+10);
            string[] kitapbilgi = { kkitap.kitap[7], kkitap.kitap[8],teslimtarrihi.ToShortDateString(), kkitap.kitap[13] };
            listView1.Items.Add(new ListViewItem(kitapbilgi));
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
