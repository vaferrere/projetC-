using BLL;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        public ActionResult Index()
        {
            Manager manager = new Manager();
            List<Categorie> categories = manager.GetAllCategorie();
            return View(categories);
        }

        // GET: Categorie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categorie/Create
        public ActionResult Ajout()
        {
            return View();
        }

        // POST: Categorie/Create
        [HttpPost]
        public ActionResult Ajout(Categorie categorie)
        {
            try
            {
                Manager manager = new Manager();
                manager.AjouterCategorie(categorie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorie/Edit/5
        public ActionResult Edit(int id)
        {
            Manager manager = new Manager();
            Categorie categorie = manager.GetCategorie(id);
            return View("Ajout", categorie);
        }

        // POST: Categorie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Categorie categorie)
        {
            try
            {
                Manager manager = new Manager();
                manager.ModifierCategorie(categorie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Ajout");
            }
        }

        // GET: Categorie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categorie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
