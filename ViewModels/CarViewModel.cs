using System;
using Microsoft.AspNetCore.Http; // Required for IFormFile

namespace VANTAN_AUTO.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Genre { get; set; } = string.Empty;
        public string? Manufacturer { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public IFormFile? ImageFile { get; set; } // Added for file upload
    }
}