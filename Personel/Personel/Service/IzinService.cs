using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Service
{
    public class IzinService
    {
        public void izinEkle(int pId, string bas, string bit, string aciklama)
        {
            Personel.Domain.Izin i = new Personel.Domain.Izin();
            i.PersonelId = pId;
            i.Baslangic = bas;
            i.Bitis = bit;
            i.Aciklama = aciklama;
            (new DAL.IzinDAO()).kaydet(i);
        }
    }
}
