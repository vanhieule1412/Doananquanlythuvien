using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CnxbPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaNhaXuatBan = value.ToString();
            Models.NHAXUATBAN a = dc.NHAXUATBANs.Find(MaNhaXuatBan);
            if (a == null) return true;
            return false;
        }
    }
}