using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "affiliate", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Affiliate {
    [XmlElement(ElementName = "customId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CustomId { get; set; }
    [XmlElement(ElementName = "geoTargeting", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string GeoTargeting { get; set; }
    [XmlElement(ElementName = "networkId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string NetworkId { get; set; }
    [XmlElement(ElementName = "trackingId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TrackingId { get; set; }
}
