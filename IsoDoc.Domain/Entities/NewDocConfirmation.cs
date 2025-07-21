
namespace IsoDoc.Domain.Entities
{
    public class NewDocConfirmation : BaseEntity
    {
        public int DocReqId { get; set; }
        public string DocOwnerDepCode { get; set; }
        public string DocTitle { get; set; }
        public string DocCode { get; set; }
        public string ReviewNo { get; set; }
        public string ReviewText { get; set; }
    }
}
