using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Entities
{
    public class FileAttachment : BaseEntity
    {

        [Display(Name = "نام فایل", Order = 2)]
        [Editable(false)]
        public string Name { get; set; }

        [Display(Name = "نوع فایل", Order = 3)]
        [Editable(false)]
        public string ContentType { get; set; }

        [Browsable(false)]
        public byte[]? FileContent { get; set; }

        [Browsable(false)]
        public long Size { get; set; }

        [Display(Name = "حجم فایل (MB)", Order = 4)]
        [Editable(false)]
        public double SizeInMB => Math.Round(Size / (1024.0 * 1024.0), 1);

        [Display(Name = "آپلود شده توسط", Order = 5)]
        [Editable(false)]
        public string UploadedBy { get; set; }

        [Display(Name = "زمان آپلود", Order = 6)]
        [Editable(false)]
        public string UploadDate { get; set; }

    }
}
