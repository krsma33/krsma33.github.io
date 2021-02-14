using Rasadnik.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rasadnik.Shared.Services
{
    public interface IPlantService
    {
        Task<IEnumerable<Plant>> GetPlantsByPlantFamilyId(Guid plantFamilyId);
    }
}
