using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DESKTOP.Classes
{
    public class Iletisim
    {
        public int Id { get; set; }
        public int RehberId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public byte IletisimTuru { get; set; }
        public string IAciklama { get; set; }

        public virtual RehberInfo RehberInfo { get; set; }
    }
}
