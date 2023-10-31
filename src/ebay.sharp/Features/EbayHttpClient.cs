using System.Xml.Serialization;

namespace ebay.Sharp.Features;

public class EbayHttpClient {
    private readonly HttpClient _httpClient;

    public EbayHttpClient(IHttpClientFactory clientFactory) {
        _httpClient = clientFactory.CreateClient("eBayClient");
    }

    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(string requestName, TRequest request, string endpoint,
        CancellationToken cancellationToken) {
        _httpClient.BaseAddress = new Uri(endpoint);
        _httpClient.DefaultRequestHeaders.Add("X-EBAY-SOA-OPERATION-NAME", requestName);

        await using var stringWriter = new StringWriter();
        new XmlSerializer(typeof(TRequest)).Serialize(stringWriter, request);
        var xmlSerialized = stringWriter.GetStringBuilder().ToString();

        var response = await _httpClient.PostAsync("", new StringContent(xmlSerialized, null, "text/xml"), cancellationToken);
        var responseBody = await response.Content.ReadAsStringAsync();

        if (string.IsNullOrEmpty(responseBody)) throw new Exception("Response body is empty");

        var xmlSerializer = new XmlSerializer(typeof(TResponse));

        using var stringReader = new StringReader(responseBody);
        var result = (TResponse)xmlSerializer.Deserialize(stringReader);
        
        return result;
    }
}