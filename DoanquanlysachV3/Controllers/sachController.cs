using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using DoanquanlysachV3.Models;

namespace DoanquanlysachV3.Controllers
{
    public class sachController : Controller
    {
        private DoanquanlysachV3.Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: sach
        public ActionResult IndexS()
        {
            return View(dc.SACHes.ToList());
        }
        public ActionResult Formsuasach(string id)
        {
            DoanquanlysachV3.Models.SACH sACH = dc.SACHes.Find(id);
            if (sACH != null)
            {
                ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
                ViewBag.DStheloai = dc.THELOAIs.ToList();
                ViewBag.DStacgia = dc.TACGIAs.ToList();
                return View(sACH);
            }
            return RedirectToAction("IndexS");
            
        }
        public ActionResult Formthemsach()
        {
            ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
            ViewBag.DStheloai = dc.THELOAIs.ToList();
            ViewBag.DStacgia = dc.TACGIAs.ToList();
            return View();
        }
        public ActionResult Formxemthongtinchitiet(string id)
        {
            Models.SACH sACH = dc.SACHes.Find(id);
            //List<Models.TACGIA> ds = Session["DStacgia"] as List<Models.TACGIA>;
              List<Models.Cchitietsachtacgia> ds = Session["DSchitiet"] as List<Models.Cchitietsachtacgia>;
            Cchitietsachtacgia cchitietsachtacgia = new Cchitietsachtacgia();
            
            //dc.TACGIAs.AddRange(ds);
            ViewBag.chitiet = cchitietsachtacgia;
          
            return View(sACH);
        }
        //public ActionResult xemnhieutacgia(string id)
        //{
        //    Models.SACH sACH= dc.SACHes.Find(id);
        //    List<Models.Cchitietsachtacgia> ds = Session["DSchitiet"] as List<Models.Cchitietsachtacgia>;
        //        if (sACH.MaSach == id)
        //        {
        //            if(ds.Find(x=>x.MaSach==sACH.MaSach)==null)
        //            {

        //            }

        //        }   
        //    return View(ds);
        //}


        //public ActionResult Formxoasach(string id)
        //{

        //    Models.SACH sACH = dc.SACHes.Find(id);

        //    //Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
        //    //List<Models.TACGIA> ds = Session["DStacgia"] as List<Models.TACGIA>;
        //    ////List<Models.SACH>dss =Session["DSsach"] as List<DoanquanlysachV3.Models.SACH>;
        //    //foreach ()
        //    //{

        //    //    coXoa = false;
        //    //    break;
        //    //}
        //    //ViewBag.XoaSach = coXoa;
        //    ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
        //    ViewBag.DStheloai = dc.THELOAIs.ToList();
        //    ViewBag.DStacgia = dc.TACGIAs.ToList();

        //    if (sACH != null)
        //    {
        //        return View(sACH);
        //    }
        //    return RedirectToAction("IndexS");

        //}
        //public ActionResult xoasach(string id)
        //{
        //    Models.SACH sACH = dc.SACHes.Find(id);
        //    List<Models.Cchitietsachtacgia> ds = Session["DSchitiet"] as List<Models.Cchitietsachtacgia>;
        //    //foreach (var item in)
        //    //{
        //    //sACH.TACGIAs.Remove(dc.TACGIAs.Find(item.MaTacGia));
        //    //}
        //    foreach (var item in ds)
        //    {

        //        sACH.MaSach.Remove(dc..Find(item.MaSach));
        //    }
            
        //    dc.SACHes.Remove(sACH);
        //    dc.SaveChanges();

        //    ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
        //    ViewBag.DStheloai = dc.THELOAIs.ToList();
        //    ViewBag.DStacgia = dc.TACGIAs.ToList();
        //    return RedirectToAction("IndexS");
        //}
        [HttpPost]
        public ActionResult suasach(DoanquanlysachV3.Models.SACH sACH)
        {
            DoanquanlysachV3.Models.SACH aCH = dc.SACHes.Find(sACH.MaSach);
            if (ModelState.IsValid)
                {
                    aCH.TenSach = sACH.TenSach;
                    aCH.MaTheLoai = sACH.MaTheLoai;
                    aCH.MaNhaXuatBan = sACH.MaNhaXuatBan;
                    aCH.SoLuong = sACH.SoLuong;
                    dc.SaveChanges();
                return RedirectToAction("IndexS");
                }
            ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
            ViewBag.DStheloai = dc.THELOAIs.ToList();
            ViewBag.DStacgia = dc.TACGIAs.ToList();
            return View(sACH);
        }
        [HttpPost]
        public ActionResult themsach(DoanquanlysachV3.Models.SACH sACH)
        {


            //if (ModelState.IsValid)
            //{
            //    Models.TACGIA tg = null;
            //    if (tg != null)
            //    {
            //        Session["DStacgia"] = tg;
            //        return RedirectToAction("IndexS");
            //    }
            //}
            if (ModelState.IsValid)
            {
                List<Models.TACGIA> ds = Session["DStacgia"] as List<Models.TACGIA>;
                //dc.TACGIAs.AddRange(ds);
                foreach (var item in ds)
                {
                    sACH.TACGIAs.Add(dc.TACGIAs.Find(item.MaTacGia));
                }
                dc.SACHes.Add(sACH);
                dc.SaveChanges();
                return RedirectToAction("IndexS");
            }
            ViewBag.DSnxb = dc.NHAXUATBANs.ToList();
            ViewBag.DStheloai = dc.THELOAIs.ToList();
            //ViewBag.DStacgia = new SelectList(dc.TACGIAs, "MaTacGia", "TenTacGia");
            ViewBag.DStacgia = dc.TACGIAs.ToList();
            return View("Formthemsach");
            //return RedirectToAction("IndexS");


            //dc.SaveChanges();

            //return RedirectToAction("IndexS");
        
          
          
        }
        public ActionResult chonnhieutacgia(string id)
        {

            List<Models.TACGIA> ds = Session["DStacgia"] as List<Models.TACGIA>;
            DoanquanlysachV3.Models.TACGIA a = dc.TACGIAs.Find(id);
            if (a != null)
            {
                if (ds.Find(x => x.MaTacGia == a.MaTacGia) == null)
                {
                    ds.Add(a);
                }
            }
            return View(ds);
        }
        



    }
}