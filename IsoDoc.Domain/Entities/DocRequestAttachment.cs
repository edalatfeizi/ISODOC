
using System.ComponentModel;

namespace IsoDoc.Domain.Entities
{
    public class DocRequestAttachment : FileAttachment
    {
        [Browsable(false)]
        public int DocRequestId { get; set; }

    }
    
    
}
