using API.Infrastructure.Database.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models.Users
{
    public class UserBase
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public UserGenderEnum Gender { get; set; }

        [Required]
        [Range(1000,9999)]
        public int ZipCode { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string City { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Country { get; set; }

        // TODO: Håndter emailvalidering
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }

        // TODO: Håndter telefonvalidering
        [Required]
        public int Phone { get; set; }
    }
}
