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
    public partial class GecKalanKitaplar : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        public GecKalanKitaplar()
        {
            InitializeComponent();
        }

        private void GecKalanKitaplar_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToShortDateString();
            baglanti.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select*from KitapKiralama where teslimtarihi <'" + tarih + "'", baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
