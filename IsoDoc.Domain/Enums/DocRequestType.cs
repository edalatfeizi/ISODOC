using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Enums
{
    public enum DocRequestType
    {
        [Display(Name = "ایجاد")]
        Create,
        [Display(Name = "تغییر")]
        Update,
        [Display(Name = "حذف")]
        Delete,
    }
}
