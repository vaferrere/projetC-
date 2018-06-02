using MainApplication.ViewModels;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Converter
{
    public static class ProduitConverter
    {
        public static ProduitViewModel ProduitToProduitViewModel(Produit produit)
        {
            ProduitViewModel produitViewModel = new ProduitViewModel();

            produitViewModel.Actif = produit.Actif;
            produitViewModel.Categorie = produit.Categorie;
            produitViewModel.Code = produit.Code;
            produitViewModel.Description = produit.Description;
            produitViewModel.Id = produit.Id;
            produitViewModel.Libelle = produit.Libelle;
            produitViewModel.Prix = produit.Prix;
            produitViewModel.Stock = produit.Stock;

            return produitViewModel;
        }

        public static Produit ProduitViewModelToProduit(ProduitViewModel produitViewModel)
        {
            Produit produit = new Produit();

            produit.Actif = produitViewModel.Actif;
            produit.Categorie = produitViewModel.Categorie;
            produit.CategorieId = produitViewModel.Categorie.Id;
            produit.Code = produitViewModel.Code;
            produit.Description = produitViewModel.Description;
            produit.Id = produitViewModel.Id;
            produit.Libelle = produitViewModel.Libelle;
            produit.Prix = produitViewModel.Prix;
            produit.Stock = produitViewModel.Stock;

            return produit;
        }
    }
}
