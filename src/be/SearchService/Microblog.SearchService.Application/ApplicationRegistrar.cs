using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microblog.SearchService.Application;

public static class ApplicationRegistrar
{
    public static IServiceCollection RegisterApplication(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(ApplicationRegistrar).Assembly));
        
        return services;
    }
}
