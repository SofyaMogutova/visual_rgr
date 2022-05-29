using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Racetrack
    {
        public Racetrack()
        {
            Runs = new HashSet<Run>();
            Title = "";
        }
        public string Title { get; set; } = null!;

        public virtual ICollection<Run> Runs { get; set; }
        public static string GetAttr()
        {
            return "Racetrack: Title";
        }
        public object? this[string property]
        {
            get
            {
                switch (property)
                {
                    case "Title": return Title;
                }
                return null;
            }
        }
    }
}
