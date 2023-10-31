using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "error", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Error {
    [XmlElement(ElementName = "category", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Category { get; set; }
    [XmlElement(ElementName = "domain", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Domain { get; set; }
    [XmlElement(ElementName = "errorId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ErrorId { get; set; }
    [XmlElement(ElementName = "exceptionId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ExceptionId { get; set; }
    [XmlElement(ElementName = "message", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Message { get; set; }
    [XmlElement(ElementName = "parameter", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Parameter Parameter { get; set; }
    [XmlElement(ElementName = "severity", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Severity { get; set; }
    [XmlElement(ElementName = "subdomain", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Subdomain { get; set; }
}
