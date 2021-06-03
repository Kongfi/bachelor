using System;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Database.Entities
{
    public class HorseEntity : BaseEntity
    {
        public HorseEntity()
        {
        }
        public HorseEntity(string feifID, string name, string from, string stable, HorseGenderEnum gender, int userid)
        {
            FeifID = feifID;
            Name = name;
            From = from;
            Stable = stable;
            Gender = gender;
            UserID = userid;
        }

        // DKåååå1xxxxx for danske hingste og DKåååå2xxxxx for danske hopper
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

        [Required]
        public int UserID { get; set; }

        // Navigation property der sammenkæder User og Horse
        public UserEntity User { get; set; }
    }
}
