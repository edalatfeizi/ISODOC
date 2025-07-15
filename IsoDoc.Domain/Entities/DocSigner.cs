
using IsoDoc.Domain.Enums;

namespace IsoDoc.Domain.Entities
{
    public class DocSigner : BaseEntity
    {
        public int NewDocConfirmationId { get; set; }
        public string PersonCode { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public SignerColleagueType SignerType { get; set; }
        public int SigningOrder { get; set; }
        public bool IsSigned { get; set; }
        public string SigningDate { get; set; }
        public string SignRequestSentDate { get; set; }

    }
}
