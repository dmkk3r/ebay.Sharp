using ebay.Sharp.Features.Finding.FindItemsAdvanced.Models;
using ebay.Sharp.Features.Finding.FindItemsByKeywords;
using ebay.Sharp.Features.Finding.FindItemsByKeywords.Models;
using MediatR;

namespace ebay.Sharp.Features.Finding;

public class FindingService {
    private readonly IMediator _mediator;

    public FindingService(IMediator mediator) {
        _mediator = mediator;
    }

    public async Task<FindItemsByKeywordsResponse> FindItemsByKeywordsAsync(FindItemsByKeywordsRequest request) {
        return await _mediator.Send(new FindItemsByKeyword() {
            FindItemsByKeywordsRequest = request
        });
    }

    public async Task<FindItemsAdvancedResponse> FindItemsAdvancedAsync(FindItemsAdvancedRequest request) {
        return await _mediator.Send(new FindItemsAdvanced.FindItemsAdvanced() {
            FindItemsAdvancedRequest = request
        });
    }
}