using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace DomainOrShared.Auth;

public static class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("IsOwner", a=>a.RequireAuthenticatedUser().RequireClaim("Id", "1"));
        });
    }
}