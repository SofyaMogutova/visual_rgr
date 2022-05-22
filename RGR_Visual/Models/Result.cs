using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Result
    {
        public Result()
        {
            HorseNickname = "";
            FIOJockey = "";
            StartPosition = 0;
            FinishPosition = 0;
            Lag = "";
            DateRun = "";
            NumberRun = 0;
            TitleRacetrack = "";
            
        }

        public string? HorseNickname { get; set; }
        public string? FIOJockey { get; set; }
        public long? StartPosition { get; set; }
        public long? FinishPosition { get; set; }
        public string? Lag { get; set; }
        public string? DateRun { get; set; }
        public long? NumberRun { get; set; }
        public string? TitleRacetrack { get; set; }

        public virtual Horse? HorseNavigation { get; set; } = null!;
        public virtual Jockey? JockeyNavigation { get; set; } = null!;
        public virtual Run? RunNavigation { get; set; } = null!;


    }
}
