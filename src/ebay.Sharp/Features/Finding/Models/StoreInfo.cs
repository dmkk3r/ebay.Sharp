using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "storeInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class StoreInfo {
    [XmlElement(ElementName = "storeName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string StoreName { get; set; }
    [XmlElement(ElementName = "storeURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string StoreURL { get; set; }
}
