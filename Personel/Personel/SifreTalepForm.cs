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
    public partial class SifreTalepForm : Form
    {
        public SifreTalepForm()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "")
            {
                MessageBox.Show("Verilen bilgilerde eksiklik bulunmaktadır.");
                return;
            }
            else if (txtYeniSifre.Text == "")
                return;
            {
                MessageBox.Show("Verilen bilgilerde eksiklik bulunmaktadır.");
            }
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglan.Open();

            string kontrolSorgu = "SELECT id, sifre FROM kullanicilar WHERE kadi = '" + txtKadi.Text + "'";
            MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglan);
            MySqlDataReader oku = kontrolKomut.ExecuteReader();

            if (oku.Read())
            {
                int bulunanId = Convert.ToInt32(oku["id"]);
                string mevcutSifre = oku["sifre"].ToString();
                oku.Close();

                if (txtYeniSifre.Text == mevcutSifre)
                {
                    MessageBox.Show("Değiştirmek istediğiniz şifre mevcut şifreniz ile aynıdır.");
                    baglan.Close();
                    return;
                }

                string talepSorgu = "INSERT INTO sifre_talepleri (kullaniciId, kadi, yeniSifre) VALUES (" + bulunanId + ", '" + txtKadi.Text + "', '" + txtYeniSifre.Text + "')";
                MySqlCommand talepKomut = new MySqlCommand(talepSorgu, baglan);
                talepKomut.ExecuteNonQuery();

                MessageBox.Show("Şifre değişim talebi başarıyla iletildi.");
                this.Close();
            }
            else
            {
                oku.Close();
                MessageBox.Show("Kullanıcı sistemde bulunamadı.");
            }
            baglan.Close();
        }

        private void SifreTalepForm_Load(object sender, EventArgs e)
        {

        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
