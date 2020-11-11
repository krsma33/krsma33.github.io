using RasadnikUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasadnikUi.Services
{
    public class DummyPlantFamilyService : IPlantFamilyService
    {
        public async Task<List<PlantFamily>> GetPlantFamilies()
        {
            var plantFamilies = new List<PlantFamily>()
            {
                new PlantFamily { Id = 1, Name = "Cetinari" },
                new PlantFamily { Id = 2, Name = "Tuje" },
                new PlantFamily { Id = 3, Name = "Drvenaste biljke" }
            };

            return plantFamilies;
        }
    }
}
