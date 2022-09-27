using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }
        public string Qualifications { get; set; }
        public string Commentary { get; set;}
    }
}
