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
    public partial class AnaForm : Form
    {
        int girisYapanId;
        string rol;
        string kullaniciAdi;
        public AnaForm(string gelenRol, string gelenAd, int gelenId)
        {
            InitializeComponent();
            this.rol = gelenRol;
            this.kullaniciAdi = gelenAd;
            this.girisYapanId = gelenId;
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Yetkiniz: " + this.rol;
            lblKullanici.Text = this.kullaniciAdi;
            if (this.rol == "Normal")
            {
                btnPersonel.Visible = false;
                btnDepartman.Visible = false;
                btnRapor.Visible = false;
                btnHesap.Visible = false;
            }
            else if (this.rol == "İK")
            {
                btnDepartman.Visible = false;
                btnHesap.Visible = false;
                btnPersonelSahte.Visible = false;
                btnRaporSahte.Visible = false;
            }
            else if (this.rol == "admin")
            {
                btnHesapSahte.Visible = false;
                btnDepartmanSahte.Visible = false;
                btnPersonelSahte.Visible = false;
                btnRaporSahte.Visible = false;
            }
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanForm df = new DepartmanForm();
            df.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelForm pf = new PersonelForm();
            pf.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm rf = new RaporForm();
            rf.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            IzinForm iz = new IzinForm();
            iz.aktifRol = this.rol;
            iz.aktifPersonelId = this.girisYapanId;
            iz.Show();
        }
        private void btnHesap_Click(object sender, EventArgs e)
        {
            HesapYonetimiForm hesap = new HesapYonetimiForm();
            hesap.Show();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            PerformansForm performans = new PerformansForm();
            performans.Show();
        }

        private void btnDepartmanSahte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu panele ulaşmak için yeterli yetkiniz bulunmamaktadır.");
        }

        private void btnHesapSahte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu panele ulaşmak için yeterli yetkiniz bulunmamaktadır.");
        }

        private void btnPersonelSahte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu panele ulaşmak için yeterli yetkiniz bulunmamaktadır.");
        }

        private void btnRaporSahte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu panele ulaşmak için yeterli yetkiniz bulunmamaktadır.");
        }

        private void btnMaasSahte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu panele ulaşmak için yeterli yetkiniz bulunmamaktadır.");
        }
    }
}
