using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "valueHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ValueHistogram {
    [XmlElement(ElementName = "count", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Count { get; set; }
    [XmlAttribute(AttributeName = "valueName")]
    public string ValueName { get; set; }
}
