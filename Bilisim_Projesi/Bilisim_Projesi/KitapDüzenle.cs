using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bilisim_Projesi
{
    public partial class KitapDüzenle : Form
    {       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        public KitapDüzenle()
        {
            InitializeComponent();
        }

        private void KitapDüzenle_Load(object sender, EventArgs e)
        {
            textBox5.Focus();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitap set kitapno='" + textBox5.Text + "', kitapadi='" + textBox1.Text + "', kitapyazari='" + textBox2.Text + "', yayinevi='" + textBox3.Text + "',sayfasayisi='" + textBox4.Text + "' where kitapno='" + textBox5.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap Bİlgileri Başarıyla Güncellendi");
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select*from Kitap where kitapno like '" + textBox5.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox1.Text = okuyucu["kitapadi"].ToString();
                textBox2.Text = okuyucu["kitapyazari"].ToString();
                textBox3.Text = okuyucu["yayinevi"].ToString();
                textBox4.Text = okuyucu["sayfasayisi"].ToString();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox5.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzenlemek İstediğniniz Kitap Numarasını Giriniz Diğer Bilgiler Otomatik Olarak Doldurulacaktır.");
        }
    }
}
