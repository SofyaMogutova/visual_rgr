using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Jockey
    {
        public Jockey()
        {
            FIO = "";
            Rank = "";
        }
        public string FIO { get; set; } = null!;
        public string Rank { get; set; } = null!;
        
    }
}
