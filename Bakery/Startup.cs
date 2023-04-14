using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bakery.Data;

namespace Bakery
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<BakeryContext>();
        }

    }
    
}
