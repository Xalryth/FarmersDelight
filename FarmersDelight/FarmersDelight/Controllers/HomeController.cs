using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmersDelight.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Hjemme";

            return View();
        }

        public ActionResult ControlPanel() {
            ViewBag.Title = "Kontrol Panel";

            return View();
        }

        public ActionResult Statistics() {
            ViewBag.Title = "Statistikker";

            return View();
        }
    }
}
