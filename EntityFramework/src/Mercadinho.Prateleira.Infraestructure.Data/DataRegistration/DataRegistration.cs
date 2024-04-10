using Mercadinho.Prateleira.Infraestructure.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mercadinho.Prateleira.Infraestructure.Data.DataRegistration
{
    public static class DataRegistration
    {
        public static IServiceCollection AddDataRegistration(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<DbContext, PrateleiraDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sql_connection"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}