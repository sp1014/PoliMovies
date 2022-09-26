using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class DetailSale
    {
        [Key]
        public int Id { get; set; }
        public string Detail {get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Sale")]
        public int IdSale { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
