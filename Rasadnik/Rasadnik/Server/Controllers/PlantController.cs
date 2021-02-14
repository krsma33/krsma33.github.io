using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Rasadnik.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantController : ControllerBase
    {
        private readonly ILogger<PlantController> _logger;
        private readonly IPlantService _service;
        private readonly IWebHostEnvironment _environment;

        public PlantController(ILogger<PlantController> logger, IPlantService service, IWebHostEnvironment environment)
        {
            _logger = logger;
            _service = service;
            _environment = environment;
        }

        [HttpGet("GetPlantsByPlantFamilyId")]
        public async Task<IEnumerable<Plant>> GetPlantsByPlantFamilyId([FromQuery] Guid id)
        {
            return await _service.GetPlantsByPlantFamilyId(id);
        }

        [HttpPost("upload/single")]
        public async Task<ActionResult> UploadTest(IFormFile file)
        {
            var folder = Path.Combine(_environment.ContentRootPath, "Temp");
            Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, Path.GetRandomFileName() + ".png");

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}
