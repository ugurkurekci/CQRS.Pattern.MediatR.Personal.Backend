using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business;

public static class DependencyInjections
{
    public static void AddHandlers(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}