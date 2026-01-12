using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Domain
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
    }
}
