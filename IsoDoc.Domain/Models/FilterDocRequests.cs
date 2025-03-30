using IsoDoc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class FilterDocRequests
    {
        public string CreatorPersonCode { get; set; } = null;
        public string ReceiverPersonCode { get; set; } = null;
        public string SenderPersonCode { get; set; } = null;
        public DocRequestStatus? DocRequestStatus { get; set; } = null;
        public bool? Active { get; set; } = null;
    }
}
