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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IOmazoneService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/categories")]
        List<CategorieContract> GetAllCategories();

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           UriTemplate = "/produits")]
        List<ProduitContract> GetAllProduits();

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           UriTemplate = "/produit/stock?code={code}")]
        StockContract GetProduitStock(int code);

        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CategorieContract
    {
        [DataMember]
        public Categorie Categorie;
    }

    [DataContract]
    public class ProduitContract
    {
        [DataMember]
        public Produit Produit;
    }

    [DataContract]
    public class StockContract
    {
        [DataMember]
        public int stock;
    }
}
