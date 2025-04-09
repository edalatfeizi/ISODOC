using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class SearchResult
    {
        [Display(Name = "ردیف", Order = 0)]
        [Editable(false)]
        public int RowId { get; set; }

        [Display(Name = "کد سند", Order = 0)]
        [Editable(false)]
        public string DocumentCode { get; set; }

        [Display(Name = "نام سند", Order = 1)]
        [Editable(false)]
        public string DocumentName { get; set; }

        [Display(Name = "نوع سند", Order = 2)]
        [Editable(false)]
        public string DocName { get; set; }
        [Display(Name = "شماره بازنگری", Order = 3)]
        [Editable(false)]
        public string RevisionNo { get; set; }

        [Display(Name = "تاریخ بازنگری", Order = 4)]
        [Editable(false)]
        public string RevisionDate { get; set; }

        //[Display(Name = "مدت زمان نگهداری", Order = 0)]
        //[Editable(false)]
        //public string HistorySave { get; set; }

        [Browsable(false)]
        public string DocPath { get; set; }

        [Browsable(false)]
        public string DocSettingPath { get; set; }

        [Browsable(false)]
        public string DocTypeID { get; set; }

        [Browsable(false)]
        public string MainId { get; set; }

        [Browsable(false)]
        public string IsoDocViewID { get; set; }

        [Browsable(false)]
        public string mdepartid { get; set; }

        [Browsable(false)]
        public string IsShowPublic { get; set; }

        [Browsable(false)]
        public string PersonCode { get; set; }

    }
}
