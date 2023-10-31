using System.Xml.Serialization;

namespace ebay.Sharp.Features.Finding.Models;

[XmlRoot(ElementName = "sellerInfo", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
public class SellerInfo {
    [XmlElement(ElementName = "feedbackRatingStar", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string FeedbackRatingStar { get; set; }
    [XmlElement(ElementName = "feedbackScore", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string FeedbackScore { get; set; }
    [XmlElement(ElementName = "positiveFeedbackPercent", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string PositiveFeedbackPercent { get; set; }
    [XmlElement(ElementName = "sellerUserName", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string SellerUserName { get; set; }
    [XmlElement(ElementName = "topRatedSeller", Namespace = "http://www.ebay.com/marketplace/search/v1/services")]
    public string TopRatedSeller { get; set; }
}
