using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAuth.Controllers
{

    [RequireHttps] // affinchè tutte le richieste usino HTTPS - un modo più sicuro sarebbe quello di aggiungere questo attributo all'applicazione (vedi tutorial)
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}