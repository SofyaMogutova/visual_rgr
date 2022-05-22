using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            Horses = new HashSet<Horse>();
            FIO = "";
            Rank = "";
        }
        public string FIO { get; set; } = null!;
        public string Rank { get; set; } = null!;

        public virtual ICollection<Horse> Horses { get; set; }
    }
}
