using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections.Generic;
using Metier.Entities;

namespace BLLTests
{
    [TestClass]
    public class ProduitTest
    {
        Manager manager = new Manager();

        [TestInitialize]
        public void Initialize()
        {
            manager.PurgeDatabase();
        }

        [TestMethod]
        public void EmptyProduitDatabaseTest()
        {
            List<Produit> produits = manager.GetAllProduit();
            int produitCount = produits.Count;
            Assert.AreEqual(0, produitCount);
        }

        [TestMethod]
        public void InsertProduitTest()
        {
            Categorie cat = new Categorie("cat test", true);
            Produit produit = new Produit(1, "test_produit", " je suis un produit de test", true, 42, 42.42d, cat);

            manager.AjouterProduit(produit);

            Produit dbProduit = manager.GetAllProduit()[0];
            Assert.AreSame(produit, dbProduit);
        }

        [TestMethod]
        public void SupprimerProduitTest()
        {
            Categorie cat = new Categorie("cat test", true);
            Produit produit = new Produit(1, "test_produit", " je suis un produit de test", true, 42, 42.42d, cat);

            manager.AjouterProduit(produit);
            Produit dbProduit = manager.GetAllProduit()[0];
            manager.SupprimerProduit(dbProduit.Id);

            List<Produit> produits = manager.GetAllProduit();
            int produitCount = produits.Count;
            Assert.AreEqual(0, produitCount);
        }

        [TestMethod]
        public void ModifierProduitTest()
        {
            Categorie cat = new Categorie("cat test", true);
            Produit produit = new Produit(1, "test_produit", " je suis un produit de test", true, 42, 42.42d, cat);

            manager.AjouterProduit(produit);
            Produit dbProduit = manager.GetAllProduit()[0];
            Produit mProduit = (Produit)dbProduit.Clone();
            mProduit.Libelle = "je suis un libelle modifié";
            manager.ModifierProduit(mProduit);

            dbProduit = manager.GetAllProduit()[0];
            Assert.AreNotEqual(produit, dbProduit);
        }
    }
}
