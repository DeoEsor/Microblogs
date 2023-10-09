using Microblog.SearchService.Domain.Entities;

namespace Microblog.SearchService.Application.Queries.Search.Contracts;

public sealed record SearchQueryResponseInternal(IReadOnlyCollection<Tweet> Tweets);
