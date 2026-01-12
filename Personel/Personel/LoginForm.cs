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

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKadi.Text == "")
            {
                MessageBox.Show("Verilen bilgilerde eksiklik bulunmaktadır.");
                return;
            }
            else if(txtSifre.Text == "")
            {
                MessageBox.Show("Verilen bilgilerde eksiklik bulunmaktadır.");
                return;
            }
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            string sorgu = "SELECT * FROM kullanicilar WHERE kadi='" + txtKadi.Text + "' AND sifre='" + txtSifre.Text + "'";

            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader okunan = komut.ExecuteReader();

            if (okunan.Read())
            {
                int kullaniciId = Convert.ToInt32(okunan["id"]);
                string rol = okunan["rol"].ToString();
                string ad = okunan["kadi"].ToString();
                MessageBox.Show("Giriş başarılı! Rolünüz: " + rol);
                AnaForm ana = new AnaForm(rol, ad, kullaniciId);
                ana.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Bilgiler hatalı, tekrar deneyin.");
            }

            baglanti.Close();
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void LblUnut_Click(object sender, EventArgs e)
        {
            SifreTalepForm stf = new SifreTalepForm();
            stf.Show();
        }

        private void LblKayit_Click(object sender, EventArgs e)
        {
            KayitForm kayit = new KayitForm();
            kayit.Show();
        }
    }
    public class Kullanici
    {
        int id;
        string kadi, sifre, rol;

        public int Id { get { return id; } set { id = value; } }
        public string Kadi { get { return kadi; } set { kadi = value; } }
        public string Sifre { get { return sifre; } set { sifre = value; } }
        public string Rol { get { return rol; } set { rol = value; } }
    }
}
