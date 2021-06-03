using API.Domain.Services;
using API.Infrastructure.Database;
using API.Infrastructure.Database.Entities;
using API.Models;
using API.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AuthorizationSettings _authSettings;
        private readonly IUserService _userService;

        public UsersController(
            IOptions<AuthorizationSettings> authSettings,
            IUserService userService)
        {
            _authSettings = authSettings.Value;
            _userService = userService;
        }

        [HttpPost(Name = nameof(CreateUser))]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult<UserResponse>> CreateUser([FromBody] CreateUserRequest body)
        {
            var mappedUser = body.MapToEntityModel();
            var createdUser = await _userService.CreateUser(mappedUser, body.Password);
            return Created("", new UserResponse(createdUser));
        }

        [HttpPost("login", Name = nameof(Login))]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TokenResponse>> Login([FromBody] LoginRequest body)
        {
            var user = await _userService.Login(body.Email, body.Password);
            var token = GenerateJwtToken(user);
            return Ok(new TokenResponse(token));
        }

        private string GenerateJwtToken(UserEntity user) 
        {
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authSettings.JwtKey));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _authSettings.Issuer,
                Audience = _authSettings.Audience,
                Claims = new Dictionary<string, object>(){
                    {"UserID", user.Id }
                },
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddSeconds(_authSettings.ExpirationInSeconds),
                SigningCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
