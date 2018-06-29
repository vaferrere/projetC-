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

        public List<Produit> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetAll().ToList();
        }

        public Produit getProduitById(int id)
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return (Produit)pq.GetById(id);
        }
        
        public int AjouterProduit(Produit produit)
        {
            if(produit.Stock < 0 || produit.Prix < 0)
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

        public bool ProduitExist(Produit produit)
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            IQueryable<Produit> p = pq.GetById(produit.Id);

            if (p == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Categorie> GetAllCategorie()
        {
            CategorieQuery cq = new CategorieQuery(contexte);
            return cq.GetAll().ToList();
        }

        public int AjouterCategorie(Categorie categorie)
        {
            CategorieCommand cc = new CategorieCommand(contexte);
            return cc.Ajouter(categorie);
        }

        public Categorie GetCategorie(int id)
        {
            CategorieQuery cq = new CategorieQuery(contexte);
            return cq.GetById(id).FirstOrDefault();
        }

        public void ModifierCategorie(Categorie categorie)
        {
            CategorieCommand cc = new CategorieCommand(contexte);
            cc.Modifier(categorie);
        }

        public void PurgeDatabase()
        {
            CategorieCommand catC = new CategorieCommand(contexte);
            ClientCommand cliC    = new ClientCommand(contexte);
            CommandeCommand comC  = new CommandeCommand(contexte);
            ProduitCommand proC   = new ProduitCommand(contexte);
            StatutCommand staC    = new StatutCommand(contexte);

            catC.Purge();
            cliC.Purge();
            comC.Purge();
            proC.Purge();
            staC.Purge();
        }
    }
}
