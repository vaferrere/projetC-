using BLL;
using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Categorie categorie = new Categorie("Champignon", true);

                Produit produit = new Produit(1, "Champignon", "Champignon de Paris", true, 7, 0.50, categorie);

                Manager manager = new Manager();
                manager.AjouterProduit(produit);
                List<Produit> listeProduits = manager.GetAllProduit();
                foreach (Produit p in listeProduits)
                {
                    Console.WriteLine($"Libelle : {p.Libelle}\nCatégorie : {p.CategorieId}\n");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ta mere la pute");
                Console.ReadLine();
            }

        }
    }
}
