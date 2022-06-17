namespace WebsiteDuLichDiaPhuong.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOURDULICH")]
    public partial class TOURDULICH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTour { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTour { get; set; }

        [Required]
        [StringLength(50)]
        public string MieuTa { get; set; }

        public int GiaTien { get; set; }

        public int MaHuyen { get; set; }

        public int MaTinTuc { get; set; }

        public int MaHinhAnh { get; set; }

        public int MaVideo { get; set; }

        public virtual HINHANH HINHANH { get; set; }

        public virtual HUYEN HUYEN { get; set; }

        public virtual TINTUC TINTUC { get; set; }
    }
}
