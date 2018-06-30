using BLL;
using MainApplication.Converter;
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

            List<Produit> listDb = manager.GetAllProduit();
            foreach (Produit produit in listDb)
            {
                ProduitViewModel pvm = ProduitConverter.ProduitToProduitViewModel(produit);
                listeProduit.Add(pvm);
            }
        }

    }
}
