using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "condition", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Condition {
    [XmlElement(ElementName = "conditionDisplayName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ConditionDisplayName { get; set; }
    [XmlElement(ElementName = "conditionId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ConditionId { get; set; }
}
