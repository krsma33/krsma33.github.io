using RasadnikUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasadnikUi.Services
{
    public class DummyPlantService : IPlantService
    {
        private List<Plant> plants = new List<Plant>()
        {
            new Plant { Id = 1, Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = 1, Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 2, Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = 1, Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 3, Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = 1, Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 4, Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = 1, Name = "Cetinari" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 5, Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = 2, Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 6, Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = 2, Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 7, Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = 2, Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 8, Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = 2, Name = "Tuje" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 9, Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = 3, Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 10, Name = "Robo", ImageSource = "images/1276576.jpg", PlantFamily = new PlantFamily { Id = 3, Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 11, Name = "S", ImageSource = "images/265555.jpg", PlantFamily = new PlantFamily { Id = 3, Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 12, Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = 3, Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f },
            new Plant { Id = 13, Name = "W", ImageSource = "images/877380.jpg", PlantFamily = new PlantFamily { Id = 3, Name = "Drvenaste biljke" }, PriceMinRsd = 1000, PriceMaxRsd = 10000, SizeMinCm = 30.6f, SizeMaxCm = 124.4f }
        };

        public async Task<List<Plant>> GetPlantsByPlantFamily(PlantFamily plantFamily)
        {
            return plants.Where(p => p.PlantFamily.Id == plantFamily.Id).ToList();
        }
    }
}
