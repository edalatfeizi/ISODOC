

using IsoDoc.Domain.Attrs;
using IsoDoc.Domain.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [Display(Name = "شناسه", Order = 0)]
        [Editable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public string CreatedBy { get; set; }

        [Browsable(false)]
        public string ModifiedBy { get; set; }

        //[DisplayAsIs]
        [Browsable(false)]
        public string CreatedAt { get; set; } = DateTime.Now.ToPersianDateTime();

        //[DisplayAsIs]
        [Browsable(false)]
        public string ModifiedAt { get; set; } = DateTime.Now.ToPersianDateTime();

        [Display(Name = "وضعیت")]
        [Browsable(false)] //prevent it to be displayed on grid view
        //[DisplayFormat(DataFormatString ="{0:active;unactive}")]
        public bool Active { get; set; } = true;
    }

}

