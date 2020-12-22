using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class Cnxb
    {
        [CnxbPK(ErrorMessage ="Trùng khóa chính")]
        [Required(ErrorMessage = "Nhập mã nxb")]
        [Display(Name = "Mã Nhà Xuất Bản")]
        public string MaNhaXuatBan { get; set; }
        [Required(ErrorMessage = "Nhập tên nxb")]
        [Display(Name = "Tên Nhà Xuất Bản")]
        public string TenNhaXuatBan { get; set; }
    }
}