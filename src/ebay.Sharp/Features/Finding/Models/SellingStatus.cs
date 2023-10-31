using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "sellingStatus", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class SellingStatus {
    [XmlElement(ElementName = "bidCount", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string BidCount { get; set; }
    [XmlElement(ElementName = "convertedCurrentPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ConvertedCurrentPrice ConvertedCurrentPrice { get; set; }
    [XmlElement(ElementName = "currentPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public CurrentPrice CurrentPrice { get; set; }
    [XmlElement(ElementName = "sellingState", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string SellingState { get; set; }
    [XmlElement(ElementName = "timeLeft", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TimeLeft { get; set; }
}
