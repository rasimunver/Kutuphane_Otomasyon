using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilisim_Projesi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void kitapİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ogrenci = new OgrenciEkle();
            Ogrenci.Show();

        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form osil = new OgrenciSil();
            osil.Show();

        }

        private void öğrebciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form oduzenle = new OgrenciDuzenle();
            oduzenle.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kekle = new KitakEkle();
            kekle.Show();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ksil = new KitapSil();
            ksil.Show();
        }

        private void kitapDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kduzenle = new KitapDüzenle();
            kduzenle.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ogoster = new OgrenciGoster();
            ogoster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form kgoster = new KitapGöster();
            kgoster.Show();
        }

        private void kitapKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kkirala = new KitapKirala();
            kkirala.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form kiragoster = new KiralananlarıGoster();
            kiragoster.Show();
        }

        private void geçKalanKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form geckalangoster = new GecKalanKitaplar();
            geckalangoster.Show();
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form teslimal = new teslimal();
            teslimal.Show();
        }     
    }
}
