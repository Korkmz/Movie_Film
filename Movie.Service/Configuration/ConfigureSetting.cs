
using Microsoft.Extensions.DependencyInjection;
using Movie.Service.Services.Interface;
using Movie.Service.Services;

namespace Movie.Service.Configuration
{
    public static class ConfigureSetting
    {
        public static IServiceCollection ServiceCollectionExtensions(IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }
    }
}
