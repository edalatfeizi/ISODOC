using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Enums
{
    public enum EditOrReviewStatus
    {
        [Display(Name = "")]
        None = 0,
        [Display(Name = "با ویرایش انجام شود")]
        DoWithEdit = 1,
        [Display(Name = "با بازنگری انجام شود")]
        DoWithReview = 2,
       
    }
}
