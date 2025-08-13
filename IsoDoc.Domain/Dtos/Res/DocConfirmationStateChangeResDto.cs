using IsoDoc.Domain.Enums;


namespace IsoDoc.Domain.Dtos.Res
{
    public class DocConfirmationStateChangeResDto : BaseDto
    {
        public int DocConfirmationId { get; set; }
        public string SenderUserPersonCode { get; set; }
        public string SenderUserFullName { get; set; }
        public string SenderUserPost { get; set; }
        public string ReceiverUserPersonCode { get; set; }
        public string ReceiverUserFullName { get; set; }
        public string ReceiverUserPost { get; set; }
        public string Description { get; set; }
        public DocConfirmationStatus Status { get; set; }

    }
}

