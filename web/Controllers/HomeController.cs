using BLL;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Manager manager = new Manager();
            List<Commande> commandes = manager.DernieresCommandes();
            return View(commandes);
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