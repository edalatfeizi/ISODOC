
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Dtos.Res
{
    public class NewDocConfirmationResDto : BaseDto
    {
        [Browsable(false)]
        public string DocOwnerDepCode { get; set; }

        [Display(Name = "عنوان سند", Order = 2)]
        [Editable(false)]
        public string DocTitle { get; set; }

        [Display(Name = "کد سند", Order = 1)]
        [Editable(false)]
        public string DocCode { get; set; }

        [Display(Name = "شماره بازنگری", Order = 3)]
        [Editable(false)]
        public string ReviewNo { get; set; }

        [Display(Name = "شرح بازنگری", Order = 4)]
        [Editable(false)]
        public string ReviewText { get; set; }
    }
}
