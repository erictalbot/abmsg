using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AbmsgModel;
using AbmsgModel.Data;
using abmsgFB;

namespace Abmsg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.baseUrl = "http://www.abmsg.ca/api/news/";
            return View();
        }

        public ActionResult Responsables()
        {
            return View();
        }

        public ActionResult RallyCap()
        {
            return View();
        }

        [Authorize]
        public ActionResult NewsEdit()
        {
            return View();
        }
    }
}
