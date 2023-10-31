using ebay.Sharp.Features.Finding.FindItemsByKeywords.Models;
using MediatR;

namespace ebay.Sharp.Features.Finding.FindItemsByKeywords;

public class FindItemsByKeyword : IRequest<FindItemsByKeywordsResponse> {
    public FindItemsByKeywordsRequest FindItemsByKeywordsRequest { get; set; }
}

public class FindItemsByKeywordHandler : IRequestHandler<FindItemsByKeyword, FindItemsByKeywordsResponse> {
    private readonly EbayConfiguration _ebayConfiguration;
    private readonly EbayHttpClient _ebayHttpClient;
    public FindItemsByKeywordHandler(EbayConfiguration ebayConfiguration, EbayHttpClient ebayHttpClient) {
        _ebayConfiguration = ebayConfiguration;
        _ebayHttpClient = ebayHttpClient;
    }

    public async Task<FindItemsByKeywordsResponse> Handle(FindItemsByKeyword request, CancellationToken cancellationToken) {
        var responseObject = await _ebayHttpClient.SendRequestAsync<FindItemsByKeywordsRequest, FindItemsByKeywordsResponse>(
            "findItemsByKeywords",
            request.FindItemsByKeywordsRequest,
            _ebayConfiguration.FindingsEndpoint,
            cancellationToken);

        return await Task.FromResult(responseObject);
    }
}
