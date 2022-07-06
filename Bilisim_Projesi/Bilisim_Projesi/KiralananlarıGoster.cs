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
    public partial class KiralananlarıGoster : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Kutuphane1.accdb");
        DataTable liste = new DataTable();
        public KiralananlarıGoster()
        {
            InitializeComponent();
        }

        private void KiralananlarıGoster_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select*from KitapKiralama", baglanti);
            adapter.Fill(liste);
            dataGridView1.DataSource = liste;
            baglanti.Close();
        }
    }
}
