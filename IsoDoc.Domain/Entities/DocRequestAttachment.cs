using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Entities
{
    public class DocRequestAttachment : BaseEntity
    {
        public int DocRequestId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] FileContent { get; set; }
        public long Size { get; set; }

        //public int ParentDocRequestId { get; set; }
        //[ForeignKey("ParentDocRequestId")]
        //public virtual DocRequest DocRequest { get; set; }
    }
}
