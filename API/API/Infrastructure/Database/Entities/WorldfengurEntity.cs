using System;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Database.Entities
{
    public class WorldfengurEntity : BaseEntity
    {
        public WorldfengurEntity()
        {
        }
        public WorldfengurEntity(string feifID, string name, string from, string stable, HorseGenderEnum gender, int userid)
        {
            FeifID = feifID;
            Name = name;
            From = from;
            Stable = stable;
            Gender = gender;
        }

        // DKееее1xxxxx for hingste og DKееее2xxxxx for hopper
        [Required]
        [StringLength(12, MinimumLength = 12)]
        public string FeifID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string From { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Stable { get; set; }

        [Required]
        public HorseGenderEnum Gender { get; set; }

    }
}
