using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "categoryHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class CategoryHistogram {
    [XmlElement(ElementName = "categoryId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CategoryId { get; set; }
    [XmlElement(ElementName = "categoryName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CategoryName { get; set; }
    [XmlElement(ElementName = "childCategoryHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ChildCategoryHistogram ChildCategoryHistogram { get; set; }
    [XmlElement(ElementName = "count", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Count { get; set; }
}
