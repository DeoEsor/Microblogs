using MediatR;
using Microblog.SearchService.Application.Queries.Search.Contracts;
using Microblog.SearchService.Application.Queries.Search.Convertors;
using Microblog.SearchService.Infrastructure.Abstractions.Repository;

namespace Microblog.SearchService.Application.Queries.Search;

internal sealed class SearchQueryHandler : IRequestHandler<SearchQueryInternal, SearchQueryResponseInternal>
{
    private readonly ITweetRepository _tweetRepository;

    public SearchQueryHandler(ITweetRepository tweetRepository)
    {
        _tweetRepository = tweetRepository;
    }
    
    public async Task<SearchQueryResponseInternal> Handle(SearchQueryInternal request, CancellationToken cancellationToken)
    {
        var filter = SearchQueryInternalConverter.ToFilter(request);

        var tweets = await _tweetRepository.SearchTweetByFilter(filter);
        
        var result = new SearchQueryResponseInternal(tweets);

        return result;
    }
}
