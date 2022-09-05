using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Qualification
    {
        [Key]
        private int Id { get; set; }
        private string Qualifications { get; set; }
        private string Commentary { get; set;}
    }
}
