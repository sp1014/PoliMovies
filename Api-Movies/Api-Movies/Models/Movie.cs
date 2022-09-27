using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string TitleMovie { get; set; }
        public DateTime DateProduction { get; set; }
        public string Duration { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
        public string Producers { get; set; }


        [ForeignKey("Rental")]
        public int IdRental { get; set; }
        public virtual Rental Rental { get; set; }

        [ForeignKey("Sale")]
        public int IdSale { get; set; }
        public virtual Sale Sale { get; set; }

        [ForeignKey("Qualification")]
        public int IdQualification { get; set; }
        public virtual Qualification Qualification { get; set; }

        [ForeignKey("Serie")]
        public int IdSerie { get; set; }
        public virtual Serie Serie { get; set; }

        [ForeignKey("File")]
        public int IdFile { get; set; }
        public virtual File File { get; set; }

        [ForeignKey("Colections")]
        public int IdColections { get; set; }
        public virtual Colections Colections { get; set; }


    }
}
