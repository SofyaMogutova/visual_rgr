using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Horse
    {
        public Horse()
        {
            Nickname = "";
            Age = 0;
            Gender = "";
            FIOTrainer = "";
            FIOOwner = "";
            OwnerNavigation = null!;
            TrainerNavigation = null;
        }
        public string? Nickname { get; set; } = null!;
        public long? Age { get; set; }
        public string? Gender { get; set; } = null!;
        public string? FIOTrainer { get; set; } = null!;
        public string? FIOOwner { get; set; } = null!;

        public virtual Trainer? TrainerNavigation { get; set; } = null!;
        public virtual Owner OwnerNavigation { get; set; } = null!;

    }
}
