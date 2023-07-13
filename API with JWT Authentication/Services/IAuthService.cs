using API_with_JWT_Authentication.Models;
using System.Threading.Tasks;

namespace API_with_JWT_Authentication.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
