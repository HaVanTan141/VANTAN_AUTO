using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VANTAN_AUTO.Models;

namespace VANTAN_AUTO.ViewModels
{
    public class CarManagementViewModel
    {
        public List<Car> Cars { get; set; } = new List<Car>(); // List of existing cars
        public Car NewCar { get; set; } = new Car(); // For adding a new car
    }
}

namespace VANTAN_AUTO.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty; // Stores the path to the image

        [NotMapped] // ImageFile is not stored in the database
        public IFormFile ImageFile { get; set; } = default!; // For file upload
    }
}
