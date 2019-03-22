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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YetkiliIslemleri yt = new YetkiliIslemleri();
            yt.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            kitap_ekle k = new kitap_ekle();
            k.yazaradsoyad = textBox4.Text;
            k.yayinevi = textBox2.Text;
            k.kitapyili = Convert.ToString(dateTimePicker1.Value);
            k.kitapadi = textBox1.Text;
            k.kitapturu = comboBox1.Text;
            k.kitabınyeri = comboBox2.Text;

            dataGridView1.Rows.Add(k.kitapadi, k.yazaradsoyad, k.yayinevi, k.kitapturu, k.kitapyili, k.kitabınyeri);

            temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {

            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.Text = null;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows != null)
            {
                Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(
        DataGridViewElementStates.Selected);
                if (rowToDelete > -1)
                {
                    this.dataGridView1.Rows.RemoveAt(rowToDelete);
                }
            }

            kitap_ekle k = new kitap_ekle();
            k.yazaradsoyad = textBox4.Text;
            k.yayinevi = textBox2.Text;
            k.kitapyili = Convert.ToString(dateTimePicker1.Value);
            k.kitapadi = textBox1.Text;
            k.kitapturu = comboBox1.Text;
            k.kitabınyeri = comboBox2.Text;

            dataGridView1.Rows.Add(k.kitapadi, k.yazaradsoyad, k.yayinevi, k.kitapturu, k.kitapyili, k.kitabınyeri);

            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows != null)
            
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(
            DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        this.dataGridView1.Rows.RemoveAt(rowToDelete);
                    }
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                textBox1.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                textBox2.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[2].Value);
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value);
                textBox4.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[1].Value);
                comboBox1.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[3].Value);
                comboBox2.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[5].Value);


                Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(
        DataGridViewElementStates.Selected);
            }
        }
    }
}
