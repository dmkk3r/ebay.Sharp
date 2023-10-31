using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "paginationInput", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class PaginationInput {
    [XmlElement(ElementName = "entriesPerPage", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string EntriesPerPage { get; set; }
    [XmlElement(ElementName = "pageNumber", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PageNumber { get; set; }
}
