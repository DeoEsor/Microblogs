using Microblog.SearchService.Infrastructure.Abstractions.Repository;
using Microblog.SearchService.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microblog.SearchService.Infrastructure;

public static class InfrastructureRegistrar
{
    public static IServiceCollection RegisterInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddSingleton<ITweetRepository, TweetRepository>();
        
        return serviceCollection;
    }
}
