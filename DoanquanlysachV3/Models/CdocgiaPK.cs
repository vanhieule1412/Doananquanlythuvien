using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CdocgiaPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaDocGia = value.ToString();
            Models.DOCGIA a = dc.DOCGIAs.Find(MaDocGia);
            if (a == null) return true;
            return false;
        }
    }
}