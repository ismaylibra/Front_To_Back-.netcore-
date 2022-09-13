using Microsoft.AspNetCore.Mvc;
using RentACar.DAL;
using RentACar.Models;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.Controllers
{
    public class HomeController : Controller
    {
        public List<Car> Cars;
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;

            Cars = new List<Car>
            {
                new Car {
                    Id = 1,
                    Name ="BMW X5",
                    Price = 99,
                    GearBox= "Automatic",
                    Mileage = 79,
                    Year = 2015,
                   
                    CarImages = new List<CarImage> {
                        new CarImage {Id = 1, ImageUrl = "car-rent-1.png"},
                        new CarImage {Id = 2, ImageUrl = "car-rent-2.png", IsMain = true},
                        new CarImage {Id = 3, ImageUrl = "car-rent-3.png"},
                        new CarImage {Id = 3, ImageUrl = "car-rent-4.png"},
                    }
                },
                new Car {
                    Id = 2,
                    Name ="Mercedes AMG GT",
                    Price = 299,
                    GearBox = "Automatic",
                    Mileage = 22,
                    Year = 2019,
                    CarImages = new List<CarImage> {
                        new CarImage {Id = 1, ImageUrl = "car-rent-1.png", IsMain = true},
                        new CarImage {Id = 2, ImageUrl = "car-rent-2.png"},
                        new CarImage {Id = 3, ImageUrl = "car-rent-3.png"},
                        new CarImage {Id = 3, ImageUrl = "car-rent-4.png"},
                    }
                },
                new Car {
                    Id = 3,
                    Name ="Audi R8",
                    Price = 149,
                    GearBox = "Manual",
                    Mileage = 34,
                    Year = 2012,
                    CarImages = new List<CarImage> {
                        new CarImage {Id = 1, ImageUrl = "car-rent-1.png"},
                        new CarImage {Id = 2, ImageUrl = "car-rent-2.png"},
                        new CarImage {Id = 3, ImageUrl = "car-rent-3.png", IsMain = true},
                        new CarImage {Id = 3, ImageUrl = "car-rent-4.png"},
                    }
                },
            };
        }

        public IActionResult Index()
        {
            return View(Cars);
        }

        public IActionResult Detail(int? id)
        {
            if (id is null) return BadRequest();
            var carDetail = Cars.Where(c => c.Id == id).FirstOrDefault();
            return View(carDetail);
        }
    }
}
