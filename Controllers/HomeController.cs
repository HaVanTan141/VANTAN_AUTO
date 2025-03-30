using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VANTAN_AUTO.Data;
using VANTAN_AUTO.Models;

namespace VANTAN_AUTO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VANTAN_AUTOContext _context; // ✅ Sử dụng DbContext đúng

        public HomeController(ILogger<HomeController> logger, VANTAN_AUTOContext context) // Inject DbContext vào
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string title, decimal? minPrice, decimal? maxPrice, int? releaseYear)
        {
            var cars = _context.Cars.AsQueryable();

            // Lọc theo tên xe (Title)
            if (!string.IsNullOrEmpty(title))
            {
                cars = cars.Where(c => c.Title.Contains(title));
            }

            // Lọc theo Giá tiền
            if (minPrice.HasValue)
            {
                cars = cars.Where(c => c.Price >= minPrice);
            }
            if (maxPrice.HasValue)
            {
                cars = cars.Where(c => c.Price <= maxPrice);
            }

            // Lọc theo Năm sản xuất (ReleaseDate)
            if (releaseYear.HasValue)
            {
                cars = cars.Where(c => c.ReleaseDate.Year == releaseYear);
            }

            return View(await cars.ToListAsync());
        }
        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);
            if (car == null) return NotFound();

            return View(car);
        }

        public IActionResult Info()
        {
            return View();
        }

        public async Task<IActionResult> CarsList()
        {
            var cars = await _context.Cars.ToListAsync();
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
