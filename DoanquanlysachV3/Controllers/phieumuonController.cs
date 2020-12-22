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
    }
}