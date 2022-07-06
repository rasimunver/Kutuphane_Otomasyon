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
    public partial class OgrenciEkle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Ogrenci(ogrencino,adi,soyadi,telefon,adres)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+maskedTextBox1.Text+"','"+textBox5.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Başarı İle Kayıt Edildi");
            baglanti.Close();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
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
    }
}
