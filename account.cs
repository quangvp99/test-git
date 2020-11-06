namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required(ErrorMessage ="Không được để trống!")]
        [DisplayName("Tên đăng nhập")]
        [StringLength(100)]
        public string username { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Họ và tên")]
        [StringLength(100)]
        public string fullname { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Số điện thoại")]
        public int phone { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Mật khẩu"),DataType(DataType.Password)]
        [StringLength(50)]
        public string passwords { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Email"),DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string email { get; set; }
    }
}
