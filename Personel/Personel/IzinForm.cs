using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class IzinForm : Form
    {
        public IzinForm()
        {
            InitializeComponent();
        }
        public int aktifPersonelId; 
        public string aktifRol;
        private void IzinForm_Load(object sender, EventArgs e)
        {
            cmbPersoneller.Items.Clear();
            var personelListesi = (new Service.PersonelService()).personelleriGetir();

            foreach (var p in personelListesi)
            {
                cmbPersoneller.Items.Add(p);
            }

            if (this.aktifRol.ToLower() == "normal")
            {
                izinListBox.Visible = false;
                btnOnayla.Visible = false;
                btnReddet.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            else
            {
                izinListBox.Visible = true;
                btnOnayla.Visible = true;
                btnReddet.Visible = true;
                izinleriListele();
            }

            izinleriListele();
        }

        private void btnIzinKaydet_Click(object sender, EventArgs e)
        {
            DateTime bas = dtpBaslangic.Value;
            DateTime bit = dtpBitis.Value;
            int gunSayisi = (bit - bas).Days;

            if (gunSayisi < 0)
            {
                MessageBox.Show("Tarih seçiminde yanlışlık bulunmaktadır.");
                return;
            }

            else if (gunSayisi > 14)
            {
                MessageBox.Show("Yöneticiye danışılmadan 14 günden fazla izin alma işlemi sistem üzerinden yapılamamaktadır.");
                return;
            }

            else if (cmbPersoneller.SelectedItem != null)
            {
                Personel.Domain.Personel seciliP = (Personel.Domain.Personel)cmbPersoneller.SelectedItem;
                int pId = seciliP.PersonelId;

                (new Service.IzinService()).izinEkle(pId, bas.ToShortDateString(), bit.ToShortDateString(), txtAciklama.Text);
                MessageBox.Show("İzin talebi başarıyla sisteme eklendi.");
                izinleriListele();
            }
            else if (txtAciklama.Text.Length < 5)
            {
                MessageBox.Show("Lütfen açıklama yerini yeterince doldurunuz.");
                return;
            }
            else
            {
                MessageBox.Show("Verdiğiniz bilgilerde eksik bulunmaktadır.");
                return;
            }
        }
        public void izinleriListele()
        {
            izinListBox.Items.Clear();
            ArrayList liste = (new Personel.DAL.IzinDAO()).izinleriGetir(aktifPersonelId, aktifRol);

            foreach (Personel.Domain.Izin i in liste)
            {
                izinListBox.Items.Add(i);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (izinListBox.SelectedItem != null)
            {
                Personel.Domain.Izin secili = (Personel.Domain.Izin)izinListBox.SelectedItem;

                DateTime bas = Convert.ToDateTime(secili.Baslangic);
                DateTime bit = Convert.ToDateTime(secili.Bitis);
                int gun = (bit - bas).Days;

                MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
                bag.Open();

                string silSorgu = "DELETE FROM izinler WHERE id = " + secili.Id;
                new MySqlCommand(silSorgu, bag).ExecuteNonQuery();

                string updateSorgu = "UPDATE personel SET performans = performans - " + gun + ", kullanilanIzin = kullanilanIzin + " + gun + " WHERE personelId = " + secili.PersonelId;
                new MySqlCommand(updateSorgu, bag).ExecuteNonQuery();

                bag.Close();
                MessageBox.Show("İzin başarıyla onaylandı.");
                izinleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak istediğiniz talebi listeden seçiniz.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (izinListBox.SelectedItem != null)
            {
                Personel.Domain.Izin secili = (Personel.Domain.Izin)izinListBox.SelectedItem;

                MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
                bag.Open();

                string sorgu = "DELETE FROM izinler WHERE id = " + secili.Id;
                new MySqlCommand(sorgu, bag).ExecuteNonQuery();

                bag.Close();
                MessageBox.Show("İzin başarıyla reddedildi.");
                izinleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek istediğiniz talebi listeden seçiniz.");
            }
        }
    }
}
