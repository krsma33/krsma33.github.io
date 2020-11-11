using RasadnikUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasadnikUi.Services
{
    public interface IPlantFamilyService
    {
        Task<List<PlantFamily>> GetPlantFamilies();
    }
}
