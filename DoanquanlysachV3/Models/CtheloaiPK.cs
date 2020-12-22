using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CtheloaiPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaTheLoai = value.ToString();
            Models.THELOAI a = dc.THELOAIs.Find(MaTheLoai);
            if (a == null) return true;
            return false;
        }
    }
}