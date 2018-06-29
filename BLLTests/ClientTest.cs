using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections.Generic;
using Metier.Entities;

namespace BLLTests
{
    [TestClass]
    public class ClientTest
    {
        Manager manager = new Manager();

        [TestInitialize]
        public void Initialize()
        {
            manager.PurgeDatabase();
        }

        [TestMethod]
        public void EmptyClientDatabaseTest()
        {
            List<Client> clients = manager.GetAllClient();
            int clientCount = clients.Count;
            Assert.AreEqual(0, clientCount);
        }

        [TestMethod]
        public void InsertClientTest()
        {
            Client client = new Client("Nom", "Prenom", true);

            manager.AjouterClient(client);

            Client dbClient = manager.GetAllClient()[0];
            Assert.AreSame(client, dbClient);
        }

        [TestMethod]
        public void SupprimerClientTest()
        {
            Client client = new Client("Nom", "Prenom", true);

            manager.AjouterClient(client);
            Client dbClient = manager.GetAllClient()[0];
            manager.SupprimerClient(dbClient.Id);

            List<Client> clients = manager.GetAllClient();
            int clientCount = clients.Count;
            Assert.AreEqual(0, clientCount);
        }

        [TestMethod]
        public void ModifieClientTest()
        {
            Client client = new Client("Nom", "Prenom", true);
            Client savedClient = ObjectCopier.Clone<Client>(client);

            manager.AjouterClient(client);
            client = manager.GetAllClient()[0];
            client.Nom = "je suis un nom modifié";
            manager.ModifierClient(client);

            client = manager.GetAllClient()[0];
            Assert.AreNotEqual(client, savedClient);
        }
    }
}
