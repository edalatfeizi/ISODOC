using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Dtos.Res
{
    public class DocSignerResDto :BaseDto
    {
        [Browsable(false)]
        public int NewDocConfirmationId { get; set; }

        [Display(Name = "شماره پرسنلی", Order = 0)]
        [Editable(false)]
        public string PersonCode { get; set; }
        [Display(Name = "امضاء کننده", Order = 0)]
        [Editable(false)]
        public string Name { get; set; }
        [Display(Name = "پست", Order = 0)]
        [Editable(false)]
        public string Post { get; set; }

        [Display(Name = "نوع امضاء کننده", Order = 0)]
        [Editable(false)]
        public string SignerType { get; set; }

        [Browsable(false)]        
        public int SigningOrder { get; set; }
        [Display(Name = "وضعیت امضاء", Order = 0)]
        [Editable(false)]
        public bool IsSigned { get; set; }
    }
}
