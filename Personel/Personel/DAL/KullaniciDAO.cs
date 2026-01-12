using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.Domain;

namespace Personel.DAL
{
    public class KullaniciDAO
    {
        public Personel.Domain.Kullanici girisYap(string ad, string sifre)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            string sorgu = "select * from kullanicilar where kadi='" + ad + "' and sifre='" + sifre + "'";
            MySqlDataReader okunan = (new MySqlCommand(sorgu, baglanti)).ExecuteReader();

            if (okunan.Read())
            {
                Personel.Domain.Kullanici k = new Personel.Domain.Kullanici();
                k.Id = Convert.ToInt32(okunan["id"]);
                k.Kadi = okunan["kadi"].ToString();
                k.Rol = okunan["rol"].ToString();

                baglanti.Close();
                return k;
            }

            baglanti.Close();
            return null;
        }
    }
}