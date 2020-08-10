using AspCoreTemplate.BL.Services;
using AspCoreTemplate.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspCoreTemplate.BL
{
    public static class BLBuilder
    {
        public static IServiceCollection AddBL(this IServiceCollection services, IConfiguration configuration)
        {
            // Add db context
            services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=db.db"));

            // Add services
            services.AddScoped<CustomerService>();

            return services;
        }
    }
}
