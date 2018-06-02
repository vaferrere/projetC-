using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Libelle{ get; set;}
        public bool Actif{ get; set; }

        public Categorie() { }
        public Categorie(string libelle, bool actif)
        {
            Libelle = libelle;
            Actif = actif;
        }
    }
}
