using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "aspect", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Aspect {
    [XmlElement(ElementName = "valueHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ValueHistogram ValueHistogram { get; set; }
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}
