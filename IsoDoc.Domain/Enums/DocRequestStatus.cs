using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Enums
{
    public enum DocRequestStatus
    {
        [Display(Name = "در حال بررسی")]
        InProgress,
        [Display(Name = "تکمیل شده")]
        Completed,
        [Display(Name = "لغو شده")]
        Canceled,
        [Display(Name = "حذف شده")]
        Deleted,
    }
}
