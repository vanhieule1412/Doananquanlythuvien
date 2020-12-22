using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.ComponentModel.DataAnnotations;

namespace DoanquanlysachV3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start()
        {
            Session["DStacgia"] = new List<DoanquanlysachV3.Models.TACGIA>();
            Session["DSsach"] = new List<DoanquanlysachV3.Models.SACH>();
            Session["DSdocgia"] = new List<DoanquanlysachV3.Models.SACH>();
            Session["DSchitiet"] = new List<DoanquanlysachV3.Models.Cchitietsachtacgia>();


        }

    }
}
