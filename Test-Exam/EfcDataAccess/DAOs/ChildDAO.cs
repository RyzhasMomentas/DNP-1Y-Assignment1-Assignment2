using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class ChildDAO
{
    private readonly DataContext context;

    public ChildDAO(DataContext context)
    {
        this.context = context;
    }

    public async Task<Child> CreateAsync(Child child)
    {
        EntityEntry<Child> newChild = await context.Children.AddAsync(child);
        await context.SaveChangesAsync();
        return newChild.Entity;
    }

    public async Task<IEnumerable<Child>> GetAsync()
    {
        IQueryable<Child> query = context.Children.Include(child => child);
        List<Child> result = await query.ToListAsync();
        return result;
    }
}