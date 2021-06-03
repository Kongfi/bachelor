using API.Domain.Exceptions;
using API.Infrastructure.Database;
using API.Infrastructure.Database.Entities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace API.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserEntity> CreateUser(UserEntity newUser, string password)
        {
            var hashedPassword = HashPassword(password);
            newUser.Password = hashedPassword.Hash;
            newUser.Salt = hashedPassword.Salt;
            await _dbContext.Users.AddAsync(newUser);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                if (e.InnerException is SqlException sqlEx &&
                    sqlEx.Number == 2601) // 2601 = unik værdi findes allerede
                    throw new ConflictException(ErrorCodes.Account.CREATEACCOUNT_EMAIL_ALREADY_EXIST);

                throw;
            }

            // TODO: Lav SMTP der sender velkomstmail til bruger
            return newUser;
        }

        public async Task<UserEntity> Login(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
                throw new NotFoundException(ErrorCodes.Account.LOGIN_EMAIL_DOESNT_EXIST);

            if (VerifyPassword(password, user.Salt, user.Password) == false)
                throw new BusinessRuleException(ErrorCodes.Account.LOGIN_PASSWORD_INVALID);

            return user;
        }
        private HashSalt HashPassword(string password)
        {
            byte[] salt = new byte[128 / 8]; // Generate a 128-bit salt using a secure PRNG
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashedpw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return new HashSalt(hashedpw, salt);
        }

        private bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword)
        {
            string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: enteredPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return encryptedPassw == storedPassword;
        }

        private class HashSalt
        {
            public HashSalt(string hash, byte[] salt)
            {
                Hash = hash;
                Salt = salt;
            }

            public string Hash { get; set; }
            public byte[] Salt { get; set; }
        }
    }
}