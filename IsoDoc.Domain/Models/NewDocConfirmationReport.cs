using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class NewDocConfirmationReport
    {
        public NewDocConfirmationResDto Document { get; set; }
        public List<DocSignerResDto> Signers { get; set; }
        public string UserName { get; set; }
        public string PersonCode { get; set; }
        public string Environment { get; set; }
        public string IpAddress { get; set; }
        public string FormName { get; set; }
        public string PrintDate { get; set; } = DateTime.Now.ToPersianDateTime();
        public string ConfirmDate { get; set; } 
        public NewDocConfirmationReport(NewDocConfirmationResDto doc, List<DocSignerResDto> signers)
        {
            Document = doc;
            Signers = signers;
        }
    }
}
