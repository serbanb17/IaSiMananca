using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Initializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Configurations.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void AddConnectionString(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            var dbContext = services.BuildServiceProvider().GetService<AppDbContext>();

            RestaurantInitializer.Seed(dbContext);
            RestaurantDishInitializer.Seed(dbContext);
            RestaurantReviewInitializer.Seed(dbContext);
            RestaurantUserInitializer.Seed(dbContext);
            RestaurantImageInitializer.Seed(dbContext);
        }
    }
}
