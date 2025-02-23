using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Entities
{
    public class DocRequestStep : BaseEntity
    {
        public int DocRequestId { get; set; }
        public string SenderUserPersonCode { get; set; }
        public string SenderUserFullName { get; set; }
        public string SenderUserPost { get; set; }
        public string ReceiverUserPersonCode { get; set; }
        public string ReceiverUserFullName { get; set; }
        public string ReceiverUserPost { get; set; }
        public string Description { get; set; }
        public string IsApproved { get; set; }

        //public int ParentDocRequestId { get; set; }
        //[ForeignKey("ParentDocRequestId")]
        //public virtual DocRequest DocRequest { get; set; }
    }
}
