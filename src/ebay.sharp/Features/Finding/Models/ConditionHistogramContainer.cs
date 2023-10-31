using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "conditionHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ConditionHistogramContainer {
    [XmlElement(ElementName = "conditionHistogram", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ConditionHistogram ConditionHistogram { get; set; }
}
