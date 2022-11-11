using DomainOrShared.DTOs;
using DomainOrShared.Models;

namespace Application.DaoInterfaces;

public interface IPostDao
{
    Task<Post> CreateAsync(Post post);
    Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParameters);
    Task DeleteAsync(int id);
    Task<Post?> GetByIdAsync(int id);
}