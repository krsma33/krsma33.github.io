using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Rasadnik.Client.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly UserLocalStorage _tokenLocalStorage;

        public AuthenticationService(HttpClient httpClient, UserLocalStorage tokenLocalStorage)
        {
            _httpClient = httpClient;
            _tokenLocalStorage = tokenLocalStorage;
        }

        public async Task<string> AuthenticateAsync(UserDto user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", user);

            response.EnsureSuccessStatusCode();
   
            var token = await response.Content.ReadAsStringAsync();

            AddBearerTokenToHttpHeader(token);
            await _tokenLocalStorage.StoreAsync(token);

            return token;
        }

        public async Task LogoutAsync(string token)
        {
            //TODO: run api request
            RemoveBearerTokenFromHttpHeader();
            await _tokenLocalStorage.RemoveAsync();
        }

        private void AddBearerTokenToHttpHeader(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse($"Bearer {token}");
            }
        }

        private void RemoveBearerTokenFromHttpHeader()
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<string> GetUserInfoFromLocalStorageAsync()
        {
            var token = await _tokenLocalStorage.GetAsync();

            if (token is not null)
            {
                AddBearerTokenToHttpHeader(token);
            }

            return token;
        }
    }
}
