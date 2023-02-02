using ECommerce.InfraStructure.Contexts;
using ECommerce.InfraStructure.Repositories.IRepository;
using ECommerce.InfraStructure.Repositories.Repository;
using ECommerce.InfraStructure.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace ECommerce.InfraStructure.Configuration
{
    public static class ConfigureServiceContainer
    {
        public static void AddSwaggerOpenAPI(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Database Provider", Description = "Core Api" }));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductsRepository>();
        }

        public static void AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceContext>(option => option
           .UseInMemoryDatabase(databaseName: "SnappfoodDB"));

            services.AddScoped<DbContext, ECommerceContext>();

            var seedData = new FillInMemoryDB(services.BuildServiceProvider());
            seedData.FillData();
        }
    }
}
