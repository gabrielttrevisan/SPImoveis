using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPImoveis.Entities;

namespace SPImoveis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entity = new ClientEntity();
            var Model = entity.RunProcudure("GetClients");

            return View(Model);
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