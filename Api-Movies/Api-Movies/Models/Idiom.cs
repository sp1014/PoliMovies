using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class Idiom
    {
        [Key]
        public int Id { get; set; }
        public string Lenguage { get; set; }
        public string SubTitle { get; set; }
        public string Doblaje { get; set; }

        [ForeignKey("Movie")]
        public int IdMovie { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
