using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class Pqr
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }
        public virtual User User { get; set; }
    }
}
