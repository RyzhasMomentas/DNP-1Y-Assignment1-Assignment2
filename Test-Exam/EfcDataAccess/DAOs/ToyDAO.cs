using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class ToyDAO
{
    private readonly DataContext context;

    public ToyDAO(DataContext context)
    {
        this.context = context;
    }
    
    public async Task<Toy> CreateAsync(Toy toy)
    {
        EntityEntry<Toy> newToy = await context.Toys.AddAsync(toy);
        await context.SaveChangesAsync();
        return newToy.Entity;
    }
}