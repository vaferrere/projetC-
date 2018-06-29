using BLL.Commands;
using BLL.Queries;
using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager
    {
        private ContextFluent contexte;
        private static Manager manager = null;

        public Manager()
        {
            contexte = new ContextFluent();
        }

        public static Manager Instance
        {
            get
            {
                if (manager == null)
                {
                    manager = new Manager();
                }
                return manager;
            }
        }

        public void PurgeDatabase()
        {
            CategorieCommand catC = new CategorieCommand(contexte);
            ClientCommand cliC = new ClientCommand(contexte);
            CommandeCommand comC = new CommandeCommand(contexte);
            ProduitCommand proC = new ProduitCommand(contexte);
            StatutCommand staC = new StatutCommand(contexte);

            catC.Purge();
            cliC.Purge();
            comC.Purge();
            proC.Purge();
            staC.Purge();
        }

        /**
         *  CATEGORIE
         */
        public List<Categorie> GetAllCategorie()
        {
            CategorieQuery pq = new CategorieQuery(contexte);
            return pq.GetAll().ToList();
        }

        public Categorie GetCategorie(int id)
        {
            CategorieQuery pq = new CategorieQuery(contexte);
            return (Categorie) pq.GetById(id);
        }

        public int AjouterCategorie(Categorie categorie)
        {
            CategorieCommand cc = new CategorieCommand(contexte);
            return cc.Ajouter(categorie);
        }

        public void ModifierCategorie(Categorie categorie)
        {
            CategorieCommand cc = new CategorieCommand(contexte);
            cc.Modifier(categorie);
        }

        public void SupprimerCategorie(int id)
        {
            CategorieCommand cc = new CategorieCommand(contexte);
            cc.Supprimer(id);
        }


        /**
         *  CLIENT
         */
        public List<Client> GetAllClient()
        {
            ClientQuery cq = new ClientQuery(contexte);
            return cq.GetAll().ToList();
        }

        public int AjouterClient(Client client)
        {
            ClientCommand cc = new ClientCommand(contexte);
            return cc.Ajouter(client);
        }

        public void ModifierClient(Client client)
        {
            ClientCommand cc = new ClientCommand(contexte);
            cc.Modifier(client);
        }

        public void SupprimerClient(int id)
        {
            ClientCommand cc = new ClientCommand(contexte);
            cc.Supprimer(id);
        }

        /**
         *  COMMANDE
         */
        public List<Commande> GetAllCommande()
        {
            CommandeQuery cq = new CommandeQuery(contexte);
            return cq.GetAll().ToList();
        }

        public int AjouterCommande(Commande commande)
        {
            CommandeCommand cc = new CommandeCommand(contexte);
            return cc.Ajouter(commande);
        }

        public void ModifierCommande(Commande commande)
        {
            CommandeCommand cc = new CommandeCommand(contexte);
            cc.Modifier(commande);
        }

        public void SupprimerCommande(int id)
        {
            CommandeCommand cc = new CommandeCommand(contexte);
            cc.Supprimer(id);
        }


        /**
         *  PRODUIT
         */
        public List<Produit> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetAll().ToList();
        }

        public Produit GetProduit(int id)
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return (Produit)pq.GetById(id);
        }
        
        public int AjouterProduit(Produit produit)
        {
            if (produit.Stock < 0 || produit.Prix <= 0)

            {
                throw new ArgumentOutOfRangeException();
            }

            ProduitCommand pc = new ProduitCommand(contexte);
            return pc.Ajouter(produit);
        }

        public void ModifierProduit(Produit produit)
        {
            if (produit.Stock < 0 || produit.Prix <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Modifier(produit);
        }

        public void SupprimerProduit(int id)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Supprimer(id);
        }


        /**
         *  STATUT
         */
        public List<Statut> GetAllStatut()
        {
            StatutQuery cq = new StatutQuery(contexte);
            return cq.GetAll().ToList();
        }

        public int AjouterStatut(Statut statut)
        {
            StatutCommand sc = new StatutCommand(contexte);
            return sc.Ajouter(statut);
        }

        public void ModifierStatut(Statut statut)
        {
            StatutCommand sc = new StatutCommand(contexte);
            sc.Modifier(statut);
        }

        public void SupprimerStatut(int id)
        {
            StatutCommand sc = new StatutCommand(contexte);
            sc.Supprimer(id);
        }
    }
}
