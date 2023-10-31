using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;

namespace ebay.Sharp.Features;

public class EbayHttpClient {
    private readonly HttpClient _httpClient;

    public EbayHttpClient(IHttpClientFactory clientFactory) {
        _httpClient = clientFactory.CreateClient("ebay-client");
    }

    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(string requestName, TRequest request, string endpoint,
        CancellationToken cancellationToken) {
        _httpClient.BaseAddress = new Uri(endpoint);
        _httpClient.DefaultRequestHeaders.Add("X-EBAY-SOA-OPERATION-NAME", requestName);

        var xmlSerializer = new XmlSerializer(typeof(TRequest));
        await using var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, request);
        var serializedRequest = stringWriter.ToString();

        var content = new StringContent(serializedRequest, Encoding.UTF8, "text/xml");
        content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");

        var response = await _httpClient.PostAsync("", content, cancellationToken).ConfigureAwait(false);
        var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        if (string.IsNullOrEmpty(responseBody)) throw new Exception("Response body is empty");

        xmlSerializer = new XmlSerializer(typeof(TResponse));
        using var stringReader = new StringReader(responseBody);
        var result = (TResponse)xmlSerializer.Deserialize(stringReader);

        return result;
    }
}