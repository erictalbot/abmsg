using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AbmsgModel;
using AbmsgModel.Data;
using abmsgFB;
using Abmsg.Models.Views;

namespace Abmsg.Controllers
{
    public class HomeController : Controller
    {
        protected IUow Uow { get; set; }


        public HomeController(IUow uow)
        {
            Uow = uow;
        }

        public ActionResult Index()
        {
            ViewBag.IsAuthenticated = HttpContext.User.Identity.IsAuthenticated;
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
        public ActionResult NewsAdd()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetNews(int id)
        {
            HomeViewModel model = new HomeViewModel(Uow.News.GetById(id));
            return View(model);
        }

        [Authorize]
        public ActionResult NewsEdit(int id)
        {
            HomeViewModel model = new HomeViewModel(Uow.News.GetById(id));
            return View(model);
        }

    }
}
