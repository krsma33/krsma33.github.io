using Blazored.LocalStorage;
using Rasadnik.Shared.Models;
using System.Threading.Tasks;

namespace Rasadnik.Client
{
    public class UserLocalStorage
    {
        private const string _storageKey = "UserInfo";
        private readonly ILocalStorageService _localStorage;

        public UserLocalStorage(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task StoreAsync(string token)
        {
            await _localStorage.SetItemAsync(_storageKey, token);
        }

        public async Task RemoveAsync()
        {
            await _localStorage.RemoveItemAsync(_storageKey);
        }

        public async Task<string> GetAsync()
        {
            if(await _localStorage.ContainKeyAsync(_storageKey))
            {
                return await _localStorage.GetItemAsync<string>(_storageKey);
            }

            return null;
        }
    }
}
