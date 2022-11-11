using System.ComponentModel.DataAnnotations;
using Application.DaoInterfaces;
using Application.LogicInterfaces;
using DomainOrShared.Models;

namespace Application.Logic;

public class AuthLogic : IAuthLogic
{
    private readonly IUserDao userDao;

    public AuthLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    public async Task<User> ValidateUser(string username, string password)
    {
        User? existing=await userDao.GetByUsernameAsync(username);
        if (existing == null)
            throw new Exception("User with this username was not found");
        if (!existing.Password.Equals(password))
            throw new Exception("The password for this account does not match");
        return existing;
    }

    public async Task RegisterUser(User user)
    {
        if (string.IsNullOrEmpty(user.UserName))
            throw new ValidationException("Username cannot be null");
        if (string.IsNullOrEmpty(user.Password))
            throw new ValidationException("Password cannot be null");
        try
        {
            await userDao.CreateAsync(user);
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }
}