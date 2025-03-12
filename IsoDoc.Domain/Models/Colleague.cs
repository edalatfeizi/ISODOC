
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Models
{
    public class Colleague
    {
        [Display(Name = "شماره پرسنلی")]
        public string PersonCode { get; set; }

        [Browsable(false)]
        public string CardNumber { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }

        [Display(Name = "پست")]
        public string Post { get; set; }

    }
}
