using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Produit : ICloneable
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
