using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTelletMachine.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index  -- Routing
        public ActionResult Index()
        {
            return View();
        }

        //GET /home/about  -- Routing
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