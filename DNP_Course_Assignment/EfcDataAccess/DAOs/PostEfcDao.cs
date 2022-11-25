using Application.DaoInterfaces;
using DomainOrShared.DTOs;
using DomainOrShared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class PostEfcDao : IPostDao
{
    private readonly DataContext context;

    public PostEfcDao(DataContext context)
    {
        this.context = context;
    }
    
    public async Task<Post> CreateAsync(Post post)
    {
        EntityEntry<Post> added = await context.Posts.AddAsync(post);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParameters)
    {
        IQueryable<Post> query = context.Posts.Include(post => post.Author).AsQueryable();

        if (!string.IsNullOrEmpty(searchParameters.Username))
        {
            query = query.Where(post => post.Author.UserName.ToLower().Equals(searchParameters.Username.ToLower()));
        }

        if (searchParameters.UserId != null)
        {
            query = query.Where(post => post.Author.Id == searchParameters.UserId);
        }

        if (!string.IsNullOrEmpty(searchParameters.TitleContains))
        {
            query = query.Where(post => post.Title.ToLower().Equals(searchParameters.TitleContains.ToLower()));
        }

        List<Post> result = await query.ToListAsync();
        return result;
    }

    public async Task DeleteAsync(int id)
    {
        Post? existing = await GetByIdAsync(id);
        if (existing == null)
            throw new Exception("Post not found");

        context.Posts.Remove(existing);
        await context.SaveChangesAsync();
    }

    public async Task<Post?> GetByIdAsync(int id)
    {
        Post? existing = await context.Posts
            .AsNoTracking()
            .Include(post => post.Author)
            .SingleOrDefaultAsync(post => post.Id == id);
        return existing;
    }
}