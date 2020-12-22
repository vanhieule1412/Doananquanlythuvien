using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanquanlysachV3.Controllers
{
    public class chitietController : Controller
    {
        private Models.QuanLyThuVienEntities dc = new Models.QuanLyThuVienEntities();
        // GET: chitiet
        public ActionResult IndexCT()
        {
            List<Models.Cchitietsachtacgia> ds = Session["DSchitiet"] as List<Models.Cchitietsachtacgia>;
            foreach (var item in ds)
            {
                
                SelectListItem selectListItem = new SelectListItem {
                    Value =item.MaSach,
                    Text=item.MaSach,
                };
                ViewBag.chitiet = selectListItem;

            }
            

            //List<SelectListItem> items = new List<SelectListItem>();
            //foreach (var item in ds)
            //{
            //    SelectListItem selectListItem = new SelectListItem
            //    {
            //        Text = item.MaSach,
            //        Value = item.MaTacGia,
            //    };
            //    ViewBag.chitiet = selectListItem;
            //}
            return View(ds.ToList());
        }
    }
}