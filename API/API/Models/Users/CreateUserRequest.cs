using API.Infrastructure.Database.Entities;
using System;

namespace API.Models.Users
{
    public class CreateUserRequest : UserBase 
    {
        public UserEntity MapToEntityModel()
        {
            var entity = new UserEntity
            {
                FirstName = FirstName,
                LastName = LastName,
                Gender = Gender,
                ZipCode = ZipCode,
                City = City,
                Country = Country,
                Email = Email,
                Phone = Phone
            };

            return entity;
        }
        public string Password { get; set; }
    }
}
