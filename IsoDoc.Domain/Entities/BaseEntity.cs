

using IsoDoc.Domain.Extensions;
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
        public string CreatedAt { get; set; } = DateTime.Now.ToPersianDateTime();
        public string ModifiedAt { get; set; } = DateTime.Now.ToPersianDateTime();
        public bool Active { get; set; } = true;
    }

}

