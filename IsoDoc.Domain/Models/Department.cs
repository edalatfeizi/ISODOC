using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class Department
    {
        [Display(Name = "نام واحد")] // used to show as column caption in LookupEdit components  
        public string MDepartName { get; set; }
        [Display(Name = "کد واحد")]
        public string MDepartCode { get; set; }
    }
}
