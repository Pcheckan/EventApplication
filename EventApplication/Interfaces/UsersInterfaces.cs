using EventApplication.Models;
using System.Threading.Tasks;

namespace EventApplication.Interfaces
{
    public interface UsersInterfaces
    {
        Task<Users> Login(string Email, string Password);

        Task<Users> Register(Users model);
        Task<Users> GetProfileDataByEmail(string Email);
    }
}
