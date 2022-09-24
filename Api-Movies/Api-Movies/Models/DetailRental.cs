using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class DetailRental
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Rental")]
        public int IdRental { get; set; }
        public virtual Rental Rental { get; set; }
    }
}
