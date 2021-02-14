using Rasadnik.Shared.Models;
using System.Threading.Tasks;

namespace Rasadnik.Shared.Services
{
    public interface IAuthService
    {
        Task LogoutAsync(string token);
        Task<string> AuthenticateAsync(UserDto user);
        Task<string> GetUserInfoFromLocalStorageAsync();
    }
}
