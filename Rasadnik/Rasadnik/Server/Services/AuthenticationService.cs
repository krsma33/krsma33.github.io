using Microsoft.Extensions.Configuration;
using Rasadnik.Server.JWT;
using Rasadnik.Server.Models;
using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace Rasadnik.Server.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly IConfiguration _config;
        private readonly JwtProvider _jwt;
        private readonly List<User> _appUsers;

        public AuthenticationService(IConfiguration config, JwtProvider jwt)
        {
            _config = config;
            _jwt = jwt;
            _appUsers = _config.GetSection("UserCredentials").Get<List<User>>();
        }
        private User AuthenticateUser(UserDto loginCredentials)
        {
            User user = _appUsers.SingleOrDefault(x => x.UserName == loginCredentials.UserName && x.Password == loginCredentials.Password);
            return user;
        }

        public Task<string> AuthenticateAsync(UserDto loginCredentials)
        {
            User user = AuthenticateUser(loginCredentials) ?? throw new AuthenticationException();
            
            string tokenString = _jwt.GenerateJWTToken(user);

            return Task.FromResult(tokenString);
        }

        /// <summary>
        /// Used only for server-prerendering
        /// </summary>
        /// <returns></returns>
        public Task<string> GetUserInfoFromLocalStorageAsync()
        {
            return Task.FromResult<string>(null);
        }

        public Task LogoutAsync(string token)
        {
            throw new NotImplementedException();
        }

    }
}
