using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "parameter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Parameter {
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
    [XmlText]
    public string Text { get; set; }
}
