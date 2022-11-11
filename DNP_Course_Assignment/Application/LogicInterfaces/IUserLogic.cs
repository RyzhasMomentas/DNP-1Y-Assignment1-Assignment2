using DomainOrShared.DTOs;
using DomainOrShared.Models;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto dto);
}