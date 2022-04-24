using Microsoft.Extensions.DependencyInjection;
using SQLiteApp.Application.Contracts.Data;
using SQLiteApp.Data.Repositories;

namespace SQLiteApp.Data
{
    public static class DataServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<IDBConnectionFactory, DBConnectionFactory>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            return services;
        }
    }
}