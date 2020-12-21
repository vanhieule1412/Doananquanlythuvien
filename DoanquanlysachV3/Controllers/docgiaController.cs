using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class docgiaController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: docgia
        public ActionResult IndexDG()
        {
            return View(dc.DOCGIAs.ToList());
        }
      
      
        public ActionResult Formthemdocgia()
        {
            //ViewBag.tenDG = dc.THEDOCGIAs.ToList();
            return View();
        }
    
        [HttpPost]
        public ActionResult themdocgia(DoanquanlysachV3.Models.DOCGIA dOCGIA)
        {
            if (ModelState.IsValid)
            {
                
                dc.DOCGIAs.Add(dOCGIA);
                dc.SaveChanges();
            }
           
            return RedirectToAction("IndexDG");
        }
        public ActionResult Formsuadocgia(string id)
        {
            DoanquanlysachV3.Models.DOCGIA dOCGIA = dc.DOCGIAs.Find(id);
            return View(dOCGIA);
        }
        [HttpPost]
        public ActionResult suadocgia(Models.DOCGIA dOCGIA)
        {
            DoanquanlysachV3.Models.DOCGIA oCGIA = dc.DOCGIAs.Find(dOCGIA.MaDocGia);
            if (ModelState.IsValid)
            {
                oCGIA.TenDocGia = dOCGIA.TenDocGia;
                dc.SaveChanges();
            }

            return RedirectToAction("IndexDG");
        }
        public ActionResult Formxoadocgia(string id)
        {
            DoanquanlysachV3.Models.DOCGIA dOCGIA = dc.DOCGIAs.Find(id);
            //if (dOCGIA != null)
            //{
            //    dc.DOCGIAs.Remove(dOCGIA);
            //    dc.SaveChanges();
            //}

            return View(dOCGIA);
        }
        public ActionResult xoadocgia(string id)
        {
            DoanquanlysachV3.Models.DOCGIA dOCGIA = dc.DOCGIAs.Find(id);
            if (dOCGIA != null)
            {
                dc.DOCGIAs.Remove(dOCGIA);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexDG");
        }

        public ActionResult Formtaothedocgia(string id)
        {
            Models.DOCGIA dg = dc.DOCGIAs.Find(id);
            ViewBag.tenDG = dg.TenDocGia;
            ViewBag.Thedocgia = id;
            return View();
        }
      
        [HttpPost]
        public ActionResult taothedocgia(DoanquanlysachV3.Models.THEDOCGIA tHEDOCGIA,Models.DOCGIA dOCGIA)
        {
            if (ModelState.IsValid  )
            {
                dc.THEDOCGIAs.Add(tHEDOCGIA);
                dc.SaveChanges();
            }
            else
            {
                ModelState.AddModelError("MaDocGia", "Mã đã tồn tại ");
                return View("Formtaothedocgia");
            }
            return RedirectToAction("IndexDG");
            
        }


    }
}