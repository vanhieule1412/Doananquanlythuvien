using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoanquanlysachV3.Models
{
    public class CSach
    {
        [CSachPK(ErrorMessage ="Trùng khóa chính")]
        [Required(ErrorMessage = "Nhập mã sách")]
        [Display(Name = "Mã Sách")]
        public string MaSach { get; set; }
        [Required(ErrorMessage = "Nhập tên sách")]
        [Display(Name = "Tên Sách")]
        public string TenSach { get; set; }
        [Required(ErrorMessage = "Nhập số lượng sách")]
        [Display(Name = "Số Lượng Sách")]
        public Nullable<int> SoLuong { get; set; }
        [Required(ErrorMessage = "Nhập tên thể loại")]
        [Display(Name = "Mã Thể Loại")]
        public string MaTheLoai { get; set; }
        [Required(ErrorMessage = "Nhập tên nhà xuất bản")]
        [Display(Name = "Mã Nhà xuất bản")]
        public string MaNhaXuatBan { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        public virtual THELOAI THELOAI { get; set; }
        [Required(ErrorMessage = "Nhập tên tác giả")]

        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        [Required(ErrorMessage = "Nhập tác giả")]
        public virtual ICollection<TACGIA> TACGIAs { get; set; }
    }
}