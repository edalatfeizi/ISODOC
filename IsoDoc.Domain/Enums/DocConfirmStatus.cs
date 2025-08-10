using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Enums
{
    public enum DocConfirmStatus
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
