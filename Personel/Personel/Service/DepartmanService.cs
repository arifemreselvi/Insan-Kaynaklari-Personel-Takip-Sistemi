using MySql.Data.MySqlClient;
using Personel.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Service
{
    class DepartmanService
    {
        public ArrayList departmanlarGetir()
        {
            return (new DAL.DepartmanDAO()).departmanlarGetir();
        }

        public void departmanKaydet(string ad, string iletisim, int kat)
        {
            (new DAL.DepartmanDAO()).kaydet(new Departman(ad, iletisim, kat));
        }
        public void departmanSil(int id)
        {
            (new DAL.DepartmanDAO()).sil(id);
        }
        public void departmanGuncelle(int id, string ad, string iletisim, int kat)
        {
            Departman d = new Departman(ad, iletisim, kat);
            d.DepartmanId = id;
            (new DAL.DepartmanDAO()).guncelle(d);
        }
        public void personelSil(int id)
        {
            (new Personel.DAL.PersonelDAO()).sil(id);
        }
    }
}
