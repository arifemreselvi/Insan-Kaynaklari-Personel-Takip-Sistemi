using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.Domain;

namespace Personel.DAL
{
    public class PersonelDAO
    {
        public void kaydet(Personel.Domain.Personel p)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "insert into personel (adSoyad, maas, departmanId) values ('" + p.AdSoyad + "'," + p.Maas + "," + p.DepartmanId + ")";
            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public ArrayList personelleriGetir()
        {
            ArrayList liste = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            MySqlDataReader okunanlar = (new MySqlCommand("select * from personel", baglanti)).ExecuteReader();

            while (okunanlar.Read())
            {
                Personel.Domain.Personel p = new Personel.Domain.Personel();
                p.PersonelId = Convert.ToInt32(okunanlar[0]);
                p.AdSoyad = okunanlar[1].ToString();
                p.Maas = Convert.ToInt32(okunanlar[2]);
                p.DepartmanId = Convert.ToInt32(okunanlar[3]);
                liste.Add(p);
            }
            baglanti.Close();
            return liste;
        }
        public void sil(int id)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "delete from personel where personelId = " + id;
            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public void guncelle(Personel.Domain.Personel p)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "update personel set adSoyad='" + p.AdSoyad + "', maas=" + p.Maas + ", departmanId=" + p.DepartmanId + " where personelId=" + p.PersonelId;
            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public string[] raporuGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "SELECT COUNT(*), SUM(maas) FROM personel";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            string[] sonuclar = new string[2];
            if (oku.Read())
            {
                sonuclar[0] = oku[0].ToString();
                sonuclar[1] = oku[1].ToString();
            }
            baglanti.Close();
            return sonuclar;
        }
        public void maasGuncelle(int id, int yeni)
        {
            MySqlConnection bag = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            bag.Open();
            string sorgu = "UPDATE personel SET maas=" + yeni + " WHERE personelId=" + id;
            (new MySqlCommand(sorgu, bag)).ExecuteNonQuery();
            bag.Close();
        }
    }
}
