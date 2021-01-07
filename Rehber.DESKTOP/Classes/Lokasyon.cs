using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DESKTOP.Classes
{
    public class Lokasyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lokasyon()
        {
            this.RehberInfo = new HashSet<RehberInfo>();
        }

        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string LAciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RehberInfo> RehberInfo { get; set; }
    }
}
