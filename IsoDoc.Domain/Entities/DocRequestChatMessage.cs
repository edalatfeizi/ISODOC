using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Entities
{
    public class DocRequestChatMessage : BaseEntity
    {
        public int DocRequestId { get; set; }
        public string SenderUserPersonCode { get; set; }
        public string SenderUserFullName { get; set; }
        public string SenderUserPost { get; set; }
        public string ReceiverUserPersonCode { get; set; }
        public string ReceiverUserFullName { get; set; }
        public string ReceiverUserPost { get; set; }
        public string Message { get; set; }
    }
}
