using IsoDoc.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Entities
{
    public class DocRequest : BaseEntity
    {
        [Display(Name = "شماره سند", Order =1)]
        [Editable(false)]
        public int DocId { get; set; }

        [Display(Name = "کد سند", Order = 2)]
        [Editable(false)]
        public string DocCode { get; set; }

        [Display(Name = "واحد درخواست کننده", Order = 3)]
        [Editable(false)]
        public string CreatorDep { get; set; }

        [Display(Name = "واحد متولی سند", Order = 4)]
        [Editable(false)]
        public string DocOwnerDep { get; set; }

        [Display(Name = "نوع درخواست", Order = 5)]
        [Editable(false)]
        public DocRequestType DocRequestType { get; set; }

        [Display(Name = "عنوان درخواست", Order = 6)]
        [Editable(false)]
        public string Title { get; set; }

        [Display(Name = "نوع سند", Order = 7)]
        [Editable(false)]
        public string DocType { get; set; }

        [Display(Name = "مدت زمان نگهداری", Order = 8)]
        [Editable(false)]
        public string KeepDuration { get; set; }

        [Display(Name = "شرح تغییرات", Order = 9)]
        [Editable(false)]
        public string ChangeSummary { get; set; }

        [Display(Name = "علت تغییر/حذف/ایجاد سند", Order = 10)]
        [Editable(false)]
        public string CreateReason { get; set; }

        [Display(Name = "فایل پیوست", Order = 11)]
        [Editable(false)]
        public string HasAttachments { get; set; }

        [Display(Name = "علت لغو درخواست", Order = 12)]
        [Editable(false)]
        public string CancelDesc { get; set; }

        [Display(Name = "علت حذف درخواست", Order = 13)]
        [Editable(false)]
        public string DeleteDesc { get; set; }

        [Display(Name = "وضعیت درخواست", Order = 14)]
        [Editable(false)]
        public DocRequestStatus DocRequestStatus { get; set; }

        [Browsable(false)]
        public string CreatedBy { get; set; }
        //public ICollection<DocRequestAttachment> DocRequestAttachments { get; set; }
    }
}
