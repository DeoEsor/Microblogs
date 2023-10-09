using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Microblog.SearchService.Domain.Entities;
using Microblog.SearchService.Infrastructure.Abstractions.Repository.Contract;

namespace Microblog.SearchService.Infrastructure.Repository;

internal static class TweetQueries
{
    public static SearchRequestDescriptor<Tweet> SearchByFilter(TweetFilter filter)
    {
        return new SearchRequestDescriptor<Tweet>()
            .Query(q =>
            {
                q
                    .Match(match => match
                        .Field(tweet => tweet.Message)
                        .Query(filter.MessageContent ?? string.Empty)
                    )
                    .Match(match => match
                        .Field(tweet => tweet.UserId)
                        .Query(filter.FromUser.ToString() ?? string.Empty)
                    )
                    .Range(range =>
                    {
                        range.DateRange(dateRange =>
                        {
                            dateRange
                                .From(filter.PostedAfter ?? DateTime.UnixEpoch)
                                .To(filter.PostedBefore ?? DateTime.Now);
                        });
                    });
            })
            .From(filter.Skip)
            .Size(filter.Limit);
    }
}
