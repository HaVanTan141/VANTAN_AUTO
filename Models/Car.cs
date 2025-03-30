using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace VANTAN_AUTO.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty; // Khởi tạo mặc định để tránh null

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; } = string.Empty; // Khởi tạo mặc định để tránh null

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string Description { get; set; } = string.Empty; // Khởi tạo mặc định để tránh null

        public string Manufacturer { get; set; } = string.Empty; // Khởi tạo mặc định để tránh null
    }
}