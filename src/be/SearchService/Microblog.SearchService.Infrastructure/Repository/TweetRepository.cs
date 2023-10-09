using Elastic.Clients.Elasticsearch;
using Microblog.SearchService.Domain.Entities;
using Microblog.SearchService.Infrastructure.Abstractions.Repository;
using Microblog.SearchService.Infrastructure.Abstractions.Repository.Contract;

namespace Microblog.SearchService.Infrastructure.Repository;

internal sealed class TweetRepository : ITweetRepository
{
    private readonly ElasticsearchClient _elasticsearchClient;

    public TweetRepository(ElasticsearchClient elasticsearchClient)
    {
        _elasticsearchClient = elasticsearchClient;
    }
    
    public async Task<IReadOnlyCollection<Tweet>> SearchTweetByFilter(TweetFilter filter)
    {
        var query = TweetQueries.SearchByFilter(filter);
        
        var response = await _elasticsearchClient.SearchAsync(query);

        if (!response.IsValidResponse)
        {
            return null!;
        }

        return response.Documents;
    }
}
