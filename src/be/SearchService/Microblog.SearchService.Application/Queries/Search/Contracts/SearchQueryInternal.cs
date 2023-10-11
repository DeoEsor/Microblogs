using MediatR;

namespace Microblog.SearchService.Application.Queries.Search.Contracts;

public sealed record SearchQueryInternal
(
    string? Topic,
    string? MessageContent,
    DateTime? PostedAfter,
    DateTime? PostedBefore,
    Guid? FromUser,
    int Skip,
    int Limit
) : IRequest<SearchQueryResponseInternal>;
