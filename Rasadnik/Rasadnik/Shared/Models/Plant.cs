using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rasadnik.Shared.Models
{
    public class Plant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public PlantFamily PlantFamily { get; set; }
        public float SizeMinCm { get; set; }
        public float SizeMaxCm { get; set; }
        public decimal PriceMinRsd { get; set; }
        public decimal PriceMaxRsd { get; set; }
    }
}
