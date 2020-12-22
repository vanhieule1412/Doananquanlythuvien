using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class tacgiaController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: tacgia
        public ActionResult IndexTG()
        {
            
            return View(dc.TACGIAs.ToList());
        }
        public ActionResult Formthemtacgia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult themtacgia(DoanquanlysachV3.Models.TACGIA tACGIA)
        {
            if (ModelState.IsValid)
            {
                dc.TACGIAs.Add(tACGIA);
                dc.SaveChanges();
                return RedirectToAction("IndexTG");
            }
            return View("Formthemtacgia");
            
        }
        public ActionResult Formsuatacgia(string id)
        {
            DoanquanlysachV3.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
        public ActionResult suatacgia(DoanquanlysachV3.Models.TACGIA tACGIA)
        {
            DoanquanlysachV3.Models.TACGIA aCGIA = dc.TACGIAs.Find(tACGIA.MaTacGia);
            if (aCGIA != null)
            {
                aCGIA.MaTacGia = tACGIA.MaTacGia;
                aCGIA.TenTacGia = tACGIA.TenTacGia;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTG");
        }
        public ActionResult Formxoatacgia(string id)
        {
            DoanquanlysachV3.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            if (tACGIA != null)
            {
                return View(tACGIA);
            }
            return RedirectToAction("IndexTG");

        }
        public ActionResult xoatacgia(string id)
        {
            DoanquanlysachV3.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            if (tACGIA != null)
            {
                dc.TACGIAs.Remove(tACGIA);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexTG");

        }
        public ActionResult xemthongtintacgia(string id)
        {
            DoanquanlysachV3.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
    }
}