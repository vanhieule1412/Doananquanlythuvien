﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class thedocgiaController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: thedocgia
        public ActionResult IndexTDG()
        {
            return View(dc.THEDOCGIAs.ToList());
        }
        public ActionResult Formxoathedocgia(string id)
        {
            Models.THEDOCGIA tHEDOCGIA = dc.THEDOCGIAs.Find(id);
            ViewBag.mathedocgia = tHEDOCGIA.MaTheDocGia;
            ViewBag.DsSach = dc.SACHes.ToList();
            ViewBag.Dsthedocgia = dc.THEDOCGIAs.ToList();
            bool coXoa = true;
           
            foreach (Models.PHIEUMUON t in dc.PHIEUMUONs.Where(x => x.MaTheDocGia == id))
            {
                coXoa = false;
                break;
            }
            ViewBag.XoaThehocvien = coXoa;
            if (tHEDOCGIA != null)
            {
              
                return View(tHEDOCGIA);
            }
            return RedirectToAction("IndexTDG");

          
        }
        public ActionResult xoathedocgia(string id)
        {
            Models.THEDOCGIA tHEDOCGIA = dc.THEDOCGIAs.Find(id);
            if (tHEDOCGIA!=null)
            {
                dc.THEDOCGIAs.Remove(tHEDOCGIA);
                dc.SaveChanges();
            }
            ViewBag.mathedocgia = tHEDOCGIA.MaTheDocGia;
            ViewBag.DsSach = dc.SACHes.ToList();
            ViewBag.Dsthedocgia = dc.THEDOCGIAs.ToList();
            return RedirectToAction("IndexTDG");
        }
        public ActionResult Formthemphieumuon(string id)
        {
            Models.THEDOCGIA tHEDOCGIA = dc.THEDOCGIAs.Find(id);
            ViewBag.mathedocgia = tHEDOCGIA.MaTheDocGia;
            ViewBag.DsSach = dc.SACHes.ToList();
            ViewBag.Dsthedocgia = dc.THEDOCGIAs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult themphieumuon(DoanquanlysachV3.Models.PHIEUMUON pHIEUMUON)
        {
            if (ModelState.IsValid)
            {
                List<Models.SACH> ds = Session["DSsach"] as List<Models.SACH>;
            //dc.TACGIAs.AddRange(ds);
            foreach (var item in ds)
            {
                pHIEUMUON.SACHes.Add(dc.SACHes.Find(item.MaSach));
            }
            
                dc.PHIEUMUONs.Add(pHIEUMUON);
                dc.SaveChanges();
                return RedirectToAction("IndexTDG");
            }
            ViewBag.DsSach = dc.SACHes.ToList();
            ViewBag.Dsthedocgia = dc.THEDOCGIAs.ToList();
            return View("Formthemphieumuon");
        }
        public ActionResult chonnhieusach(string id)
        {
            List<Models.SACH> ds = Session["DSsach"] as List<Models.SACH>;
            DoanquanlysachV3.Models.SACH a = dc.SACHes.Find(id);
            if (a != null)
            {
                if (ds.Find(x => x.MaSach == a.MaSach) == null)
                {
                    ds.Add(a);
                }
            }
            return View(ds);
        }
    }
}