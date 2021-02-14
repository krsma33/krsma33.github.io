using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Rasadnik.Client.Services
{
    public class PlantFamilyService : IPlantFamilyService
    {
        private readonly HttpClient _httpClient;

        public PlantFamilyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PlantFamily>> GetPlantFamilies()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlantFamily>>($"api/PlantFamily");
        }
    }
}
