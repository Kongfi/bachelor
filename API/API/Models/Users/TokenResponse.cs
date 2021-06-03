using API.Infrastructure.Database.Entities;
using System;

namespace API.Models.Users
{
    public class TokenResponse
    {
        public TokenResponse(string token)
        {
            Token = token;
        }

        public string Token { get; set; }
    }
}
