using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections.Generic;
using Metier.Entities;

namespace BLLTests
{
    [TestClass]
    public class CommandeTest
    {
        Manager manager = new Manager();

        [TestInitialize]
        public void Initialize()
        {
            manager.PurgeDatabase();
        }

        [TestMethod]
        public void EmptyCommandeDatabaseTest()
        {
            List<Commande> commandes = manager.GetAllCommande();
            int commandeCount = commandes.Count;
            Assert.AreEqual(0, commandeCount);
        }

        [TestMethod]
        public void InsertCommandeTest()
        {
            Commande commande = new Commande(DateTime.Now, "observation test", new Statut("libelle test"), new Client("nom", "prenom", true));

            manager.AjouterCommande(commande);

            Commande dbCommande = manager.GetAllCommande()[0];
            Assert.AreSame(commande, dbCommande);
        }

        [TestMethod]
        public void SupprimerCommandeTest()
        {
            Commande commande = new Commande(DateTime.Now, "observation test", new Statut("libelle test"), new Client("nom", "prenom", true));

            manager.AjouterCommande(commande);
            Commande dbCommande = manager.GetAllCommande()[0];
            manager.SupprimerCommande(dbCommande.Id);

            List<Commande> commandes = manager.GetAllCommande();
            int commandeCount = commandes.Count;
            Assert.AreEqual(0, commandeCount);
        }

        [TestMethod]
        public void ModifieCommandeTest()
        {
            Commande commande = new Commande(DateTime.Now, "observation test", new Statut("libelle test"), new Client("nom", "prenom", true));
            Commande savedCommande = ObjectCopier.Clone<Commande>(commande);

            manager.AjouterCommande(commande);
            commande = manager.GetAllCommande()[0];
            commande.Observation = "je suis une observation modifié";
            manager.ModifierCommande(commande);

            commande = manager.GetAllCommande()[0];
            Assert.AreNotEqual(commande, savedCommande);
        }
    }
}
