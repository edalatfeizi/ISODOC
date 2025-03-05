using IsoDoc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Entities
{
    public class DocRequest : BaseEntity
    {
        [Display(Name = "شماره سند", Order =1)]
        [Editable(false)]
        public int DocId { get; set; }

        [Display(Name = "واحد متولی سند", Order = 4)]
        [Editable(false)]
        public string DocOwnerDep { get; set; }

        [Display(Name = "کد سند", Order = 2)]
        [Editable(false)]
        public string DocCode { get; set; }

        [Display(Name = "عنوان درخواست", Order = 6)]
        [Editable(false)]
        public string Title { get; set; }

        [Display(Name = "مدت زمان نگهداری", Order = 8)]
        [Editable(false)]
        public string KeepDuration { get; set; }

        [Display(Name = "شرح تغییرات", Order = 9)]
        //[Editable(false)]
        public string ChangeSummary { get; set; }

        [Display(Name = "علت تغییر/حذف/ایجاد سند", Order = 10)]
        //[Editable(false)]
        public string CreateReason { get; set; }

        [Display(Name = "نوع درخواست", Order = 5)]
        [Editable(false)]
        public DocRequestType DocRequestType { get; set; }

        [Display(Name = "نوع سند", Order = 7)]
        [Editable(false)]
        public string DocType { get; set; }

        [Display(Name = "واحد درخواست کننده", Order = 3)]
        [Editable(false)]
        public string CreatorDep { get; set; }
        //public ICollection<DocRequestAttachment> DocRequestAttachments { get; set; }
    }
}
