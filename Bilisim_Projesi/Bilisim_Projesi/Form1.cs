using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Bilisim_Projesi
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifrenizi Giriniz");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre Boş Bırakılamaz");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz");
            }
            else

            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from KullanıcıGirisi where k_adi='" + textBox1.Text.ToString() + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text.ToString() == okuyucu["k_adi"].ToString() && textBox2.Text.ToString() == okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldiniz Sayın" + " " + okuyucu["ad"].ToString() + " " + okuyucu["soyad"].ToString());
                        Form menu = new menu();
                        menu.Show();
                        this.Hide();
                        baglanti.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlıştır");
                    this.Close();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

