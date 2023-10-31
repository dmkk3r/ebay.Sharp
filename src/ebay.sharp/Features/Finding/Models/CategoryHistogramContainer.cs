using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "categoryHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class CategoryHistogramContainer {
    [XmlElement(ElementName = "categoryHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public CategoryHistogram CategoryHistogram { get; set; }
}
