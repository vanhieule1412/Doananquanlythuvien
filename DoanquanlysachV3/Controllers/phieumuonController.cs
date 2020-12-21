using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class phieumuonController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: phieumuon
        public ActionResult IndexPM()
        {
            return View(dc.PHIEUMUONs.ToList());
        }
        public ActionResult Formxoaphieumuon(string id)
        {
            
            Models.PHIEUMUON pHIEUMUON = dc.PHIEUMUONs.Find(id);
          
           
            if (pHIEUMUON != null)
            {
                return View(pHIEUMUON);
            }
            return RedirectToAction("IndexPM");
        }
        //public ActionResult xoaphieumuon(string id)
        //{

        //    Models.PHIEUMUON pHIEUMUON = dc.PHIEUMUONs.Find(id);
        //    foreach (var item in pHIEUMUON.MaPhieuMuon)
        //    {
        //        if (pHIEUMUON != null)
        //        {
        //            dc.PHIEUMUONs.Remove(pHIEUMUON);
        //            dc.SaveChanges();
        //        }
        //    }
        //    return RedirectToAction("IndexPM");
        //}

    }
}