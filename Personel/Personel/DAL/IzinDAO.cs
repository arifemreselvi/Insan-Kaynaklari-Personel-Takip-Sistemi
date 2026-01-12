using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.DAL
{
    public class IzinDAO
    {
        public void kaydet(Personel.Domain.Izin i)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "INSERT INTO izinler (personelId, baslangic, bitis, aciklama) VALUES (" + i.PersonelId + ", '" + i.Baslangic + "', '" + i.Bitis + "', '" + i.Aciklama + "')";
            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public ArrayList izinleriGetir(int pId, string rol)
        {
            ArrayList liste = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            string sorgu = (rol == "admin") ? "SELECT * FROM izinler" : "SELECT * FROM izinler WHERE personelId=" + pId;

            MySqlDataReader okunan = (new MySqlCommand(sorgu, baglanti)).ExecuteReader();

            while (okunan.Read())
            {
                Personel.Domain.Izin iz = new Personel.Domain.Izin();
                iz.Id = Convert.ToInt32(okunan["id"]);
                iz.PersonelId = Convert.ToInt32(okunan["personelId"]);
                iz.Baslangic = okunan["baslangic"].ToString();
                iz.Bitis = okunan["bitis"].ToString();
                iz.Aciklama = okunan["aciklama"].ToString();
                liste.Add(iz);
            }
            baglanti.Close();
            return liste;
        }
    }
}
