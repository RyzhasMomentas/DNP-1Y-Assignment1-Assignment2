using Microsoft.EntityFrameworkCore;
using Domain;

namespace EfcDataAccess;

public class DataContext : DbContext
{
    public DbSet<Child> Children { get; set; }
    public DbSet<Toy> Toys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Test.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Toy>().HasKey(toy => toy.Id);
        modelBuilder.Entity<Child>().HasKey(child => child.Id);
    }
}