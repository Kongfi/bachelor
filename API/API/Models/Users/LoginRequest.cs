using API.Infrastructure.Database.Entities;
using System;

namespace API.Models.Users
{
    public class LoginRequest 
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
