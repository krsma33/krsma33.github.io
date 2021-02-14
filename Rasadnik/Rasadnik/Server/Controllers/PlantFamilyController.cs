using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rasadnik.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantFamilyController : ControllerBase
    {
        private readonly ILogger<PlantFamilyController> _logger;
        private readonly IPlantFamilyService _service;

        public PlantFamilyController(ILogger<PlantFamilyController> logger, IPlantFamilyService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PlantFamily>> GetPlantFamilies()
        {
            return await _service.GetPlantFamilies();
        }
    }
}
