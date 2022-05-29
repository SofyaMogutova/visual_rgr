using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Visual.Models
{
    public partial class Horse : Table
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

        public virtual Trainer? TrainerNavigation { get; set; }
        public virtual Owner OwnerNavigation { get; set; } = null!;
        public object? this[string property]
        {
            get
            {
                switch (property)
                {
                    case "Name": return Nickname;
                    case "Age": return Age;
                    case "Gender": return Gender;
                    case "Trainer": return FIOTrainer;
                    case "Owner": return FIOOwner;
                }
                return null;
            }
        }

        public bool Equals(Horse? other)
        {
            return (this.Nickname == other.Nickname);
        }
        public static string[] GetAttr()
        {
            return new[] { "Horse: Nickname", "Horse: Age", "Horse: Gender", "Horse: FIOTrainer", "Horse: FIOOwner" };
        }

    }
}
