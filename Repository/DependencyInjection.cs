using Data.ProjectDBContexts;
using Microsoft.Extensions.DependencyInjection;
using Repository.Abstracts;
using Repository.Concrete;

namespace Repository;

public static class DependencyInjection
{
    public static void RegisterRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IPhotoRepository, PhotoRepository>();
        serviceCollection.AddScoped<ProjectDbContext>();
    }
}
