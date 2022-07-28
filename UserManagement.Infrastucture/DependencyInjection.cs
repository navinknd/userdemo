using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UserManagement.Infrastucture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUserDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDatabaseInitializer,DatabaseInitializer>();
            var connectionString = configuration.GetConnectionString("UserDetailsConnection");
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString, b => b.MigrationsAssembly("UserManagement")));
            return services;
        }
    }
}
 