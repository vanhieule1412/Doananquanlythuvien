using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class theloaiController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: theloai
        public ActionResult IndexTL()
        {
            return View(dc.THELOAIs.ToList());
        }
        public ActionResult Formthemtheloai()
        {
            return View();
        }
        [HttpPost]
        public ActionResult themtheloai(DoanquanlysachV3.Models.THELOAI tHELOAI)
        {
            if (ModelState.IsValid)
            {
                dc.THELOAIs.Add(tHELOAI);
                dc.SaveChanges();
                return RedirectToAction("IndexTL");
            }
            return View("Formthemtheloai");
            
            
        }
        public ActionResult Formsuatheloai(string id)
        {
            DoanquanlysachV3.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }
        public ActionResult suatheloai(DoanquanlysachV3.Models.THELOAI tHELOAI)
        {
            DoanquanlysachV3.Models.THELOAI hELOAI = dc.THELOAIs.Find(tHELOAI.MaTheLoai);
            if (hELOAI != null)
            {
                hELOAI.MaTheLoai = tHELOAI.MaTheLoai;
                hELOAI.TenTheLoai = tHELOAI.TenTheLoai;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTL");
        }
        public ActionResult Formxoatheloai(string id)
        {
            DoanquanlysachV3.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            if (tHELOAI != null)
            {
                return View(tHELOAI);
            }
            return RedirectToAction("IndexTL");

        }
        public ActionResult xoatheloai(string id)
        {
            DoanquanlysachV3.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            if (tHELOAI != null)
            {
                dc.THELOAIs.Remove(tHELOAI);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexTL");

        }
        public ActionResult xemthongtintheloai(string id)
        {
            DoanquanlysachV3.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }
    }
}