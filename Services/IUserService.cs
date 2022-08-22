using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SecuredRestApi.Models;

namespace SecuredRestApi.Services
{
    public interface IUserService
    {
        // register a new user
        Task<string> RegisterAsync(RegisterModel model);

        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
