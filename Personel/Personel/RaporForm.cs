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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            lstSonuclar.Items.Clear();
            MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            bag.Open();

            int secim = cmbRaporlar.SelectedIndex;

            string sorgu = "SELECT adSoyad, maas, performans, departmanId FROM personel";
            MySqlCommand komut = new MySqlCommand(sorgu, bag);
            MySqlDataReader oku = komut.ExecuteReader();

            double toplamMaas = 0;
            int personelSayisi = 0;
            int enYuksekPuan = -1;
            int enDusukPuan = 101;
            string enIyiSigma = "";
            string enKotisSigma = "";

            while (oku.Read())
            {
                string ad = oku["adSoyad"].ToString();
                int maas = Convert.ToInt32(oku["maas"]);
                int puan = Convert.ToInt32(oku["performans"]);

                toplamMaas += maas;
                personelSayisi++;

                if (puan > enYuksekPuan) { enYuksekPuan = puan; enIyiSigma = ad; }
                if (puan < enDusukPuan) { enDusukPuan = puan; enKotisSigma = ad; }

            }
            oku.Close();

            if (secim == 0)
            {
                sorgu = "SELECT d.departmanAdı, COUNT(*) as sayi " + "FROM personel p, departman d " + "WHERE p.departmanId = d.departmanId " + "GROUP BY d.departmanAdı";

                komut = new MySqlCommand(sorgu, bag);
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    string dAdi = oku["departmanAdı"].ToString();
                    string sayi = oku["sayi"].ToString();

                    lstSonuclar.Items.Add($"{dAdi}: departmanında {sayi} adet personel bulunmaktadır.");
                }
                oku.Close();
            }

            else if (secim == 1)
            {
                string basTar = dtpBas.Value.ToString("yyyy-MM-dd");
                string bitTar = dtpBit.Value.ToString("yyyy-MM-dd");

                sorgu = "SELECT personelId, Baslangic, Bitis FROM izinler";
                komut = new MySqlCommand(sorgu, bag);
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    lstSonuclar.Items.Add($"Personel ID: {oku["personelId"]} | {oku["Baslangic"]} - {oku["Bitis"]} arası izinli.");
                }
                oku.Close();
            }

            else if (secim == 2)
            {
                double ortalama = toplamMaas / personelSayisi;
                lstSonuclar.Items.Add($"Toplam Maaş Yükü: {toplamMaas} TL");
                lstSonuclar.Items.Add($"Ortalama Maaş: {ortalama:F2} TL");
            }
            else if (secim == 3)
            {
                lstSonuclar.Items.Add($"En Etkili Eleman: {enIyiSigma} ({enYuksekPuan})");
                lstSonuclar.Items.Add($"En Etkisiz Eleman: {enKotisSigma} ({enDusukPuan})");
            }

            else if (secim == 4)
            {
                sorgu = "SELECT adSoyad, kullanilanIzin FROM personel";
                komut = new MySqlCommand(sorgu, bag);
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    int kullanilan = Convert.ToInt32(oku["kullanilanIzin"]);
                    int kalan = 14 - kullanilan;

                    string durum = kalan > 0 ? $"Kalan: {kalan} gün" : "İzin Hakkı Bitti";
                    lstSonuclar.Items.Add($"{oku["adSoyad"]} | {durum}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen rapor türünü seçiniz.");
            }
                bag.Close();
        }
    }
}
