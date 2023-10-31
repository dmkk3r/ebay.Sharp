using ebay.Sharp.Features.Finding.FindItemsAdvanced.Models;
using MediatR;

namespace ebay.Sharp.Features.Finding.FindItemsAdvanced;

public class FindItemsAdvanced : IRequest<FindItemsAdvancedResponse> {
    public FindItemsAdvancedRequest FindItemsAdvancedRequest { get; set; }
}

public class FindItemsAdvancedHandler : IRequestHandler<FindItemsAdvanced, FindItemsAdvancedResponse> {
    private readonly EbayConfiguration _ebayConfiguration;
    private readonly EbayHttpClient _ebayHttpClient;

    public FindItemsAdvancedHandler(EbayHttpClient ebayHttpClient, EbayConfiguration ebayConfiguration) {
        _ebayHttpClient = ebayHttpClient;
        _ebayConfiguration = ebayConfiguration;
    }

    public async Task<FindItemsAdvancedResponse> Handle(FindItemsAdvanced request, CancellationToken cancellationToken) {
        var responseObject = await _ebayHttpClient.SendRequestAsync<FindItemsAdvancedRequest, FindItemsAdvancedResponse>(
            "findItemsAdvanced",
            request.FindItemsAdvancedRequest,
            _ebayConfiguration.FindingsEndpoint,
            cancellationToken);

        return await Task.FromResult(responseObject);
    }
}
