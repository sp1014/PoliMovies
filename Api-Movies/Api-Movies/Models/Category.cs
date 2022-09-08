using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string NameCategory { get; set; }

    }
}
