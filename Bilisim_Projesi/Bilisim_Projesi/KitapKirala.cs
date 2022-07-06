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
   
    public partial class KitapKirala : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        DataTable liste = new DataTable();
        public KitapKirala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into KitapKiralama(ogrencino,adi,soyadi,telefon,adres,kitapno,kitapadi,kitapyazari,yayinevi,sayfasayisi,verilistarihi,teslimtarihi)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Başarıyla Kiralandı");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Kitap Zaten Daha Önceden Kiralanmış!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select*from Kitap where kitapno like '" + textBox4.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox6.Text = okuyucu["kitapadi"].ToString();
                textBox8.Text = okuyucu["kitapyazari"].ToString();
                textBox9.Text = okuyucu["yayinevi"].ToString();
                textBox7.Text = okuyucu["sayfasayisi"].ToString();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {      
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox1.Focus();
        }
    }
}
