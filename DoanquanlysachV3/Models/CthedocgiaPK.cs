using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CthedocgiaPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaTheDocGia = value.ToString();
            Models.THEDOCGIA a = dc.THEDOCGIAs.Find(MaTheDocGia);
            if (a == null) return true;
            return false;
        }
    }
}