using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppIdentityDbContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("IdentityConnection"));
            });

            return services;
        }
    }
}