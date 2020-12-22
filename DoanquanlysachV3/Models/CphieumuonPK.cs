using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class CphieumuonPK:ValidationAttribute
    {
        private Models.QuanLyThuVienEntities dc = new QuanLyThuVienEntities();
        public override bool IsValid(object value)
        {
            string MaPhieuMuon = value.ToString();
            Models.PHIEUMUON a = dc.PHIEUMUONs.Find(MaPhieuMuon);
            if (a == null) return true;
            return false;
        }
    }
}