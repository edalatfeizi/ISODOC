
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Entities
{
    public class PersonSignature : FileAttachment
    {

        [Display(Name = "کد پرسنلی", Order = 1)]
        [Editable(false)]
        public string PersonCode { get; set; }

    }
    
    
}
