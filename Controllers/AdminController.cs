using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using VANTAN_AUTO.ViewModels;
using VANTAN_AUTO.Models;

namespace VANTAN_AUTO.Controllers
{
    public class AdminController : Controller
    {
        // Assuming you have a login action
        [HttpPost]
        public IActionResult Login(AdminLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform login logic here
                // If login is successful, redirect to Cars/Index
                return RedirectToAction("Index", "Cars");
            }

            // If login fails, return to the login view with the model
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(CarManagementViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newCar = model.NewCar;

                // Handle file upload
                if (newCar.ImageFile != null && newCar.ImageFile.Length > 0)
                {
                    var fileName = Path.GetFileName(newCar.ImageFile.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await newCar.ImageFile.CopyToAsync(stream);
                    }

                    newCar.ImageUrl = $"/images/{fileName}";
                }

                // Save newCar to the database (implementation depends on your data access layer)
                // Example: _dbContext.Cars.Add(newCar); await _dbContext.SaveChangesAsync();

                return RedirectToAction("CarManagement");
            }

            return View("CarManagement", model);
        }

        // Assuming you have a GET action for CarManagement
        [HttpGet]
        public IActionResult CarManagement()
        {
            var model = new CarManagementViewModel
            {
                NewCar = CreateNewCar()
            };
            return View(model);
        }

        private Car CreateNewCar()
        {
            return new Car
            {
                Id = 0,
                Title = "New Car",
                Genre = "Sedan",
                Manufacturer = "Default Manufacturer",
                ReleaseDate = DateTime.Now,
                Price = 0.0m,
                Description = "Default Description",
                ImageUrl = "",
                ImageFile = null
            };
        }
    }
}
