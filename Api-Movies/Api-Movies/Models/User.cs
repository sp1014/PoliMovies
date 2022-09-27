using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Api_Movies.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Doc { get; set; }
        public bool Status { get; set; }

        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public virtual Rol Rol { get; set; }

        [ForeignKey("TypeDoc")]
        public int IdTypeDoc { get; set; }
        public virtual TypeDoc TypeDoc { get; set; }
    }
}
