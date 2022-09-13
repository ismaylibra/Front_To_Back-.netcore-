using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public string GearBox { get; set; }


        public ICollection<CarImage> CarImages { get; set; }
    }
}
