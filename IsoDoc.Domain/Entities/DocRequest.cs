using IsoDoc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Entities
{
    public class DocRequest : BaseEntity
    {
        public int DocId { get; set; }
        public string DocOwnerDep { get; set; }
        public string DocCode { get; set; }
        public string Title { get; set; }
        public string KeepDuration { get; set; }
        public string ChangeSummary { get; set; }
        public string CreateReason { get; set; }
        public DocRequestType DocRequestType { get; set; }
        public string DocType { get; set; }
        public string CreatorDep { get; set; }
        //public ICollection<DocRequestAttachment> DocRequestAttachments { get; set; }
    }
}
