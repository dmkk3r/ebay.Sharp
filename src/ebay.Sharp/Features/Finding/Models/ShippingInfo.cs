using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "shippingInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ShippingInfo {
    [XmlElement(ElementName = "expeditedShipping", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ExpeditedShipping { get; set; }
    [XmlElement(ElementName = "handlingTime", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string HandlingTime { get; set; }
    [XmlElement(ElementName = "oneDayShippingAvailable", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string OneDayShippingAvailable { get; set; }
    [XmlElement(ElementName = "shippingServiceCost", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ShippingServiceCost ShippingServiceCost { get; set; }
    [XmlElement(ElementName = "shippingType", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ShippingType { get; set; }
    [XmlElement(ElementName = "shipToLocations", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ShipToLocations { get; set; }
}
