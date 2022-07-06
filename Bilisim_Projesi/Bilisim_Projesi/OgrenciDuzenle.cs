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
    public partial class OgrenciDuzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        public OgrenciDuzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Ogrenci set ogrencino='" + textBox1.Text + "', adi='" + textBox2.Text + "', soyadi='" + textBox3.Text + "', telefon='" + maskedTextBox1.Text + "',adres='" + textBox5.Text + "' where ogrencino='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bİlgileri Başarıyla Güncellendi");
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select*from Ogrenci where ogrencino like '" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["adi"].ToString();
                textBox3.Text = okuyucu["soyadi"].ToString();
                maskedTextBox1.Text = okuyucu["telefon"].ToString();
                textBox5.Text = okuyucu["adres"].ToString();
            }
            baglanti.Close();
        }

        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzenlemek İstediğiniz Öğrenci Numarasını Giriniz Diğer Bilgiler Otomatik Olarak Doldurulacaktır.");
        }
    }
}
