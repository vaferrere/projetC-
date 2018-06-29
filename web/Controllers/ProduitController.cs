﻿using BLL;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            Manager manager = new Manager();
            List<Produit> produits = manager.GetAllProduit();
            return View(produits);
        }

        // GET: Produit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produit/Create
        public ActionResult Ajout()
        {
            return View();
        }

        // POST: Produit/Create
        [HttpPost]
        public ActionResult Ajout(Produit produit)
        {
            try
            {
                Manager manager = new Manager();
                manager.AjouterProduit(produit);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produit/Edit/5
        public ActionResult Edit(int id)
        {
            Manager manager = new Manager();
            Produit produit = manager.getProduitById(id);
            return View("Ajout", produit);
        }

        // POST: Produit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Produit produit)
        {
            try
            {
                Manager manager = new Manager();
                manager.ModifierProduit(produit);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Ajout");
            }
        }

        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produit/Delete/5
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
