using API.Infrastructure.Database.Entities;
using System;

namespace API.Models.Users
{
    public class UserResponse : UserBase
    {
        public UserResponse(UserEntity userEntity) 
        {
            FirstName = userEntity.FirstName;
            LastName = userEntity.LastName;
            Gender = userEntity.Gender;
            ZipCode = userEntity.ZipCode;
            City = userEntity.City;
            Country = userEntity.Country;
            Email = userEntity.Email;
            Phone = userEntity.Phone;
            ID = userEntity.Id;
        }
        public int ID { get; set; }
    }
}
