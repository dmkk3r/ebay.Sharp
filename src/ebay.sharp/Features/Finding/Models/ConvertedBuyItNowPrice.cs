using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "convertedBuyItNowPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class ConvertedBuyItNowPrice {
    [XmlAttribute(AttributeName = "currencyId")]
    public string CurrencyId { get; set; }
    [XmlText]
    public string Text { get; set; }
}
