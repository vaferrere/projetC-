using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OmazoneService.DataContracts;
using BLL;

namespace OmazoneService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class OmazoneService : IServiceOmazone
    {
        private Manager manager;
        public OmazoneService()
        {

        }

        public ProduitDataContract GetProduitById(int Id)
        {
            return null; //Temporaire
        }

        public ProduitDataContract GetProduitByNom(string Nom)
        {
            throw new NotImplementedException();
        }
    }
}
