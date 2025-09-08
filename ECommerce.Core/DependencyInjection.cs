using ECommerce.Core.Contracts.Services;
using ECommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        return services;
    }

}
