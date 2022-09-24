using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api_Movies.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<TypeDoc> TypeDocs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colections> Colectionses { get; set; }
        public DbSet<DetailRental> DetailRentales { get; set; }
        public DbSet<DetailSale> DetailSales { get; set; }
        public DbSet<File> Files { get; set; }    
        public DbSet<Idiom> Idioms { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Pqr> Pqrs { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Rental> Rentales { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Serie> Series { get; set; }

    }
}
