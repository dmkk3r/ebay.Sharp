using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "searchResult", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class SearchResult {
    [XmlElement(ElementName = "item", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public List<Item> Item { get; set; }
    [XmlAttribute(AttributeName = "count")]
    public string Count { get; set; }
}
