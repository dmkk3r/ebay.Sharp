using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "secondaryCategory", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class SecondaryCategory {
    [XmlElement(ElementName = "categoryId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CategoryId { get; set; }
    [XmlElement(ElementName = "categoryName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CategoryName { get; set; }
}
