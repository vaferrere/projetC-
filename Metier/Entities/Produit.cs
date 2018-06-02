using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Produit
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
    }
}
