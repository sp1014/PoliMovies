using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Api_Movies.Models
{
    public class TypeDoc
    {
        [Key]
        public int Id { get; set; }
        public string NameTypeDoc { get; set; }
    }
}
