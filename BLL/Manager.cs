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
        private readonly ContextFluent contexte;
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

        public int AjouterProduit(Produit produit)
        {
            if(produit.Stock < 0 || produit.Prix <= 0)
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

        public List<Categorie> GetAllCategorie()
        {
            CategorieQuery pq = new CategorieQuery(contexte);
            return pq.GetAll().ToList();
        }
    }
}
