using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "aspectFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class AspectFilter {
    [XmlElement(ElementName = "aspectName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string AspectName { get; set; }
    [XmlElement(ElementName = "aspectValueName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string AspectValueName { get; set; }
}
