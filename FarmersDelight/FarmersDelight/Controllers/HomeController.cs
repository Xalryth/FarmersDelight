using System;
using System.DirectoryServices;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using FarmersDelight.Dal;

namespace FarmersDelight.Controllers
{
    public class HomeController : Controller
    {
        string adPath = "LDAP://url.com";
        string domainName = "url";
        FarmContext context = new FarmContext();

        public ActionResult Index()
        {
            ViewBag.Title = $"{Resources.Global.Menu_AppName.ToString()} > {Resources.Global.Menu_Home.ToString()}";

            if(Request.Cookies["language"].Value == null)
            {
                ChangeLanguage(null);
            }
            return View();
        }

        public ActionResult Statistics(string buildingName, string sensorName, int? filterType)
        {
            ViewBag.Title = $"{Resources.Global.Menu_AppName.ToString()} > {Resources.Global.Menu_Statistics.ToString()}"; ;

            return View(context.buildings);
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

        public bool AuthenticateUser(string username, string passwordHash)
        {
            username = username.Split('@')[0];
            string domainAndUsername = domainName + @"\" + username;

            DirectoryEntry entry =
                new DirectoryEntry(
                    adPath,
                    domainAndUsername,
                    passwordHash);
            try
            {
                object obj = entry.NativeObject;

                DirectorySearcher search = new DirectorySearcher(entry);

                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.AddRange(
                    new string[] {
                    "SAMAccountName",
                    "cn",
                    "userAccountControl"
                    });

                SearchResult result = search.FindOne();

                if (result == null)
                {
                    return false;
                }
                else {
                    Session["ADUserID"] = string.Empty;
                    Session["ADUserName"] = string.Empty;
                    Session["ADUserAccountControl"] = string.Empty;

                    Session["ADUserID"] = result.Properties["SAMAccountName"][0];
                    Session["ADUserName"] = result.Properties["cn"][0];
                    Session["ADUserAccountControl"] = Convert.ToString(result.Properties["userAccountControl"]);
                }
            }
            catch (Exception)
            {
                return false;

                throw;
            }

            return true;
        }
    }
}
