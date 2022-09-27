using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string NameCategory { get; set; }

        [ForeignKey("Movie")]
        public int IdMovie { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
