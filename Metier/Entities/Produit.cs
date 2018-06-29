using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    [Serializable()]
    public class Produit : ISerializable
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public bool Actif { get; set; }
        public int Stock { get; set; }
        public double Prix { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        public Produit() {}
        public Produit(int code, string libelle, string description, bool actif, int stock, double prix, Categorie categorie)
        {
            Code = code;
            Libelle = libelle;
            Description = description;
            Actif = actif;
            Stock = stock;
            Prix = prix;
            Categorie = categorie;
        }

        //Désarialisation
        public Produit(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Code = (int)info.GetValue("Code", typeof(int));
            Libelle = (string)info.GetValue("Libelle", typeof(string));
            Description = (string)info.GetValue("Description", typeof(string));
            Actif = (bool)info.GetValue("Actif", typeof(bool));
            Stock = (int)info.GetValue("Stock", typeof(int));
            Prix = (int)info.GetValue("Prix", typeof(int));
            CategorieId = (int)info.GetValue("CategorieId", typeof(int));
            Categorie = (Categorie)info.GetValue("Categorie", typeof(Categorie));
        }

        //Serialisation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Code", Code);
            info.AddValue("Libelle", Libelle);
            info.AddValue("Description", Description);
            info.AddValue("Actif", Actif);
            info.AddValue("Stock", Stock);
            info.AddValue("Prix", Prix);
            info.AddValue("CategorieId", CategorieId);
            info.AddValue("Categorie", Categorie);
        }
    }
}