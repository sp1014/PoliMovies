using System;
using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int totalPrice { get; set; }
        public int quantity { get; set; }
    }
}
