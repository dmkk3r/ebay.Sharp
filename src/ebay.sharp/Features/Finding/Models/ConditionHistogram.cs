using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "conditionHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ConditionHistogram {
    [XmlElement(ElementName = "condition", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Condition Condition { get; set; }
    [XmlElement(ElementName = "count", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Count { get; set; }
}
