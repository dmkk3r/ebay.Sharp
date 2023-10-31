using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "galleryURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class GalleryURL {
    [XmlAttribute(AttributeName = "gallerySize")]
    public string GallerySize { get; set; }
    [XmlText]
    public string Text { get; set; }
}
