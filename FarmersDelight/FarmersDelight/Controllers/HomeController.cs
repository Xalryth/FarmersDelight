﻿using System.Globalization;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace FarmersDelight.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = $"{Resources.Global.Menu_AppName.ToString()} > {Resources.Global.Menu_Home.ToString()}";

            return View();
        }

        public ActionResult Statistics()
        {
            ViewBag.Title = $"{Resources.Global.Menu_AppName.ToString()} > {Resources.Global.Menu_Statistics.ToString()}"; ;

            return View();
        }

        public ActionResult ControlPanel()
        {
            ViewBag.Title = $"{Resources.Global.Menu_AppName.ToString()} > {Resources.Global.Menu_ControlPanel.ToString()}"; ;

            return View();
        }

        public ActionResult ChangeLanguage(string languageNotation)
        {
            //track current view

            if (languageNotation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageNotation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageNotation);
            }

            HttpCookie cookie = new HttpCookie("language");
            cookie.Value = languageNotation;
            Response.Cookies.Add(cookie);

            //return tracked view instead
            return View("Index");
        }

        public string GetCurrentLanguageImage()
        {
            string imageStr = "";
            switch (Request.Cookies["language"].Value)
            {
                case "en-US":
                    imageStr = "united-states-of-america";
                    break;
                case "da-DK":
                    imageStr = "denmark";
                    break;
                case "de-DE":
                    imageStr = "germany";
                    break;
                default:
                    imageStr = "united-states-of-america";
                    break;
            }

            return Path.Combine("/Resources/Images/svg/countries", imageStr + ".svg");
        }
    }
}
