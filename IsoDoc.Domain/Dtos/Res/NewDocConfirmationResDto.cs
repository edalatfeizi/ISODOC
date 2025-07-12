
using System.ComponentModel;

namespace IsoDoc.Domain.Dtos.Res
{
    public class NewDocConfirmationResDto : BaseDto
    {
        [Browsable(false)]
        public string DocOwnerDepCode { get; set; }
        public string DocTitle { get; set; }
        public string DocCode { get; set; }
        public string ReviewNo { get; set; }
        public string ReviewText { get; set; }
    }
}
