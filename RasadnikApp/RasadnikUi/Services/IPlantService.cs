using RasadnikUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasadnikUi.Services
{
    public interface IPlantService
    {
        Task<List<Plant>> GetPlantsByPlantFamily(PlantFamily plantFamily);
    }
}
