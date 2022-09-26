using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string season { get; set; }
    }
}
