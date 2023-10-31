using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "distance", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Distance {
    [XmlAttribute(AttributeName = "unit")]
    public string Unit { get; set; }
    [XmlText]
    public string Text { get; set; }
}
