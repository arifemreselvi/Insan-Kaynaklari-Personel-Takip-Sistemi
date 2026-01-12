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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "")
            {
                MessageBox.Show("Hesap bilgilerinizde eksik bulunmaktadır.");
                return;
            }

            else if (txtSifre.Text == "")
            {
                MessageBox.Show("Hesap bilgilerinizde eksik bulunmaktadır.");
                return;
            }
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglan.Open();

            string kontrolSorgu = "SELECT * FROM kullanicilar WHERE kadi = '" + txtKadi.Text + "'";
            MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglan);
            MySqlDataReader oku = kontrolKomut.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show("Bu kullanıcı adı bir başkası tarafından kullanılmaktadır.");
                oku.Close();
                baglan.Close();
                return;
            }
            oku.Close();

            string sorgu = "INSERT INTO kullanicilar (kadi, sifre, rol) VALUES ('" + txtKadi.Text + "', '" + txtSifre.Text + "', 'Normal')";
            MySqlCommand komut = new MySqlCommand(sorgu, baglan);
            komut.ExecuteNonQuery();

            baglan.Close();
            MessageBox.Show("Hesabınız sisteme başarıyla kaydedilmiştir.");
            this.Close();
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
