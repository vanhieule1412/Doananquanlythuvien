using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class nhaxuatbanController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: nhaxuatban
        public ActionResult IndexNXB()
        {
            return View(dc.NHAXUATBANs.ToList());
        }
        public ActionResult Formthemnhaxuatban()
        {
            return View();
        }
        [HttpPost]
        public ActionResult themnhaxuatban(DoanquanlysachV3.Models.NHAXUATBAN nHAXUATBAN)
        {
            if (ModelState.IsValid)
            {
                dc.NHAXUATBANs.Add(nHAXUATBAN);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexNXB");
        }
        public ActionResult Formsuanhaxuatban(string id)
        {
            DoanquanlysachV3.Models.NHAXUATBAN nHAXUATBAN = dc.NHAXUATBANs.Find(id);
            return View(nHAXUATBAN);
        }
        public ActionResult suanhaxuatban(DoanquanlysachV3.Models.NHAXUATBAN nHAXUATBAN)
        {
            DoanquanlysachV3.Models.NHAXUATBAN hAXUATBAN = dc.NHAXUATBANs.Find(nHAXUATBAN.MaNhaXuatBan);
            if (hAXUATBAN != null)
            {
                hAXUATBAN.MaNhaXuatBan = nHAXUATBAN.MaNhaXuatBan;
                hAXUATBAN.TenNhaXuatBan = nHAXUATBAN.TenNhaXuatBan;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexNXB");
        }
        public ActionResult Formxoanhaxuatban(string id)
        {
            DoanquanlysachV3.Models.NHAXUATBAN nHAXUATBAN = dc.NHAXUATBANs.Find(id);
            if (nHAXUATBAN != null)
            {
                return View(nHAXUATBAN);
            }
            return RedirectToAction("IndexNXB");

        }
        public ActionResult xoanhaxuatban(string id)
        {
            DoanquanlysachV3.Models.NHAXUATBAN nHAXUATBAN = dc.NHAXUATBANs.Find(id);
            if (nHAXUATBAN != null)
            {
                dc.NHAXUATBANs.Remove(nHAXUATBAN);
                dc.SaveChanges();
            }
            
            return RedirectToAction("IndexNXB");

        }
    
    }
}