using System.ComponentModel.DataAnnotations;

namespace VANTAN_AUTO.Models // Ensure this matches the intended namespace
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Họ tên")]
        public string Fullname { get; set; }

        [Required]
        [Display(Name = "Số điện thoại")]
        [Phone]
        public string Numberphone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
