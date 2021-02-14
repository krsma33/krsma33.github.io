using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rasadnik.Server.Services
{
    public class DummyPlantService : IPlantService
    {
        private IEnumerable<Plant> plants = new List<Plant>()
        {
            new Plant { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("41111111-1111-1111-1111-111111111111"), Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("51111111-1111-1111-1111-111111111111"), Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("61111111-1111-1111-1111-111111111111"), Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("71111111-1111-1111-1111-111111111111"), Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("81111111-1111-1111-1111-111111111111"), Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = new Guid("21111111-1111-1111-1111-111111111111"), Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("91111111-1111-1111-1111-111111111111"), Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("12111111-1111-1111-1111-111111111111"), Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("13111111-1111-1111-1111-111111111111"), Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("14111111-1111-1111-1111-111111111111"), Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = new Guid("15111111-1111-1111-1111-111111111111"), Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = new Guid("31111111-1111-1111-1111-111111111111"), Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f }
        };

        public async Task<IEnumerable<Plant>> GetPlantsByPlantFamilyId(Guid plantFamilyId)
        {
            return plants.Where(p => p.PlantFamily.Id == plantFamilyId);
        }
    }
}
