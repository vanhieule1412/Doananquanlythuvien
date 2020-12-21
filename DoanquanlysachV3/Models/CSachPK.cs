using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CSachPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string masach = value.ToString();
            Models.SACH sACH = dc.SACHes.Find(masach);
            if (sACH == null) return true;
            return false;
        }
    }
}