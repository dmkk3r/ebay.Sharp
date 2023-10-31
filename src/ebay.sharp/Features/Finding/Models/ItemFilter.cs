using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "itemFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ItemFilter {
    [XmlElement(ElementName = "name", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Name { get; set; }
    [XmlElement(ElementName = "paramName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ParamName { get; set; }
    [XmlElement(ElementName = "paramValue", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ParamValue { get; set; }
    [XmlElement(ElementName = "value", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public List<string> Value { get; set; }
}
