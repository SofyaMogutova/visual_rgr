using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Jockey
    {
        public string FIO { get; set; } = null!;
        public string Rank { get; set; } = null!;
        public static string[] GetAttr()
        {
            return new[] { "Jockey: FIO", "Jockey: Rank" };
        }
        public object? this[string property]
        {
            get
            {
                switch (property)
                {
                    case "FIO": return FIO;
                    case "Rank": return Rank;
                }
                return null;
            }
        }
    }
}
