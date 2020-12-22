using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CtacgiaPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaTacGia = value.ToString();
            Models.TACGIA a = dc.TACGIAs.Find(MaTacGia);
            if (a == null) return true;
            return false;
        }
    }
}