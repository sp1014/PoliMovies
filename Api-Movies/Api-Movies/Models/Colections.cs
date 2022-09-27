using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Colections
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
