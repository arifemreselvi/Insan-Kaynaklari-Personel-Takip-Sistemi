using MySql.Data.MySqlClient;
using Personel.Domain;
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
    public partial class HesapYonetimiForm : Form
    {
        public HesapYonetimiForm()
        {
            InitializeComponent();
        }
        public void talepleriGetir()
        {
            lstTalepler.Items.Clear();
            MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            bag.Open();

            string sorgu = "SELECT * FROM sifre_talepleri";
            MySqlCommand komut = new MySqlCommand(sorgu, bag);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                SifreTalep talep = new SifreTalep();
                talep.Id = Convert.ToInt32(oku["id"]);
                talep.Kadi = oku["kadi"].ToString();
                talep.KullaniciId = Convert.ToInt32(oku["kullaniciId"]);
                talep.YeniSifre = oku["yeniSifre"].ToString();

                lstTalepler.Items.Add(talep);
            }
            bag.Close();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (lstTalepler.SelectedItem != null)
            {
                SifreTalep secili = (SifreTalep)lstTalepler.SelectedItem;

                MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
                bag.Open();

                string update = "UPDATE kullanicilar SET sifre='" + secili.YeniSifre + "' WHERE kadi='" + secili.Kadi + "'";
                new MySqlCommand(update, bag).ExecuteNonQuery();

                string delete = "DELETE FROM sifre_talepleri WHERE id=" + secili.Id;
                new MySqlCommand(delete, bag).ExecuteNonQuery();

                bag.Close();
                MessageBox.Show("Şifre başarıyla güncellendi.");
                talepleriGetir();
            }
            else
            {
                MessageBox.Show("Onaylamak istediğiniz talebi seçiniz.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (lstTalepler.SelectedItem != null)
            {
                SifreTalep secili = (SifreTalep)lstTalepler.SelectedItem;

                int silinecekId = secili.Id;

                MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
                bag.Open();

                string deleteSorgu = "DELETE FROM sifre_talepleri WHERE id=" + silinecekId;
                MySqlCommand deleteKomut = new MySqlCommand(deleteSorgu, bag);
                deleteKomut.ExecuteNonQuery();

                bag.Close();
                MessageBox.Show("Talep başarıyla reddedildi.");
                talepleriGetir();
            }
            else
            {
                MessageBox.Show("Reddetmek istediğiniz talebi seçiniz.");
            }
        }

        private void lstTalepler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HesapYonetimiForm_Load(object sender, EventArgs e)
        {
            talepleriGetir();
        }
    }
}
