using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class Document
    {
        [Display(Name = "شناسه سند")]
        public int DocId { get; set; }
        [Display(Name = "نام سند")]
        public string DocumentName { get; set; }
        [Display(Name = "کد سند")]
        public string DocumentCode { get; set; }
        [Display(Name = "مدت زمان نگهداری")]
        public string HistorySave { get; set; }
    }
}
