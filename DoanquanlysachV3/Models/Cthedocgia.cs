using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class Cthedocgia
    {
        [CthedocgiaPK(ErrorMessage ="Trùng Khóa chính")]
        [Required(ErrorMessage = "Nhập mã thẻ độc giả")]
        [Display(Name = "Mã Thẻ Độc Giả")]
        public string MaTheDocGia { get; set; }
        [Display(Name = "Tên Độc Giả")]
        public string TenDocGia { get; set; }
        [Required(ErrorMessage = "Nhập ngày tạo")]
        [Display(Name = "Ngày Tạo")]
        public Nullable<System.DateTime> NgayTao { get; set; }
        [Required(ErrorMessage = "Nhập ngày hết")]
        [Display(Name = "Ngày Hết")]
        public Nullable<System.DateTime> NgayHet { get; set; }
        [Display(Name = "Mã độc giả")]
        public string MaDocGia { get; set; }
    }
}