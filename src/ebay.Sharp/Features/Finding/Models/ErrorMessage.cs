using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "errorMessage", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ErrorMessage {
    [XmlElement(ElementName = "error", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Error Error { get; set; }
}
