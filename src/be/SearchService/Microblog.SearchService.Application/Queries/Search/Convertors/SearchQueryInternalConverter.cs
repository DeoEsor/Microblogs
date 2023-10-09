using Microblog.SearchService.Application.Queries.Search.Contracts;
using Microblog.SearchService.Infrastructure.Abstractions.Repository.Contract;

namespace Microblog.SearchService.Application.Queries.Search.Convertors;

internal static class SearchQueryInternalConverter
{
    public static TweetFilter ToFilter(SearchQueryInternal query)
    {
        return new TweetFilter(
            query.Topic,
            query.MessageContent,
            query.PostedAfter,
            query.PostedBefore,
            query.FromUser,
            query.Skip,
            query.Limit);
    }
}
