using System.Xml.Serialization;
using ebay.Sharp.Features.Finding.Models;

namespace ebay.Sharp.Features.Finding.FindItemsByKeywords.Models;

[XmlRoot(ElementName = "findItemsByKeywordsResponse", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class FindItemsByKeywordsResponse {
    [XmlElement(ElementName = "aspectHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public AspectHistogramContainer AspectHistogramContainer { get; set; }
    [XmlElement(ElementName = "categoryHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public CategoryHistogramContainer CategoryHistogramContainer { get; set; }
    [XmlElement(ElementName = "conditionHistogramContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ConditionHistogramContainer ConditionHistogramContainer { get; set; }
    [XmlElement(ElementName = "ack", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Ack { get; set; }
    [XmlElement(ElementName = "errorMessage", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ErrorMessage ErrorMessage { get; set; }
    [XmlElement(ElementName = "itemSearchURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ItemSearchURL { get; set; }
    [XmlElement(ElementName = "paginationOutput", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public PaginationOutput PaginationOutput { get; set; }
    [XmlElement(ElementName = "searchResult", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public SearchResult SearchResult { get; set; }
    [XmlElement(ElementName = "timestamp", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Timestamp { get; set; }
    [XmlElement(ElementName = "version", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Version { get; set; }
    [XmlAttribute(AttributeName = "xmlns")]
    public string Xmlns { get; set; }
}