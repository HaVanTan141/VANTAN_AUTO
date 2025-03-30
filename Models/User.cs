using System;
using System.ComponentModel.DataAnnotations;

namespace VANTAN_AUTO.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "User";
        public string Numberphone { get; set; }
        public string Fullname { get; set; }
    }
}
