using BLL;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.ViewModels
{
    class ListeProduitViewModel : BaseViewModel
    {
        private ProduitViewModel selectedProduit;
        public ProduitViewModel SelectedProduit {
            get { return selectedProduit; }
            set
            {
                selectedProduit = value;
                Console.WriteLine(selectedProduit.Libelle);
                OnPropertyChanged("SelectedProduit");
            }
        }

        private ObservableCollection<ProduitViewModel> listeProduit;
        public ObservableCollection<ProduitViewModel> ListeProduit
        {
            get { return listeProduit; }
            set
            {
                listeProduit = value;
                OnPropertyChanged("ListeProduit");
            }
        }

        public ListeProduitViewModel()
        {
            Manager manager = new Manager();
            listeProduit = new ObservableCollection<ProduitViewModel>();

            Categorie mCategorie = new Categorie();
            mCategorie.Actif = true;
            mCategorie.Id = 0;
            mCategorie.Libelle = "trop bien";

            ProduitViewModel mProduitViewModel = new ProduitViewModel();
            mProduitViewModel.Id = 02;
            mProduitViewModel.Libelle = "je suis le libelle";
            mProduitViewModel.Prix = 0.45;
            mProduitViewModel.Stock = 42;
            mProduitViewModel.Actif = true;
            mProduitViewModel.Categorie = mCategorie;
            mProduitViewModel.Code = 45235;
            mProduitViewModel.Description = "je suis un objet de test";

            listeProduit.Add(mProduitViewModel);
            manager.AjouterProduit(Converter.ProduitConverter.ProduitViewModelToProduit(mProduitViewModel));
            mCategorie = new Categorie();
            mCategorie.Actif = true;
            mCategorie.Id = 0;
            mCategorie.Libelle = "trop nul";

            mProduitViewModel = new ProduitViewModel();
            mProduitViewModel.Id = 03;
            mProduitViewModel.Libelle = "je suis le libelle2";
            mProduitViewModel.Prix = 0.75;
            mProduitViewModel.Stock = 81;
            mProduitViewModel.Actif = false;
            mProduitViewModel.Categorie = mCategorie;
            mProduitViewModel.Code = 54915;
            mProduitViewModel.Description = "je suis un objet de test2";

            listeProduit.Add(mProduitViewModel);
            manager.AjouterProduit(Converter.ProduitConverter.ProduitViewModelToProduit(mProduitViewModel));
        }

    }
}
