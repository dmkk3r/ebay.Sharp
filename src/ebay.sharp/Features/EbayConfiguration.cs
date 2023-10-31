namespace ebay.Sharp.Features;

public class EbayConfiguration {
    private const string FINDINGS_PROD = "https://svcs.ebay.com/services/search/FindingService/v1";
    private const string FINDINGS_SAND = "https://svcs.sandbox.ebay.com/services/search/FindingService/v1";

    public enum Environment {
        Production,
        Sandbox
    }

    public Environment EnvironmentType { get; set; }
    public string AuthToken { get; set; }
    public string AppId { get; set; }
    public string GlobalId { get; set; }

    public string FindingsEndpoint => EnvironmentType == Environment.Production ? FINDINGS_PROD : FINDINGS_SAND;
}