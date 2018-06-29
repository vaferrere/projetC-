using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections.Generic;
using Metier.Entities;

namespace BLLTests
{
    [TestClass]
    public class StatutTest
    {
        Manager manager = new Manager();

        [TestInitialize]
        public void Initialize()
        {
            manager.PurgeDatabase();
        }

        [TestMethod]
        public void EmptyStatutDatabaseTest()
        {
            List<Statut> statuts = manager.GetAllStatut();
            int statutCount = statuts.Count;
            Assert.AreEqual(0, statutCount);
        }

        [TestMethod]
        public void InsertStatutTest()
        {
            Statut statut = new Statut("je suis un libelle");

            manager.AjouterStatut(statut);

            Statut dbStatut = manager.GetAllStatut()[0];
            Assert.AreSame(statut, dbStatut);
        }

        [TestMethod]
        public void SupprimerStatutTest()
        {
            Statut statut = new Statut("je suis un libelle");

            manager.AjouterStatut(statut);
            Statut dbStatut = manager.GetAllStatut()[0];
            manager.SupprimerStatut(dbStatut.Id);

            List<Statut> statuts = manager.GetAllStatut();
            int statutCount = statuts.Count;
            Assert.AreEqual(0, statutCount);
        }

        [TestMethod]
        public void ModifierStatutTest()
        {
            Statut statut = new Statut("je suis un libelle");
            Statut savedStatut = ObjectCopier.Clone<Statut>(statut);

            manager.AjouterStatut(statut);
            statut = manager.GetAllStatut()[0];
            statut.Libelle = "je suis un libelle modifié";
            manager.ModifierStatut(statut);

            statut = manager.GetAllStatut()[0];
            Assert.AreNotEqual(statut, savedStatut);
        }
    }
}
