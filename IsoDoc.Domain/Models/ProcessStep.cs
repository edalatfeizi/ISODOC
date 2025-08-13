using IsoDoc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class ProcessStep 
    {
        public int Index { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ProcessStepStatus Status { get; set; }
        public string CreatedAt { get; set; }
    }
}
