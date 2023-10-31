using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "item", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class Item {
    [XmlElement(ElementName = "attribute", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Attribute { get; set; }
    [XmlElement(ElementName = "autoPay", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string AutoPay { get; set; }
    [XmlElement(ElementName = "charityId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string CharityId { get; set; }
    [XmlElement(ElementName = "compatibility", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Compatibility { get; set; }
    [XmlElement(ElementName = "condition", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Condition Condition { get; set; }
    [XmlElement(ElementName = "country", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Country { get; set; }
    [XmlElement(ElementName = "discountPriceInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string DiscountPriceInfo { get; set; }
    [XmlElement(ElementName = "distance", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public Distance Distance { get; set; }
    [XmlElement(ElementName = "eBayPlusEnabled", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string EBayPlusEnabled { get; set; }
    [XmlElement(ElementName = "eekStatus", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string EekStatus { get; set; }
    [XmlElement(ElementName = "galleryInfoContainer", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public GalleryInfoContainer GalleryInfoContainer { get; set; }
    [XmlElement(ElementName = "galleryPlusPictureURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string GalleryPlusPictureURL { get; set; }
    [XmlElement(ElementName = "galleryURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string GalleryURL { get; set; }
    [XmlElement(ElementName = "globalId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string GlobalId { get; set; }
    [XmlElement(ElementName = "itemId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ItemId { get; set; }
    [XmlElement(ElementName = "listingInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ListingInfo ListingInfo { get; set; }
    [XmlElement(ElementName = "location", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Location { get; set; }
    [XmlElement(ElementName = "paymentMethod", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PaymentMethod { get; set; }
    [XmlElement(ElementName = "pictureURLLarge", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PictureURLLarge { get; set; }
    [XmlElement(ElementName = "pictureURLSuperSize", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PictureURLSuperSize { get; set; }
    [XmlElement(ElementName = "postalCode", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PostalCode { get; set; }
    [XmlElement(ElementName = "primaryCategory", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public PrimaryCategory PrimaryCategory { get; set; }
    [XmlElement(ElementName = "productId", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ProductId { get; set; }
    [XmlElement(ElementName = "returnsAccepted", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ReturnsAccepted { get; set; }
    [XmlElement(ElementName = "secondaryCategory", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public SecondaryCategory SecondaryCategory { get; set; }
    [XmlElement(ElementName = "sellerInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public SellerInfo SellerInfo { get; set; }
    [XmlElement(ElementName = "sellingStatus", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public SellingStatus SellingStatus { get; set; }
    [XmlElement(ElementName = "shippingInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public ShippingInfo ShippingInfo { get; set; }
    [XmlElement(ElementName = "storeInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public StoreInfo StoreInfo { get; set; }
    [XmlElement(ElementName = "subtitle", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Subtitle { get; set; }
    [XmlElement(ElementName = "title", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string Title { get; set; }
    [XmlElement(ElementName = "topRatedListing", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TopRatedListing { get; set; }
    [XmlElement(ElementName = "unitPrice", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string UnitPrice { get; set; }
    [XmlElement(ElementName = "viewItemURL", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string ViewItemURL { get; set; }
}
