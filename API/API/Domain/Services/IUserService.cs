using API.Infrastructure.Database.Entities;
using System.Threading.Tasks;

namespace API.Domain.Services
{
    public interface IUserService
    {
        Task<UserEntity> CreateUser(UserEntity newUser, string password);
        Task<UserEntity> Login(string email, string password);
    }
}