using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DESKTOP.Classes
{
    public class RehberInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RehberInfo()
        {
            this.Iletisim = new HashSet<Iletisim>();
        }

        public int Id { get; set; }
        public byte RehberKayitTuru { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DepartmanAdi { get; set; }
        public string Sirket { get; set; }
        public string SirketUnvani { get; set; }
        public string BirimAdi { get; set; }
        public string Gorevi { get; set; }
        public string Santiye { get; set; }
        public string RAciklama { get; set; }
        public int LokasId { get; set; }
        public string Yetkilisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iletisim> Iletisim { get; set; }
        public virtual Lokasyon Lokasyon { get; set; }
    }
}
