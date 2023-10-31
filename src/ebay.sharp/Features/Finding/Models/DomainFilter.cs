using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "domainFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class DomainFilter {
    [XmlElement(ElementName = "domainName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string DomainName { get; set; }
}
