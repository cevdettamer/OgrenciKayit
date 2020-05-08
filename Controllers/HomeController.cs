using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciKayit.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult About()
        {
            ViewBag.Message = "Hakkımızda Sayfası.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Sayfası.";

            return View();
        }
    }
}