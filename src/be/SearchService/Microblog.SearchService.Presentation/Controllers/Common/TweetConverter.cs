using Google.Protobuf.WellKnownTypes;
using Microblog.SearchService.Presentation.Abstractions;

namespace Microblog.SearchService.Presentation.Controllers.Common;

public static class TweetConverter
{
    public static Tweet FromInternal(Domain.Entities.Tweet tweet)
    {
        return new Tweet
        {
            Id = tweet.Id.ToString(),
            UserId = tweet.UserId.ToString(),
            PostDate = Timestamp.FromDateTime(tweet.PostDate),
            Message = tweet.Message,
        };
    }
}
