using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DESKTOP.Classes
{
    public partial class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Rol { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KAciklama { get; set; }
        public Nullable<System.Guid> UserKey { get; set; }
    }
}
