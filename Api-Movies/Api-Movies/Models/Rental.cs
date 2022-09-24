using System;
using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public int PriceRental { get; set; }
        public DateTime DateInitRental { get; set; }
        public DateTime DateEndRental { get; set; }
    }
}
