using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        //public int CarId { get; set; }
        public bool IsMain { get; set; }
        public string ImageUrl { get; set; }
    }
}
