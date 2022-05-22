using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Horses = new HashSet<Horse>();
            FIO = "";
        }
        public string FIO { get; set; } = null!;

        public virtual ICollection<Horse> Horses { get; set; }
    }
}
