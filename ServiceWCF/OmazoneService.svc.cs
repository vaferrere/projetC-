using BLL;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class OmazoneService : IOmazoneService
    {
        public List<CategorieContract> GetAllCategories()
        {
            List<CategorieContract> returnList = new List<CategorieContract>();
            List<Categorie> listBll;
            Manager manager = new Manager();

            listBll = manager.GetAllCategorie();

            foreach(Categorie c in listBll)
            {
                returnList.Add(new CategorieContract
                {
                    Categorie = c
                });
            }

            return returnList;
        }

        public List<ProduitContract> GetAllProduits()
        {
            List<ProduitContract> returnList = new List<ProduitContract>();
            List<Produit> listBll;
            Manager manager = new Manager();

            listBll = manager.GetAllProduit();

            foreach (Produit p in listBll)
            {
                returnList.Add(new ProduitContract
                {
                    Produit = p
                });
            }

            return returnList;
        }

        public StockContract GetProduitStock(int code)
        {
            Manager manager = new Manager();
            StockContract stock = new StockContract();

            stock.stock= manager.GetProduitByCode(code).Code;

            return stock;
        }
    }
}
