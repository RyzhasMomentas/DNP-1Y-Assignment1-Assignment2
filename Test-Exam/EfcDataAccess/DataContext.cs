using Microsoft.EntityFrameworkCore;

namespace EfcDataAccess;

public class DataContext : DbContext
{
    public DbSet<Child> Children { get; set; }
    public DbSet<Toy> Toys { get; set; }
}