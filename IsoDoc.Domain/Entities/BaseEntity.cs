

using System;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
        public bool Active { get; set; }
    }

}

