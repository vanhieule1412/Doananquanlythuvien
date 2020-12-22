using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoanquanlysachV3.Models
{
    public class Ctacgia
    {
        [CtacgiaPK(ErrorMessage ="Trùng khóa chính")]
        [Required(ErrorMessage = "Nhập mã tác giả")]
        [Display(Name = "Mã Tác Giả")]
        public string MaTacGia { get; set; }
        [Required(ErrorMessage = "Nhập tên tác giả")]
        [Display(Name = "Tên Tác Giả")]
        public string TenTacGia { get; set; }
    }
}