using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class ProduitViewModel
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private int code;
        public int Code { get { return code; } set { code = value; } }

        private string libelle;
        public string Libelle { get { return libelle; } set { libelle = value; } }

        private string description;
        public string Description { get { return description; } set { description = value; } }

        private bool actif;
        public bool Actif { get { return actif; } set { actif = value; } }

        private int stock;
        public int Stock { get { return stock; } set { stock = value; } }

        private double prix;
        public double Prix { get { return prix; } set { prix = value; } }

        private Categorie categorie;
        public Categorie Categorie { get { return categorie; } set { categorie = value; } }

        public ProduitViewModel() { }
    }
}