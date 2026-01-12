using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class PerformansForm : Form
    {
        public PerformansForm()
        {
            InitializeComponent();
        }

        private void PerformansForm_Load(object sender, EventArgs e)
        {
            lstPerformans.Items.Clear();

            MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            bag.Open();

            string sorgu = "SELECT adSoyad, maas, performans, girisTarihi FROM personel";
            MySqlCommand komut = new MySqlCommand(sorgu, bag);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                DateTime giris = Convert.ToDateTime(oku["girisTarihi"]);

                int calistigiGun = (DateTime.Now - giris).Days;

                string ad = oku["adSoyad"].ToString();
                string maas = oku["maas"].ToString();
                string puan = oku["performans"].ToString();
    
                string satir = $"{ad} | Maaş: {maas} TL | Puan: {puan} | Kıdem: {calistigiGun} Gün";
                lstPerformans.Items.Add(satir);
            }
            bag.Close();
        }

        private void lstPerformans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
