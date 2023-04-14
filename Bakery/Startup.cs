using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bakery.Data;

namespace Bakery;

public static class Startup
{
    public static IServiceCollection AddStartup(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddDbContext<BakeryContext>();

        return services;
    }

}

