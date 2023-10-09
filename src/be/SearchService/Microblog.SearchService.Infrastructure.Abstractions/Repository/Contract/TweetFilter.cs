namespace Microblog.SearchService.Infrastructure.Abstractions.Repository.Contract;

public record TweetFilter
(
    string? Topic,
    string? MessageContent,
    DateTime? PostedAfter,
    DateTime? PostedBefore,
    Guid? FromUser,
    int Skip,
    int Limit
);
