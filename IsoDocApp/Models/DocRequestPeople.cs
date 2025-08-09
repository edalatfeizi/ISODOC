using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Models
{

    public class DocRequestPeople
    {
        [Display(Name = "شماره پرسنلی", Order = 1)]
        [Editable(false)]
        public string PersonCode { get; set; }
        [Display(Name = "گیرنده پیام", Order = 2)]
        [Editable(false)]
        public string Name { get; set; }
        [Display(Name = "پست", Order = 3)]
        [Editable(false)]
        public string Post { get; set; }
    }
}
