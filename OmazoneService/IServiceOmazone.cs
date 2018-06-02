using System;
using System.ServiceModel;
using OmazoneService.DataContracts;

namespace OmazoneService
{
    [ServiceContract]
    public interface IServiceOmazone
    {
        [OperationContract]
        ProduitDataContract GetProduitById(int Id);

        [OperationContract]
        ProduitDataContract GetProduitByNom(String Nom);

    }
}
