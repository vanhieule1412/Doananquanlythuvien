using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class Cphieumuon
    {
        [CphieumuonPK(ErrorMessage ="Trùng khóa chính")]
        [Required(ErrorMessage = "Nhập mã phiếu mượn")]
        [Display(Name = "Mã Phiếu Mượn")]
        public string MaPhieuMuon { get; set; }
        [Required(ErrorMessage = "Nhập ngày mượn")]
        [Display(Name = "Ngày Mượn")]
        public Nullable<System.DateTime> NgayMuon { get; set; }
        [Required(ErrorMessage = "Nhập ngày trả")]
        [Display(Name = "Ngày Trả")]
        public Nullable<System.DateTime> NgayTra { get; set; }
        
        [Display(Name = "Mã Thẻ Độc Giả")]
        public string MaTheDocGia { get; set; }
        [Required(ErrorMessage = "Nhập Số Lượng Sách")]
        [Display(Name = "Số Lượng Sách Mượn")]
        public Nullable<int> SoLuongSachMuon { get; set; }
    }
}