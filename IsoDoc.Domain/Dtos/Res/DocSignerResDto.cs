using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Dtos.Res
{
    public class DocSignerResDto :BaseDto
    {
        [Browsable(false)]
        public int NewDocConfirmationId { get; set; }

        [Display(Name = "شماره پرسنلی", Order = 1)]
        [Editable(false)]
        public string PersonCode { get; set; }
        [Display(Name = "امضاء کننده", Order = 2)]
        [Editable(false)]
        public string Name { get; set; }
        [Display(Name = "پست", Order = 3)]
        [Editable(false)]
        public string Post { get; set; }

        [Display(Name = "نوع امضاء کننده", Order = 4)]
        [Editable(false)]
        public string SignerType { get; set; }

        [Browsable(false)]        
        public int SigningOrder { get; set; }

        [Display(Name = "وضعیت امضاء", Order = 5)]
        [Editable(false)]
        public bool IsSigned { get; set; }

        [Display(Name = "زمان ثبت امضاء", Order = 6)]
        [Editable(false)]
        public string SigningDate { get; set; }


        [Display(Name = "زمان ارسال درخواست امضاء", Order = 6)]
        [Editable(false)]
        public string SignRequestSentDate { get; set; }
    }
}
