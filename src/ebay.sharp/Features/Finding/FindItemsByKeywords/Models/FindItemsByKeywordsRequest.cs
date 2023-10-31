using System.Xml.Serialization;
using ebay.Sharp.Features.Finding.Models;

namespace ebay.Sharp.Features.Finding.FindItemsByKeywords.Models;

[XmlRoot(ElementName = "findItemsByKeywordsRequest", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class FindItemsByKeywordsRequest {
    [XmlElement(ElementName = "aspectFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public AspectFilter AspectFilter { get; set; }
    [XmlElement(ElementName = "domainFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public DomainFilter DomainFilter { get; set; }
    [XmlElement(ElementName = "itemFilter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ItemFilter ItemFilter { get; set; }
    [XmlElement(ElementName = "keywords", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Keywords { get; set; }
    [XmlElement(ElementName = "outputSelector", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string OutputSelector { get; set; }
    [XmlElement(ElementName = "affiliate", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Affiliate Affiliate { get; set; }
    [XmlElement(ElementName = "buyerPostalCode", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string BuyerPostalCode { get; set; }
    [XmlElement(ElementName = "paginationInput", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public PaginationInput PaginationInput { get; set; }
    [XmlElement(ElementName = "sortOrder", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string SortOrder { get; set; }
    [XmlAttribute(AttributeName = "xmlns")]
    public string Xmlns { get; set; }
}