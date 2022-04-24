using Microsoft.Extensions.DependencyInjection;
using SQLiteApp.Application.Contracts.Service;
using SQLiteApp.Application.Services;

namespace SQLiteApp.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IMovieServices, MovieServices>();
            return services;
        }
    }
}