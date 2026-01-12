using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.Domain;

namespace Personel.Domain
{
    public class Personel
    {
        public Personel() { }
        public Personel(string adSoyad, int maas, int departmanId)
        {
            this.AdSoyad = adSoyad;
            this.Maas = maas;
            this.DepartmanId = departmanId;
        }

        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public int Maas { get; set; }
        public int DepartmanId { get; set; }
        public override string ToString()
        {
            return this.AdSoyad + " - " + this.Maas + " TL";
        }
    }
}
