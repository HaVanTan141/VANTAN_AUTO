using System;
using System.Collections.Generic;

namespace VANTAN_AUTO.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; } // Use required modifier
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
