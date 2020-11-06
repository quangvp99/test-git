namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int proid { get; set; }

        [Required(ErrorMessage ="Không được để trống!")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(50)]
        public string proname { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [Column(TypeName ="numeric")]
        [DisplayName("Gía")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Tên khác")]
        [StringLength(50)]
        public string stock { get; set; }

        [Column(TypeName ="text")]
        [DisplayName("Hình ảnh")]
        [StringLength(100)]
        public string images { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Mô tả"),DataType(DataType.MultilineText)]
        [StringLength(100)]
        public string descriptions { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        public int catid { get; set; }

        public virtual category category { get; set; }
    }
}
