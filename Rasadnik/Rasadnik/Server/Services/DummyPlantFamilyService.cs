using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rasadnik.Server.Services
{
    public class DummyPlantFamilyService : IPlantFamilyService
    {
        public async Task<IEnumerable<PlantFamily>> GetPlantFamilies()
        {
            var plantFamilies = new List<PlantFamily>()
            {
                new PlantFamily { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Cetinari" },
                new PlantFamily { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "Tuje" },
                new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }
            };

            return plantFamilies;
        }
    }
}
