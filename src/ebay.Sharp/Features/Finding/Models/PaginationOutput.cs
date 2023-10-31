using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "paginationOutput", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class PaginationOutput {
    [XmlElement(ElementName = "entriesPerPage", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string EntriesPerPage { get; set; }
    [XmlElement(ElementName = "pageNumber", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PageNumber { get; set; }
    [XmlElement(ElementName = "totalEntries", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TotalEntries { get; set; }
    [XmlElement(ElementName = "totalPages", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TotalPages { get; set; }
}
