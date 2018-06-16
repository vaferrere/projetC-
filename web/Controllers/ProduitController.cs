using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Metier.Entities;
using web.Models;
using MainApplication.Converter;

namespace web.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            Manager manager = new Manager();
            List<Produit> produits = manager.GetAllProduit();
            return View("Index", produits);
        }
    }
}