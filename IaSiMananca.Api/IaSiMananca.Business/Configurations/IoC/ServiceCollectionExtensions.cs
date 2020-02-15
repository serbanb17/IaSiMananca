using IaSiMananca.DataAccess.Configurations.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace IaSiMananca.Business.Configurations.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusiness(this IServiceCollection services, string connectionString)
        {
            services.AddConnectionString(connectionString);
        }
    }
}
