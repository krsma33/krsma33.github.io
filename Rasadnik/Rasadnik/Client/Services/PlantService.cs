using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
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
    public class PlantService : IPlantService
    {
        private readonly HttpClient _httpClient;

        public PlantService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Plant>> GetPlantsByPlantFamilyId(Guid plantFamilyId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Plant>>($"api/Plant/GetPlantsByPlantFamilyId?id={ plantFamilyId }");
        }
    }
}
