using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class DocType
    {
        [Display(Name = "شناسه")]
        public int DocId { get; set; }
        [Display(Name = "نوع سند")]
        public string DocName { get; set; }
        
        public bool KeepDurationRequired { get; set; }
    }
}
