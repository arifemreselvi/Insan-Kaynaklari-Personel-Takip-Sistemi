using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Domain
{
    public class SifreTalep
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string YeniSifre { get; set; }
        public string Kadi { get; set; }
        public override string ToString()
        {
            return "No: " + Id + " | Kullanıcı Adı: " + Kadi + " | Yeni Şifre: " + YeniSifre;
        }
    }
}
