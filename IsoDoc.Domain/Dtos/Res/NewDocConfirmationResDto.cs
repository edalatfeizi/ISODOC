
using IsoDoc.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Dtos.Res
{
    public class NewDocConfirmationResDto : BaseDto
    {
        [Browsable(false)]
        public string DocOwnerDepCode { get; set; }

        [Display(Name = "شماره درخواست", Order = 1)]
        [Editable(false)]
        public int DocReqId { get; set; }

        [Display(Name = "کد سند", Order = 2)]
        [Editable(false)]
        public string DocCode { get; set; }

        [Display(Name = "عنوان سند", Order = 3)]
        [Editable(false)]
        public string DocTitle { get; set; }

        [Display(Name = "شماره بازنگری", Order = 4)]
        [Editable(false)]
        public string ReviewNo { get; set; }

        [Display(Name = "شرح بازنگری", Order = 5)]
        [Editable(false)]
        public string ReviewText { get; set; }

        [Display(Name = "وضعیت امضاء سند", Order = 6)]
        [Editable(false)]
        public DocRequestStatus ConfirmationStatus { get; set; }

    }
}
