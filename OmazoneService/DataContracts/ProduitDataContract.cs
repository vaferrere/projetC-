using System;
using System.Runtime.Serialization;
using Metier.Entities;

namespace OmazoneService.DataContracts
{
    [DataContract]
    public class ProduitDataContract
    {
        [DataMember]
        public Produit Produit { get; set; }


        public ProduitDataContract(Produit produit)
        {
            Produit = produit;
        }
    }
}
