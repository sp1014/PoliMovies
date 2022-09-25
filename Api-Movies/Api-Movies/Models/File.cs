using System.ComponentModel.DataAnnotations;

namespace Api_Movies.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Archivo { get; set; }
    }
}
