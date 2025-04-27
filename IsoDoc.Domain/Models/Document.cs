using System;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Models
{
    public class Document
    {
        [Display(Name = "ردیف")]
        public Int64 RowNumber { get; set; }
        [Display(Name = "کد سند")]
        public string DocumentCode { get; set; }
        [Display(Name = "شناسه سند")]
        public int DocId { get; set; }
        [Display(Name = "نام سند")]
        public string DocumentName { get; set; }
    
        [Display(Name = "نوع سند")]
        public string DocName { get; set; }
        [Display(Name = "مدت زمان نگهداری")]
        public string HistorySave { get; set; }
    }
}
