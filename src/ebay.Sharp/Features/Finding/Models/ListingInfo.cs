using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "listingInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ListingInfo {
    [XmlElement(ElementName = "bestOfferEnabled", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string BestOfferEnabled { get; set; }
    [XmlElement(ElementName = "buyItNowAvailable", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string BuyItNowAvailable { get; set; }
    [XmlElement(ElementName = "buyItNowPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public BuyItNowPrice BuyItNowPrice { get; set; }
    [XmlElement(ElementName = "convertedBuyItNowPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ConvertedBuyItNowPrice ConvertedBuyItNowPrice { get; set; }
    [XmlElement(ElementName = "endTime", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string EndTime { get; set; }
    [XmlElement(ElementName = "gift", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Gift { get; set; }
    [XmlElement(ElementName = "listingType", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ListingType { get; set; }
    [XmlElement(ElementName = "startTime", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string StartTime { get; set; }
}
