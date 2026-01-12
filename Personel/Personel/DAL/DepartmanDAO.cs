using MySql.Data.MySqlClient;
using Personel.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.DAL
{
    class DepartmanDAO
    {
        public ArrayList departmanlarGetir()
        {
            ArrayList liste = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("select * from departman", baglanti);
            MySqlDataReader okunanlar = komut.ExecuteReader();

            while (okunanlar.Read())
            {
                Departman d = new Departman();
                d.DepartmanId = Convert.ToInt32(okunanlar[0]);
                d.Adi = okunanlar[1].ToString();
                d.Iletisim = okunanlar[2].ToString();
                d.Kat = Convert.ToInt32(okunanlar[3]);
                liste.Add(d);
            }
            baglanti.Close();
            return liste;
        }
        public void kaydet(Departman d)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();
            string sorgu = "insert into departman (departmanAdı, deaparmanİletisim, deparmanKatı) values ('" + d.Adi + "','" + d.Iletisim + "'," + d.Kat + ")";
            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public void sil(int id)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            string sorgu = "delete from departman where departmanId = " + id;

            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
        public void guncelle(Departman d)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430015;User ID=26_132430015;Password=İnif123.;");
            baglanti.Open();

            string sorgu = "update departman set departmanAdı='" + d.Adi + "', deaparmanİletisim='" + d.Iletisim + "', deparmanKatı=" + d.Kat + " where departmanId=" + d.DepartmanId;

            (new MySqlCommand(sorgu, baglanti)).ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
