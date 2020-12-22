using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoanquanlysachV3.Models
{
    public class Cdocgia
    {
        [CdocgiaPK(ErrorMessage ="Trùng khóa chính")]
        [Required(ErrorMessage = "Nhập mã độc giả")]
        [Display(Name = "Mã Độc Giả")]
        public string MaDocGia { get; set; }
        [Required(ErrorMessage = "Nhập tên độc giả")]
        [Display(Name = "Tên Độc Giả")]
        public string TenDocGia { get; set; }
    }
}