using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Models
{
    public class NewDocConfirmInfo
    {
        public Department Department { get; set; }
        public string DocCode { get; set; }
        public string ReviewNo { get; set; }
        public string ReviewText { get; set; }

    }
}
