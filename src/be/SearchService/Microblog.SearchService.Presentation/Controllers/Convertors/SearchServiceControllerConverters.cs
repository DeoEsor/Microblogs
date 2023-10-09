using Microblog.SearchService.Application.Queries.Search.Contracts;
using Microblog.SearchService.Presentation.Abstractions;
using Microblog.SearchService.Presentation.Controllers.Common;

namespace Microblog.SearchService.Presentation.Controllers.Convertors;

public static class SearchServiceControllerConverters
{
    public static SearchQueryInternal ToInternal(SearchQuery query)
    {
        return new SearchQueryInternal
        (
            query.Topic,
            query.MessageContent,
            query.PostedAfter.ToDateTime(),
            query.PostedBefore.ToDateTime(),
            Guid.Parse(query.FromUser), 
            query.Skip,
            query.Limit
        );
    }

    public static SearchQueryResponse FromInternal(SearchQueryResponseInternal responseInternal)
    {
        return new SearchQueryResponse
        {
            Tweets =
            {
                responseInternal.Tweets.Select(TweetConverter.FromInternal)
            }
        };
    }
}
