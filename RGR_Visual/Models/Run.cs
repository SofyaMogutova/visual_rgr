using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Run
    {
        public Run()
        {
            Number = 0;
            Date = "";
            Distance = "";
            TitleRacetrack = "";
            
        }
        public long Number { get; set; }
        public string Date { get; set; } = null!;
        public string? Distance { get; set; }
        public string TitleRacetrack { get; set; } = null!;
        
        public virtual Racetrack RacetrackNavigation { get; set; } = null!;

    }
}
