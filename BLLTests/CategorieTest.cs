using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections.Generic;
using Metier.Entities;

namespace BLLTests
{
    [TestClass]
    public class CategorieTest
    {
        Manager manager = new Manager();

        [TestInitialize]
        public void Initialize()
        {
            manager.PurgeDatabase();
        }

        [TestMethod]
        public void EmptyCategorieDatabaseTest()
        {
            List<Categorie> categories = manager.GetAllCategorie();
            int categorieCount = categories.Count;
            Assert.AreEqual(0, categorieCount);
        }

        [TestMethod]
        public void InsertCategorieTest()
        {
            Categorie categorie = new Categorie("cat test", true);

            manager.AjouterCategorie(categorie);

            Categorie dbCategorie = manager.GetAllCategorie()[0];
            Assert.AreSame(categorie, dbCategorie);
        }

        [TestMethod]
        public void SupprimerCategorieTest()
        {
            Categorie categorie = new Categorie("cat test", true);

            manager.AjouterCategorie(categorie);
            Categorie dbCategorie = manager.GetAllCategorie()[0];
            manager.SupprimerCategorie(dbCategorie.Id);

            List<Categorie> categories = manager.GetAllCategorie();
            int categorieCount = categories.Count;
            Assert.AreEqual(0, categorieCount);
        }

        [TestMethod]
        public void ModifierCategorieTest()
        {
            Categorie categorie = new Categorie("cat test", true);
            Categorie savedCategorie = ObjectCopier.Clone<Categorie>(categorie);

            manager.AjouterCategorie(categorie);
            categorie = manager.GetAllCategorie()[0];
            categorie.Libelle = "je suis un libelle modifié";
            manager.ModifierCategorie(categorie);

            categorie = manager.GetAllCategorie()[0];
            Assert.AreNotEqual(categorie, savedCategorie);
        }
    }
}
