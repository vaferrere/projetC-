using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Commands
{
    class ProduitCommand
    {
        private readonly ContextFluent contexte;

        public ProduitCommand(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public int Ajouter(Produit produit)
        {
            try
            {
                contexte.Produits.Add(produit);
                return contexte.SaveChanges();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void Modifier(Produit produit)
        {
            Produit oldProduit = contexte.Produits.Where(c => c.Id == produit.Id).FirstOrDefault();

            if (oldProduit != null)
            {
                oldProduit.Code = produit.Code;
                oldProduit.Libelle = produit.Libelle;
                oldProduit.Description = produit.Description;
                oldProduit.Actif = produit.Actif;
                oldProduit.Stock = produit.Stock;
                oldProduit.Prix = produit.Prix;
                oldProduit.CategorieId = produit.CategorieId;
                oldProduit.Categorie = produit.Categorie;
            }

            contexte.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Produit oldProduit = contexte.Produits.Where(c => c.Id == id).FirstOrDefault();

            if (oldProduit != null)
            {
                contexte.Produits.Remove(oldProduit);
            }

            contexte.SaveChanges();
        }
    }
}
