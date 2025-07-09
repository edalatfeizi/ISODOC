
namespace IsoDoc.Domain.Dtos
{
    public class NewDocConfirmationDto
    {
        public string OwnerDepCode { get; set; }
        public string DocTitle { get; set; }
        public string DocCode { get; set; }
        public string ReviewNo { get; set; }
        public string ReviewText { get; set; }
        public string CreatorUserPersonCode { get; set; }
    }
}
