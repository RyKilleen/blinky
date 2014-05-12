using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blinky.Controllers
{
    public class HomeController : Controller
    {

           

        public ActionResult Index()
        {
            return View();
        }

        public string Push()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<BlinkHub>();

            hubContext.Clients.All.isPushed();

            ViewBag.Message = "Pushed!";

            return "Pushed!";

        }

        public string Release()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<BlinkHub>();

            hubContext.Clients.All.isReleased();

            ViewBag.Message = "Released!";

            return "released!";

        }

        public ActionResult Status()
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