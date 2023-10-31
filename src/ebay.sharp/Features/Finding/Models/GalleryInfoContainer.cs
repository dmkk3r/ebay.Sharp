using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "galleryInfoContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class GalleryInfoContainer {
    [XmlElement(ElementName = "galleryURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public GalleryURL GalleryURL { get; set; }
}
