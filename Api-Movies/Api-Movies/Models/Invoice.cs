using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public bool status { get; set; }
    }
}
