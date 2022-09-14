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
        }

        public IActionResult Index()
        {
            List<CarImage> carImg = _context.CarImages.ToList();
            List<Car> cars = _context.Cars.ToList();
            return View(cars);
        }

        public IActionResult Detail(int? id)
        {
            List<CarImage> carImg = _context.CarImages.ToList();
            List<Car> cars = _context.Cars.ToList();
            if (id is null) return BadRequest();
            var carDetail = cars.Where(c => c.Id == id).FirstOrDefault();
            return View(carDetail);
        }
    }
}
