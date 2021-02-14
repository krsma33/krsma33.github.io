using Microsoft.AspNetCore.Components.Authorization;
using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Rasadnik.Shared
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService _api;
        private string _token;

        public CustomAuthStateProvider(IAuthService api)
        {
            _api = api;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();

            if (string.IsNullOrEmpty(_token))
            {
                _token = await _api.GetUserInfoFromLocalStorageAsync();
            }

            if (!string.IsNullOrEmpty(_token))
            {
                var token = new JwtSecurityToken(_token);

                if (IsValidToken(token))
                {
                    var claims = token.Claims;

                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        public async Task Logout()
        {
            await _api.LogoutAsync(_token);
            _token = null;
            NotifyAuthenticationStateChanged();
        }

        public async Task Login(UserDto loginParameters)
        {
            _token = await _api.AuthenticateAsync(loginParameters);

            NotifyAuthenticationStateChanged();
        }

        private static bool IsValidToken(JwtSecurityToken token)
        {
            var a = DateTime.UtcNow;

            if (DateTime.Compare(a, token.ValidTo) > 0)
            {
                return false;
            }

            return true;
        }

        public void NotifyAuthenticationStateChanged()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
