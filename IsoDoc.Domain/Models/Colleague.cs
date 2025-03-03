
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Models
{
    public class Colleague
    {
        [Display(Name = "شماره پرسنلی")]
        public string PersonCode { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }
        [Display(Name = "پست")]
        public string Post { get; set; }

    }
}
