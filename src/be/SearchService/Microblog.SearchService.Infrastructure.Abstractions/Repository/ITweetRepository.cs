using Microblog.SearchService.Domain.Entities;
using Microblog.SearchService.Infrastructure.Abstractions.Repository.Contract;

namespace Microblog.SearchService.Infrastructure.Abstractions.Repository;

public interface ITweetRepository
{
    Task<IReadOnlyCollection<Tweet>> SearchTweetByFilter(TweetFilter filter);
}
