using Elastic.Clients.Elasticsearch;
using Microblog.SearchService.Infrastructure;

namespace Microblog.SearchService.Presentation;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.RegisterInfrastructure(Configuration);
        services.AddElasticsearchClient();
        
        services.AddSwaggerGen();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseHttpsRedirection();
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseAuthorization();
    }
}
