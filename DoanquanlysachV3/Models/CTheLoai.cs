using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoanquanlysachV3.Models
{
    public class CTheLoai
    {
        [Required(ErrorMessage ="Nhập mã số")]
        [Display(Name ="Mã Thể Loại")]
        public string MaTheLoai { get; set; }

        [Required(ErrorMessage ="Nhập Tên số")]
        [Display(Name = "Tên Thể Loại")]
        public string TenTheLoai { get; set; }
    }
}