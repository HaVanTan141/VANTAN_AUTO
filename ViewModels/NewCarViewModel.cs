using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace VANTAN_AUTO.ViewModels
{
    public class NewCarViewModel
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public IFormFile ImageFile { get; set; } = default!;

        // Add ImageUrl property to resolve the error in AdminController
        public string ImageUrl { get; set; } = string.Empty;
    }
}
