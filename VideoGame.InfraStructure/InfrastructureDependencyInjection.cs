using Microsoft.Extensions.DependencyInjection;
using VideoGame.Application.Interfaces;
using VideoGame.InfraStructure.Repositories;

namespace VideoGame.InfraStructure
{
    public static class InfraStructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IDbContextFactory, DbContextFactory>();
            services.AddSingleton<IVideoGameRepository, VideoGameRepository>();

            return services;
        }
    }
}
