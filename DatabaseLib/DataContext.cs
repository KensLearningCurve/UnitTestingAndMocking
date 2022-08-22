using DatabaseLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLib
{
    public class DataContext : DbContext
    {
        DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("This could be a connection string, but it isn't. This does absolutely nothing!");
        }
    }
}
