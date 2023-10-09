using Grpc.Core;
using MediatR;
using Microblog.SearchService.Presentation.Abstractions;
using Microblog.SearchService.Presentation.Controllers.Convertors;

namespace Microblog.SearchService.Presentation.Controllers;

public class SearchServiceController : Abstractions.SearchService.SearchServiceBase
{
    private readonly IMediator _mediator;

    public SearchServiceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public override async Task<SearchQueryResponse> Search(SearchQuery request, ServerCallContext context)
    {
        var query = SearchServiceControllerConverters.ToInternal(request);
        
        var responseInternal = await _mediator.Send(query);

        var response = SearchServiceControllerConverters.FromInternal(responseInternal);

        return response;
    }
}
