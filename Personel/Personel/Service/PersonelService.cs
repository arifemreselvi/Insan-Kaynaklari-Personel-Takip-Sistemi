using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Service
{
    class PersonelService
    {
        public ArrayList personelleriGetir()
        {
            return (new Personel.DAL.PersonelDAO()).personelleriGetir();
        }
        public void personelKaydet(string ad, int maas, int depId)
        {
            Personel.Domain.Personel p = new Personel.Domain.Personel(ad, maas, depId);
            (new Personel.DAL.PersonelDAO()).kaydet(p);
        }
        public void personelSil(int id)
        {
            (new Personel.DAL.PersonelDAO()).sil(id);
        }
        public void personelGuncelle(int id, string ad, int maas, int depId)
        {
            Personel.Domain.Personel p = new Personel.Domain.Personel(ad, maas, depId);
            p.PersonelId = id;
            (new Personel.DAL.PersonelDAO()).guncelle(p);
        }
        public void personelMaasGuncelle(int id, int maas)
        {
            (new Personel.DAL.PersonelDAO()).maasGuncelle(id, maas);
        }
    }
}
