using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Database.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(string firstName, string lastName, UserGenderEnum gender, int zipCode, string city, string country, string email, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Email = email;
            Phone = phone;
        }

        public UserEntity()
        {

        }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public UserGenderEnum Gender { get; set; }

        [Required]
        [Range(4, 4)]
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
        [StringLength(100, MinimumLength = 1)]
        public int Phone { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }

        public IEnumerable<HorseEntity> Horses { get; set; }
    }

    public enum UserGenderEnum
    {
        Male,
        Female
    }
}
