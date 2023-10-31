using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "aspectHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class AspectHistogramContainer {
    [XmlElement(ElementName = "aspect", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Aspect Aspect { get; set; }
    [XmlElement(ElementName = "domainDisplayName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string DomainDisplayName { get; set; }
    [XmlElement(ElementName = "domainName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string DomainName { get; set; }
}
