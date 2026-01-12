using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Domain
{
    public class Izin
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string Baslangic { get; set; }
        public string Bitis { get; set; }
        public string Aciklama { get; set; }
        public override string ToString()
        {
            return this.Baslangic + " - " + this.Bitis + " | " + this.Aciklama;
        }
    }
}
